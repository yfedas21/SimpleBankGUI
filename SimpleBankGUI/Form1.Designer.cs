namespace SimpleBankGUI
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.GroupBoxAddCustomer = new System.Windows.Forms.GroupBox();
            this.GroupBoxAddAccount = new System.Windows.Forms.GroupBox();
            this.TabControlAddView = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TabControlAddView.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "SimpleBank";
            // 
            // GroupBoxAddCustomer
            // 
            this.GroupBoxAddCustomer.Location = new System.Drawing.Point(18, 27);
            this.GroupBoxAddCustomer.Name = "GroupBoxAddCustomer";
            this.GroupBoxAddCustomer.Size = new System.Drawing.Size(221, 311);
            this.GroupBoxAddCustomer.TabIndex = 1;
            this.GroupBoxAddCustomer.TabStop = false;
            this.GroupBoxAddCustomer.Text = "Add Customer";
            // 
            // GroupBoxAddAccount
            // 
            this.GroupBoxAddAccount.Location = new System.Drawing.Point(289, 27);
            this.GroupBoxAddAccount.Name = "GroupBoxAddAccount";
            this.GroupBoxAddAccount.Size = new System.Drawing.Size(229, 311);
            this.GroupBoxAddAccount.TabIndex = 2;
            this.GroupBoxAddAccount.TabStop = false;
            this.GroupBoxAddAccount.Text = "Add Account";
            // 
            // TabControlAddView
            // 
            this.TabControlAddView.Controls.Add(this.tabPage3);
            this.TabControlAddView.Controls.Add(this.tabPage4);
            this.TabControlAddView.Location = new System.Drawing.Point(27, 62);
            this.TabControlAddView.Name = "TabControlAddView";
            this.TabControlAddView.SelectedIndex = 0;
            this.TabControlAddView.Size = new System.Drawing.Size(665, 443);
            this.TabControlAddView.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GroupBoxAddCustomer);
            this.tabPage3.Controls.Add(this.GroupBoxAddAccount);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(657, 417);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(537, 395);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "View";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(648, 525);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 560);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TabControlAddView);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Simple Bank";
            this.TabControlAddView.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox GroupBoxAddCustomer;
        private System.Windows.Forms.GroupBox GroupBoxAddAccount;
        private System.Windows.Forms.TabControl TabControlAddView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ButtonExit;
    }
}

