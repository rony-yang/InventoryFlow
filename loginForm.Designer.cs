namespace InventoryFlow
{
    partial class loginForm
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
            this.register_button = new System.Windows.Forms.Button();
            this.login_memberPassword = new System.Windows.Forms.TextBox();
            this.login_memberNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(1386, 585);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(124, 51);
            this.register_button.TabIndex = 23;
            this.register_button.Text = "로그인";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_memberPassword
            // 
            this.login_memberPassword.Location = new System.Drawing.Point(1403, 486);
            this.login_memberPassword.Name = "login_memberPassword";
            this.login_memberPassword.PasswordChar = '*';
            this.login_memberPassword.Size = new System.Drawing.Size(200, 35);
            this.login_memberPassword.TabIndex = 16;
            this.login_memberPassword.TextChanged += new System.EventHandler(this.login_memberPassword_TextChanged);
            // 
            // login_memberNumber
            // 
            this.login_memberNumber.Location = new System.Drawing.Point(1403, 419);
            this.login_memberNumber.Name = "login_memberNumber";
            this.login_memberNumber.Size = new System.Drawing.Size(200, 35);
            this.login_memberNumber.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1269, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1269, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "사원번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1351, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 53);
            this.label3.TabIndex = 24;
            this.label3.Text = "로그인";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1518, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1269, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "회원정보가 없다면?";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2536, 1239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_memberNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_memberPassword);
            this.Controls.Add(this.label2);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox login_memberPassword;
        private System.Windows.Forms.TextBox login_memberNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}