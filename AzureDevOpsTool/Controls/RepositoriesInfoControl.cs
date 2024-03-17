namespace AzureDevOpsTool.Controls
{
    public partial class RepositoriesInfoControl : UserControl
    {
        internal interface INeed
        {
            string GetRepositoriesInfoLog();
        }

        private readonly INeed _need;
        internal RepositoriesInfoControl(INeed need)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _need = need;
        }

        private void _btnExecute_Click(object sender, EventArgs e)
        {
            _richTextBoxResult.Text = _need.GetRepositoriesInfoLog();
        }
    }
}
