using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Vluggr.SourceControl
{
    public class RepositoryInformation : IDisposable
    {
        public static RepositoryInformation GetRepositoryInformationForPath(string path, string gitPath = null)
        {
            var repositoryInformation = new RepositoryInformation(path, gitPath);
            return repositoryInformation.IsGitRepository ? repositoryInformation : null;
        }

        public string CommitHash => RunCommand("rev-parse HEAD");

        public string BranchName => RunCommand("rev-parse --abbrev-ref HEAD");

        public string TrackedBranchName => RunCommand("rev-parse --abbrev-ref --symbolic-full-name @{u}");

        public bool HasUnpushedCommits => !string.IsNullOrWhiteSpace(RunCommand("log @{u}..HEAD"));

        public bool HasUncommittedChanges => !string.IsNullOrWhiteSpace(RunCommand("status --porcelain"));

        public IEnumerable<string> Log
        {
            get
            {
                var skip = 0;
                while (true)
                {
                    var entry = RunCommand($"log --skip={skip++} -n1");
                    if (string.IsNullOrWhiteSpace(entry))
                    {
                        yield break;
                    }

                    yield return entry;
                }
            }
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _gitProcess.Dispose();
        }

        private RepositoryInformation(string path, string gitPath)
        {
            var processInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = Directory.Exists(gitPath) ? gitPath : "git.exe",
                CreateNoWindow = true,
                WorkingDirectory = (path != null && Directory.Exists(path)) ? path : Environment.CurrentDirectory
            };

            _gitProcess = new Process {StartInfo = processInfo};
        }

        private bool IsGitRepository => !string.IsNullOrWhiteSpace(RunCommand("log -1"));

        private string RunCommand(string args)
        {
            _gitProcess.StartInfo.Arguments = args;
            _gitProcess.Start();
            var output = _gitProcess.StandardOutput.ReadToEnd().Trim();
            _gitProcess.WaitForExit();
            return output;
        }

        private bool _disposed;
        private readonly Process _gitProcess;
    }
}
