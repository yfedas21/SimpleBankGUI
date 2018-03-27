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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxAddAccount = new System.Windows.Forms.GroupBox();
            this.TabControlAddView = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.GroupBoxAddCustomer.SuspendLayout();
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
            this.lblWelcome.Location = new System.Drawing.Point(29, 26);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(149, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "SimpleBank";
            // 
            // GroupBoxAddCustomer
            // 
            this.GroupBoxAddCustomer.Controls.Add(this.buttonSubmit);
            this.GroupBoxAddCustomer.Controls.Add(this.buttonClear);
            this.GroupBoxAddCustomer.Controls.Add(this.textBoxTelephoneNumber);
            this.GroupBoxAddCustomer.Controls.Add(this.textBoxAge);
            this.GroupBoxAddCustomer.Controls.Add(this.textBoxAddress);
            this.GroupBoxAddCustomer.Controls.Add(this.textBoxName);
            this.GroupBoxAddCustomer.Controls.Add(this.label4);
            this.GroupBoxAddCustomer.Controls.Add(this.label3);
            this.GroupBoxAddCustomer.Controls.Add(this.label2);
            this.GroupBoxAddCustomer.Controls.Add(this.label1);
            this.GroupBoxAddCustomer.Location = new System.Drawing.Point(24, 33);
            this.GroupBoxAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxAddCustomer.Name = "GroupBoxAddCustomer";
            this.GroupBoxAddCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxAddCustomer.Size = new System.Drawing.Size(340, 383);
            this.GroupBoxAddCustomer.TabIndex = 1;
            this.GroupBoxAddCustomer.TabStop = false;
            this.GroupBoxAddCustomer.Text = "Add Customer";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(243, 258);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 26);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(162, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 26);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(23, 213);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(295, 22);
            this.textBoxTelephoneNumber.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(23, 159);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(295, 22);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(23, 107);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(295, 22);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(23, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(295, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // GroupBoxAddAccount
            // 
            this.GroupBoxAddAccount.Location = new System.Drawing.Point(495, 33);
            this.GroupBoxAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxAddAccount.Name = "GroupBoxAddAccount";
            this.GroupBoxAddAccount.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxAddAccount.Size = new System.Drawing.Size(305, 383);
            this.GroupBoxAddAccount.TabIndex = 2;
            this.GroupBoxAddAccount.TabStop = false;
            this.GroupBoxAddAccount.Text = "Add Account";
            // 
            // TabControlAddView
            // 
            this.TabControlAddView.Controls.Add(this.tabPage3);
            this.TabControlAddView.Controls.Add(this.tabPage4);
            this.TabControlAddView.Location = new System.Drawing.Point(36, 76);
            this.TabControlAddView.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlAddView.Name = "TabControlAddView";
            this.TabControlAddView.SelectedIndex = 0;
            this.TabControlAddView.Size = new System.Drawing.Size(887, 545);
            this.TabControlAddView.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GroupBoxAddCustomer);
            this.tabPage3.Controls.Add(this.GroupBoxAddAccount);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(879, 516);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(879, 516);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "View";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(864, 646);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(100, 28);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 689);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TabControlAddView);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Simple Bank";
            this.GroupBoxAddCustomer.ResumeLayout(false);
            this.GroupBoxAddCustomer.PerformLayout();
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
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

