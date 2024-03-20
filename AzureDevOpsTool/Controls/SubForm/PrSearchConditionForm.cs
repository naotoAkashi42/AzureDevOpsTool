using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace AzureDevOpsTool.Controls
{
    public partial class PrSearchConditionForm : Form
    {
        internal record PrSearchCondition(
                            string CreatedBy, 
                            string ReviewedBy, 
                            IReadOnlyList<PullRequestStatus> Status);

        private PrSearchCondition _setting;
        internal PrSearchConditionForm(PrSearchCondition setting)
        {
            InitializeComponent();
            _setting = setting;

            this.Load += PrSearchConditionForm_Load;
        }

        private void PrSearchConditionForm_Load(object? sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            _txtBoxCreatedBy.Text = _setting.CreatedBy;
            _txtBoxReviewedBy.Text = _setting.ReviewedBy;
        }
    }
}
