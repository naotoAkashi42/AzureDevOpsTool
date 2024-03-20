using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace AzureDevOpsTool.Controls
{
    public partial class PullRequestsControl : UserControl
    {
        internal interface INeed
        {
            string[] GetTragetProjectCandidates();
            string[] GetTargetReposCandidates(string projectName);

            string GetPullRequestsInfo(string targetReposName, PullRequestStatus status);
            string GetUniqueCsvFileName();

            void SaveToCsv(string srcStrings, FileInfo dstFileInfo);
        }

        private readonly INeed _need;

        internal PullRequestsControl(INeed need)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _need = need;

            InitTargetProjectComboBox();

            _checkBoxOutputFile.Checked = false;
            _btnFolderBrows.Enabled = false;
        }

        private void _btnExecute_Click(object sender, EventArgs e)
        {
            var targetRepos = _comboBoxRepos.Text;
            var pullReqInfo = _need.GetPullRequestsInfo(targetRepos, PullRequestStatus.Completed);
            _richTextBoxResult.Text = pullReqInfo;

            if (!_checkBoxOutputFile.Checked) return;
            var info = new FileInfo(_textBoxOutputPath.Text);

            _need.SaveToCsv(pullReqInfo, info);
        }

        private void InitTargetProjectComboBox()
        {
            _comboBoxRepos.Items.Clear();

            var candidates = _need.GetTragetProjectCandidates();
            _comboBoxTargetProj.Items.AddRange(candidates);
        }

        private void _comboBoxTargetProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitTargetReposComboBox();
        }

        private void InitTargetReposComboBox()
        {
            var targetProjName = _comboBoxTargetProj.Text;
            if (string.IsNullOrEmpty(targetProjName)) return;

            _comboBoxRepos.Items.Clear();

            var candidates = _need.GetTargetReposCandidates(targetProjName);
            _comboBoxRepos.Items.AddRange(candidates);
        }

        private void _checkBoxOutputFile_CheckedChanged(object sender, EventArgs e)
        {
            var isEnable = _checkBoxOutputFile.Checked;
            _textBoxOutputPath.Enabled = isEnable;
            _btnFolderBrows.Enabled = isEnable;
        }

        private void _btnFolderBrows_Click(object sender, EventArgs e)
        {
            using var f = new FolderBrowserDialog();
            
            var result = f.ShowDialog();
            if (result != DialogResult.OK) return;

            _textBoxOutputPath.Text = Path.Combine(f.SelectedPath, _need.GetUniqueCsvFileName());
        }
    }
}
