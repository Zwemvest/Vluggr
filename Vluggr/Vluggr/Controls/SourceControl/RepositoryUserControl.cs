using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vluggr.SourceControl;

namespace Vluggr.Client.Controls.SourceControl
{
    public partial class RepositoryUserControl : UserControl
    {
        public RepositoryUserControl()
        {
            InitializeComponent();
            var v = RepositoryInformation.GetRepositoryInformationForPath("D:\\", "C:\\Program Files\\Git\\bin\\git.exe");
            foreach (var repo in v.TrackedBranchName)
            {
                
            }
        }
    }
}
