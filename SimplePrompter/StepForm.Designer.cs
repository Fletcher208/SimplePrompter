namespace SimplePrompter
{
    partial class StepForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StepTitle = new System.Windows.Forms.Label();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.subStepListView = new System.Windows.Forms.ListView();
            this.expectedNextAccessDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackBtn.Location = new System.Drawing.Point(93, 522);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBtn.Location = new System.Drawing.Point(821, 524);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(712, 528);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Task Completed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StepTitle
            // 
            this.StepTitle.AutoSize = true;
            this.StepTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTitle.Location = new System.Drawing.Point(90, 40);
            this.StepTitle.Name = "StepTitle";
            this.StepTitle.Size = new System.Drawing.Size(51, 20);
            this.StepTitle.TabIndex = 0;
            this.StepTitle.Text = "label1";
            // 
            // summaryBtn
            // 
            this.summaryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryBtn.Location = new System.Drawing.Point(821, 477);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(75, 23);
            this.summaryBtn.TabIndex = 4;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(821, 37);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // subStepListView
            // 
            this.subStepListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subStepListView.HideSelection = false;
            this.subStepListView.Location = new System.Drawing.Point(94, 78);
            this.subStepListView.Name = "subStepListView";
            this.subStepListView.Size = new System.Drawing.Size(529, 314);
            this.subStepListView.TabIndex = 6;
            this.subStepListView.UseCompatibleStateImageBehavior = false;
            this.subStepListView.View = System.Windows.Forms.View.List;
            // 
            // expectedNextAccessDateTimePicker
            // 
            this.expectedNextAccessDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expectedNextAccessDateTimePicker.Location = new System.Drawing.Point(712, 112);
            this.expectedNextAccessDateTimePicker.Name = "expectedNextAccessDateTimePicker";
            this.expectedNextAccessDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expectedNextAccessDateTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "next access date";
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expectedNextAccessDateTimePicker);
            this.Controls.Add(this.subStepListView);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StepTitle);
            this.Name = "StepForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label StepTitle;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListView subStepListView;
        private System.Windows.Forms.DateTimePicker expectedNextAccessDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}