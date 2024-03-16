
namespace AzureDevOpsTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _btnExecute = new Button();
            _richTextBoxResult = new RichTextBox();
            SuspendLayout();
            // 
            // _btnExecute
            // 
            _btnExecute.Location = new Point(12, 12);
            _btnExecute.Name = "_btnExecute";
            _btnExecute.Size = new Size(75, 23);
            _btnExecute.TabIndex = 0;
            _btnExecute.Text = "Execute";
            _btnExecute.UseVisualStyleBackColor = true;
            _btnExecute.Click += this._btnExecute_Click;
            // 
            // _richTextBoxResult
            // 
            _richTextBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _richTextBoxResult.Location = new Point(12, 41);
            _richTextBoxResult.Name = "_richTextBoxResult";
            _richTextBoxResult.Size = new Size(404, 146);
            _richTextBoxResult.TabIndex = 1;
            _richTextBoxResult.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 199);
            Controls.Add(_richTextBoxResult);
            Controls.Add(_btnExecute);
            Name = "MainForm";
            Text = "AzureDevOpsTool";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button _btnExecute;
        private RichTextBox _richTextBoxResult;
    }
}
