
namespace GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabMyTickets = new System.Windows.Forms.TabPage();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabMyTickets);
            this.tabControl1.Controls.Add(this.tabTickets);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1066, 516);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabMyTickets
            // 
            this.tabMyTickets.Location = new System.Drawing.Point(4, 24);
            this.tabMyTickets.Name = "tabMyTickets";
            this.tabMyTickets.Size = new System.Drawing.Size(1066, 516);
            this.tabMyTickets.TabIndex = 2;
            this.tabMyTickets.Text = "My Tickets";
            this.tabMyTickets.UseVisualStyleBackColor = true;
            // 
            // tabTickets
            // 
            this.tabTickets.Location = new System.Drawing.Point(4, 24);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(1066, 516);
            this.tabTickets.TabIndex = 1;
            this.tabTickets.Text = "All Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(929, 18);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(80, 15);
            this.lblLoggedInAs.TabIndex = 1;
            this.lblLoggedInAs.Text = "Logged in as: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 592);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabMyTickets;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Label lblLoggedInAs;
    }
}

