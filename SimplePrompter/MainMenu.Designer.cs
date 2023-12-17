namespace SimplePrompter
{
    partial class MainMenu
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
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.StartPrompterBtn = new System.Windows.Forms.Button();
            this.Directorylbl = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileListBox
            // 
            this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(31, 40);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(242, 342);
            this.fileListBox.TabIndex = 0;
            // 
            // StartPrompterBtn
            // 
            this.StartPrompterBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartPrompterBtn.Location = new System.Drawing.Point(313, 343);
            this.StartPrompterBtn.Name = "StartPrompterBtn";
            this.StartPrompterBtn.Size = new System.Drawing.Size(128, 39);
            this.StartPrompterBtn.TabIndex = 1;
            this.StartPrompterBtn.Text = "Go";
            this.StartPrompterBtn.UseVisualStyleBackColor = true;
            this.StartPrompterBtn.Click += new System.EventHandler(this.StartPrompterBtn_Click);
            // 
            // Directorylbl
            // 
            this.Directorylbl.AutoSize = true;
            this.Directorylbl.Location = new System.Drawing.Point(31, 13);
            this.Directorylbl.Name = "Directorylbl";
            this.Directorylbl.Size = new System.Drawing.Size(35, 13);
            this.Directorylbl.TabIndex = 2;
            this.Directorylbl.Text = "label1";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(514, 343);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(109, 39);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Location = new System.Drawing.Point(674, 343);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(101, 39);
            this.calendarBtn.TabIndex = 4;
            this.calendarBtn.Text = "Calendar";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendarBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.Directorylbl);
            this.Controls.Add(this.StartPrompterBtn);
            this.Controls.Add(this.fileListBox);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button StartPrompterBtn;
        private System.Windows.Forms.Label Directorylbl;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button calendarBtn;
    }
}

