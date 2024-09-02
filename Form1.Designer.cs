namespace readport_winform_csharp
{
    partial class Form1
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
            btnFind = new Button();
            portList = new ListBox();
            label1 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(47, 63);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 27);
            btnFind.TabIndex = 0;
            btnFind.Text = "Find ports";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // portList
            // 
            portList.FormattingEnabled = true;
            portList.ItemHeight = 15;
            portList.Location = new Point(128, 90);
            portList.Name = "portList";
            portList.Size = new Size(223, 94);
            portList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 67);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(180, 67);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(18, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "--";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 210);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(portList);
            Controls.Add(btnFind);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFind;
        private ListBox portList;
        private Label label1;
        private Label lblStatus;
    }
}
