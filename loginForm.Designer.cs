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
            this.label7 = new System.Windows.Forms.Label();
            this.login_memberPassword = new System.Windows.Forms.TextBox();
            this.login_memberNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(1360, 575);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(124, 51);
            this.register_button.TabIndex = 23;
            this.register_button.Text = "로그인";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(1328, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 53);
            this.label7.TabIndex = 26;
            this.label7.Text = "로그인";
            // 
            // login_memberPassword
            // 
            this.login_memberPassword.Location = new System.Drawing.Point(1403, 486);
            this.login_memberPassword.Name = "login_memberPassword";
            this.login_memberPassword.Size = new System.Drawing.Size(200, 35);
            this.login_memberPassword.TabIndex = 16;
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
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2023, 1091);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.login_memberPassword);
            this.Controls.Add(this.login_memberNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox login_memberPassword;
        private System.Windows.Forms.TextBox login_memberNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}