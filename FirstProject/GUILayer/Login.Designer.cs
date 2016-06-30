namespace GUILayer
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
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.NLTab = new System.Windows.Forms.TabPage();
            this.LTab = new System.Windows.Forms.TabPage();
            this.NLUNText = new System.Windows.Forms.TextBox();
            this.NLPWText = new System.Windows.Forms.TextBox();
            this.NLLoginBtn = new System.Windows.Forms.Button();
            this.NLRegisterBtn = new System.Windows.Forms.Button();
            this.RTab = new System.Windows.Forms.TabPage();
            this.NLUNLabel = new System.Windows.Forms.Label();
            this.NLPWLabel = new System.Windows.Forms.Label();
            this.LLogoutBtn = new System.Windows.Forms.Button();
            this.LQuitBtn = new System.Windows.Forms.Button();
            this.RPWLabel = new System.Windows.Forms.Label();
            this.RUNLabel = new System.Windows.Forms.Label();
            this.RRegisterBtn = new System.Windows.Forms.Button();
            this.RPWText = new System.Windows.Forms.TextBox();
            this.RUNText = new System.Windows.Forms.TextBox();
            this.RELabel = new System.Windows.Forms.Label();
            this.REText = new System.Windows.Forms.TextBox();
            this.LoginTabControl.SuspendLayout();
            this.NLTab.SuspendLayout();
            this.LTab.SuspendLayout();
            this.RTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTabControl
            // 
            this.LoginTabControl.Controls.Add(this.NLTab);
            this.LoginTabControl.Controls.Add(this.LTab);
            this.LoginTabControl.Controls.Add(this.RTab);
            this.LoginTabControl.Location = new System.Drawing.Point(2, -1);
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(282, 264);
            this.LoginTabControl.TabIndex = 0;
            // 
            // NLTab
            // 
            this.NLTab.Controls.Add(this.NLPWLabel);
            this.NLTab.Controls.Add(this.NLUNLabel);
            this.NLTab.Controls.Add(this.NLRegisterBtn);
            this.NLTab.Controls.Add(this.NLLoginBtn);
            this.NLTab.Controls.Add(this.NLPWText);
            this.NLTab.Controls.Add(this.NLUNText);
            this.NLTab.Location = new System.Drawing.Point(4, 22);
            this.NLTab.Name = "NLTab";
            this.NLTab.Padding = new System.Windows.Forms.Padding(3);
            this.NLTab.Size = new System.Drawing.Size(274, 238);
            this.NLTab.TabIndex = 0;
            this.NLTab.Text = "NLTab";
            this.NLTab.UseVisualStyleBackColor = true;
            // 
            // LTab
            // 
            this.LTab.Controls.Add(this.LQuitBtn);
            this.LTab.Controls.Add(this.LLogoutBtn);
            this.LTab.Location = new System.Drawing.Point(4, 22);
            this.LTab.Name = "LTab";
            this.LTab.Padding = new System.Windows.Forms.Padding(3);
            this.LTab.Size = new System.Drawing.Size(274, 238);
            this.LTab.TabIndex = 1;
            this.LTab.Text = "LTab";
            this.LTab.UseVisualStyleBackColor = true;
            // 
            // NLUNText
            // 
            this.NLUNText.Location = new System.Drawing.Point(82, 58);
            this.NLUNText.Name = "NLUNText";
            this.NLUNText.Size = new System.Drawing.Size(100, 20);
            this.NLUNText.TabIndex = 0;
            // 
            // NLPWText
            // 
            this.NLPWText.Location = new System.Drawing.Point(82, 112);
            this.NLPWText.Name = "NLPWText";
            this.NLPWText.PasswordChar = '*';
            this.NLPWText.Size = new System.Drawing.Size(100, 20);
            this.NLPWText.TabIndex = 1;
            this.NLPWText.UseSystemPasswordChar = true;
            // 
            // NLLoginBtn
            // 
            this.NLLoginBtn.Location = new System.Drawing.Point(55, 148);
            this.NLLoginBtn.Name = "NLLoginBtn";
            this.NLLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.NLLoginBtn.TabIndex = 2;
            this.NLLoginBtn.Text = "Login";
            this.NLLoginBtn.UseVisualStyleBackColor = true;
            // 
            // NLRegisterBtn
            // 
            this.NLRegisterBtn.Location = new System.Drawing.Point(149, 148);
            this.NLRegisterBtn.Name = "NLRegisterBtn";
            this.NLRegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.NLRegisterBtn.TabIndex = 3;
            this.NLRegisterBtn.Text = "Register";
            this.NLRegisterBtn.UseVisualStyleBackColor = true;
            // 
            // RTab
            // 
            this.RTab.Controls.Add(this.RELabel);
            this.RTab.Controls.Add(this.REText);
            this.RTab.Controls.Add(this.RPWLabel);
            this.RTab.Controls.Add(this.RUNLabel);
            this.RTab.Controls.Add(this.RRegisterBtn);
            this.RTab.Controls.Add(this.RPWText);
            this.RTab.Controls.Add(this.RUNText);
            this.RTab.Location = new System.Drawing.Point(4, 22);
            this.RTab.Name = "RTab";
            this.RTab.Padding = new System.Windows.Forms.Padding(3);
            this.RTab.Size = new System.Drawing.Size(274, 238);
            this.RTab.TabIndex = 2;
            this.RTab.Text = "RTab";
            this.RTab.UseVisualStyleBackColor = true;
            // 
            // NLUNLabel
            // 
            this.NLUNLabel.AutoSize = true;
            this.NLUNLabel.Location = new System.Drawing.Point(103, 42);
            this.NLUNLabel.Name = "NLUNLabel";
            this.NLUNLabel.Size = new System.Drawing.Size(55, 13);
            this.NLUNLabel.TabIndex = 4;
            this.NLUNLabel.Text = "Username";
            // 
            // NLPWLabel
            // 
            this.NLPWLabel.AutoSize = true;
            this.NLPWLabel.Location = new System.Drawing.Point(103, 96);
            this.NLPWLabel.Name = "NLPWLabel";
            this.NLPWLabel.Size = new System.Drawing.Size(53, 13);
            this.NLPWLabel.TabIndex = 5;
            this.NLPWLabel.Text = "Password";
            // 
            // LLogoutBtn
            // 
            this.LLogoutBtn.Location = new System.Drawing.Point(87, 68);
            this.LLogoutBtn.Name = "LLogoutBtn";
            this.LLogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LLogoutBtn.TabIndex = 0;
            this.LLogoutBtn.Text = "Logout";
            this.LLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // LQuitBtn
            // 
            this.LQuitBtn.Location = new System.Drawing.Point(87, 122);
            this.LQuitBtn.Name = "LQuitBtn";
            this.LQuitBtn.Size = new System.Drawing.Size(75, 23);
            this.LQuitBtn.TabIndex = 1;
            this.LQuitBtn.Text = "Quit";
            this.LQuitBtn.UseVisualStyleBackColor = true;
            // 
            // RPWLabel
            // 
            this.RPWLabel.AutoSize = true;
            this.RPWLabel.Location = new System.Drawing.Point(108, 123);
            this.RPWLabel.Name = "RPWLabel";
            this.RPWLabel.Size = new System.Drawing.Size(53, 13);
            this.RPWLabel.TabIndex = 10;
            this.RPWLabel.Text = "Password";
            // 
            // RUNLabel
            // 
            this.RUNLabel.AutoSize = true;
            this.RUNLabel.Location = new System.Drawing.Point(110, 16);
            this.RUNLabel.Name = "RUNLabel";
            this.RUNLabel.Size = new System.Drawing.Size(55, 13);
            this.RUNLabel.TabIndex = 9;
            this.RUNLabel.Text = "Username";
            // 
            // RRegisterBtn
            // 
            this.RRegisterBtn.Location = new System.Drawing.Point(101, 180);
            this.RRegisterBtn.Name = "RRegisterBtn";
            this.RRegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RRegisterBtn.TabIndex = 8;
            this.RRegisterBtn.Text = "Register";
            this.RRegisterBtn.UseVisualStyleBackColor = true;
            // 
            // RPWText
            // 
            this.RPWText.Location = new System.Drawing.Point(87, 139);
            this.RPWText.Name = "RPWText";
            this.RPWText.PasswordChar = '*';
            this.RPWText.Size = new System.Drawing.Size(100, 20);
            this.RPWText.TabIndex = 7;
            this.RPWText.UseSystemPasswordChar = true;
            // 
            // RUNText
            // 
            this.RUNText.Location = new System.Drawing.Point(89, 32);
            this.RUNText.Name = "RUNText";
            this.RUNText.Size = new System.Drawing.Size(100, 20);
            this.RUNText.TabIndex = 6;
            // 
            // RELabel
            // 
            this.RELabel.AutoSize = true;
            this.RELabel.Location = new System.Drawing.Point(120, 69);
            this.RELabel.Name = "RELabel";
            this.RELabel.Size = new System.Drawing.Size(32, 13);
            this.RELabel.TabIndex = 12;
            this.RELabel.Text = "Email";
            // 
            // REText
            // 
            this.REText.Location = new System.Drawing.Point(87, 85);
            this.REText.Name = "REText";
            this.REText.Size = new System.Drawing.Size(100, 20);
            this.REText.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoginTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginTabControl.ResumeLayout(false);
            this.NLTab.ResumeLayout(false);
            this.NLTab.PerformLayout();
            this.LTab.ResumeLayout(false);
            this.RTab.ResumeLayout(false);
            this.RTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage NLTab;
        private System.Windows.Forms.TabPage LTab;
        private System.Windows.Forms.Button NLRegisterBtn;
        private System.Windows.Forms.Button NLLoginBtn;
        private System.Windows.Forms.TextBox NLPWText;
        private System.Windows.Forms.TextBox NLUNText;
        private System.Windows.Forms.Label NLUNLabel;
        private System.Windows.Forms.TabPage RTab;
        private System.Windows.Forms.Label NLPWLabel;
        private System.Windows.Forms.Button LLogoutBtn;
        private System.Windows.Forms.Button LQuitBtn;
        private System.Windows.Forms.Label RELabel;
        private System.Windows.Forms.TextBox REText;
        private System.Windows.Forms.Label RPWLabel;
        private System.Windows.Forms.Label RUNLabel;
        private System.Windows.Forms.Button RRegisterBtn;
        private System.Windows.Forms.TextBox RPWText;
        private System.Windows.Forms.TextBox RUNText;
    }
}

