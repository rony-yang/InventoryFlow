namespace InventoryFlow
{
    partial class registerForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_memberNumber = new System.Windows.Forms.TextBox();
            this.box_memberPassword = new System.Windows.Forms.TextBox();
            this.box_memberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_department = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_phoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1273, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원번호";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1273, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // box_memberNumber
            // 
            this.box_memberNumber.Location = new System.Drawing.Point(1407, 417);
            this.box_memberNumber.Name = "box_memberNumber";
            this.box_memberNumber.Size = new System.Drawing.Size(200, 35);
            this.box_memberNumber.TabIndex = 2;
            this.box_memberNumber.TextChanged += new System.EventHandler(this.box_memberNumber_TextChanged);
            // 
            // box_memberPassword
            // 
            this.box_memberPassword.Location = new System.Drawing.Point(1407, 484);
            this.box_memberPassword.Name = "box_memberPassword";
            this.box_memberPassword.Size = new System.Drawing.Size(200, 35);
            this.box_memberPassword.TabIndex = 3;
            this.box_memberPassword.TextChanged += new System.EventHandler(this.box_memberPassword_TextChanged);
            // 
            // box_memberName
            // 
            this.box_memberName.Location = new System.Drawing.Point(1407, 553);
            this.box_memberName.Name = "box_memberName";
            this.box_memberName.Size = new System.Drawing.Size(200, 35);
            this.box_memberName.TabIndex = 4;
            this.box_memberName.TextChanged += new System.EventHandler(this.box_memberName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1273, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // box_department
            // 
            this.box_department.Location = new System.Drawing.Point(1407, 691);
            this.box_department.Name = "box_department";
            this.box_department.Size = new System.Drawing.Size(200, 35);
            this.box_department.TabIndex = 6;
            this.box_department.TextChanged += new System.EventHandler(this.box_department_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1273, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "전화번호";
            // 
            // box_phoneNumber
            // 
            this.box_phoneNumber.Location = new System.Drawing.Point(1407, 626);
            this.box_phoneNumber.Name = "box_phoneNumber";
            this.box_phoneNumber.Size = new System.Drawing.Size(200, 35);
            this.box_phoneNumber.TabIndex = 5;
            this.box_phoneNumber.TextChanged += new System.EventHandler(this.box_phoneNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1273, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "부서";
            // 
            // box_position
            // 
            this.box_position.Location = new System.Drawing.Point(1407, 753);
            this.box_position.Name = "box_position";
            this.box_position.Size = new System.Drawing.Size(200, 35);
            this.box_position.TabIndex = 7;
            this.box_position.TextChanged += new System.EventHandler(this.box_position_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1273, 753);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "직책";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(1328, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 53);
            this.label7.TabIndex = 12;
            this.label7.Text = "회원가입";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(1376, 834);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(124, 51);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "회원가입";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1575, 922);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1273, 935);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "이미 회원가입을 했다면?";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2522, 1176);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_position);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_phoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_memberName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_memberPassword);
            this.Controls.Add(this.box_memberNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registerForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_memberNumber;
        private System.Windows.Forms.TextBox box_memberPassword;
        private System.Windows.Forms.TextBox box_memberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_department;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

