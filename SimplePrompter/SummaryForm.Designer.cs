using System.Windows.Forms;

namespace SimplePrompter
{
    partial class SummaryForm
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
            this.summaryListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Checked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // summaryListView
            // 
            this.summaryListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Checked});
            this.summaryListView.HideSelection = false;
            this.summaryListView.Location = new System.Drawing.Point(12, 12);
            this.summaryListView.Name = "summaryListView";
            this.summaryListView.Size = new System.Drawing.Size(776, 426);
            this.summaryListView.TabIndex = 0;
            this.summaryListView.UseCompatibleStateImageBehavior = false;
            this.summaryListView.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 107;
            // 
            // Checked
            // 
            this.Checked.Text = "Checked";
            this.Checked.Width = 94;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryListView);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView summaryListView;
        private ColumnHeader Title;
        private ColumnHeader Checked;
    }
}