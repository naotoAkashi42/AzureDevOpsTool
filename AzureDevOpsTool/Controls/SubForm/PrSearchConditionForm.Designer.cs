namespace AzureDevOpsTool.Controls
{
    partial class PrSearchConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _lblReviewer = new Label();
            _lblCreatedBy = new Label();
            _txtBoxCreatedBy = new TextBox();
            _txtBoxReviewedBy = new TextBox();
            _btnPrStatus = new Button();
            _lblStatus = new Label();
            _txtBoxPrStatusPreview = new TextBox();
            _btnOk = new Button();
            _btnCancel = new Button();
            SuspendLayout();
            // 
            // _lblReviewer
            // 
            _lblReviewer.AutoSize = true;
            _lblReviewer.Location = new Point(12, 44);
            _lblReviewer.Name = "_lblReviewer";
            _lblReviewer.Size = new Size(82, 15);
            _lblReviewer.TabIndex = 0;
            _lblReviewer.Text = "Reviwer Name";
            // 
            // _lblCreatedBy
            // 
            _lblCreatedBy.AutoSize = true;
            _lblCreatedBy.Location = new Point(12, 19);
            _lblCreatedBy.Name = "_lblCreatedBy";
            _lblCreatedBy.Size = new Size(62, 15);
            _lblCreatedBy.TabIndex = 1;
            _lblCreatedBy.Text = "PR Creator";
            // 
            // _txtBoxPrCreator
            // 
            _txtBoxCreatedBy.Location = new Point(80, 14);
            _txtBoxCreatedBy.Name = "_txtBoxPrCreator";
            _txtBoxCreatedBy.Size = new Size(226, 23);
            _txtBoxCreatedBy.TabIndex = 2;
            // 
            // _txtBoxReviewer
            // 
            _txtBoxReviewedBy.Location = new Point(100, 41);
            _txtBoxReviewedBy.Name = "_txtBoxReviewer";
            _txtBoxReviewedBy.Size = new Size(206, 23);
            _txtBoxReviewedBy.TabIndex = 3;
            // 
            // _btnPrStatus
            // 
            _btnPrStatus.Location = new Point(282, 70);
            _btnPrStatus.Name = "_btnPrStatus";
            _btnPrStatus.Size = new Size(24, 23);
            _btnPrStatus.TabIndex = 4;
            _btnPrStatus.Text = "...";
            _btnPrStatus.UseVisualStyleBackColor = true;
            // 
            // _lblStatus
            // 
            _lblStatus.AutoSize = true;
            _lblStatus.Location = new Point(12, 74);
            _lblStatus.Name = "_lblStatus";
            _lblStatus.Size = new Size(56, 15);
            _lblStatus.TabIndex = 5;
            _lblStatus.Text = "PR Status";
            // 
            // _txtBoxPrStatusPreview
            // 
            _txtBoxPrStatusPreview.Location = new Point(69, 70);
            _txtBoxPrStatusPreview.Name = "_txtBoxPrStatusPreview";
            _txtBoxPrStatusPreview.ReadOnly = true;
            _txtBoxPrStatusPreview.Size = new Size(211, 23);
            _txtBoxPrStatusPreview.TabIndex = 6;
            // 
            // _btnOk
            // 
            _btnOk.Location = new Point(151, 142);
            _btnOk.Name = "_btnOk";
            _btnOk.Size = new Size(75, 23);
            _btnOk.TabIndex = 7;
            _btnOk.Text = "OK";
            _btnOk.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            _btnCancel.Location = new Point(232, 142);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.Size = new Size(75, 23);
            _btnCancel.TabIndex = 8;
            _btnCancel.Text = "Cancel";
            _btnCancel.UseVisualStyleBackColor = true;
            // 
            // PrSearchConditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 177);
            Controls.Add(_btnCancel);
            Controls.Add(_btnOk);
            Controls.Add(_txtBoxPrStatusPreview);
            Controls.Add(_lblStatus);
            Controls.Add(_btnPrStatus);
            Controls.Add(_txtBoxReviewedBy);
            Controls.Add(_txtBoxCreatedBy);
            Controls.Add(_lblCreatedBy);
            Controls.Add(_lblReviewer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrSearchConditionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PullRequestSearchSettingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblReviewer;
        private Label _lblCreatedBy;
        private TextBox _txtBoxCreatedBy;
        private TextBox _txtBoxReviewedBy;
        private Button _btnPrStatus;
        private Label _lblStatus;
        private TextBox _txtBoxPrStatusPreview;
        private Button _btnOk;
        private Button _btnCancel;
    }
}