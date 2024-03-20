namespace AzureDevOpsTool.Controls
{
    public partial class PullRequestsControl : UserControl
    {
        internal interface INeed
        {
            string[] GetTragetProjectCandidates();
            string[] GetTargetReposCandidates(string projectName);

            string GetPullRequestInfoLog(string targetReposName);
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
            _richTextBoxResult.Text = _need.GetPullRequestInfoLog(targetRepos);
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
    }
}
