namespace Button_01
{
    partial class Form1
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
            this.Box_1 = new System.Windows.Forms.CheckBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.LblContain = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblContain2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblContain3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblContain4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LblContain5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OutputData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_1
            // 
            this.Box_1.AutoSize = true;
            this.Box_1.Location = new System.Drawing.Point(274, 285);
            this.Box_1.Name = "Box_1";
            this.Box_1.Size = new System.Drawing.Size(72, 16);
            this.Box_1.TabIndex = 4;
            this.Box_1.Tag = "CheckSensor";
            this.Box_1.Text = "체크박스";
            this.Box_1.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitBtn.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(22, 346);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(101, 36);
            this.SubmitBtn.TabIndex = 5;
            this.SubmitBtn.Text = "제출";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            // 
            // LblContain
            // 
            this.LblContain.AutoSize = true;
            this.LblContain.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblContain.Location = new System.Drawing.Point(21, 111);
            this.LblContain.Name = "LblContain";
            this.LblContain.Size = new System.Drawing.Size(70, 16);
            this.LblContain.TabIndex = 6;
            this.LblContain.Text = "입력값 A";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // LblContain2
            // 
            this.LblContain2.AutoSize = true;
            this.LblContain2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblContain2.Location = new System.Drawing.Point(22, 152);
            this.LblContain2.Name = "LblContain2";
            this.LblContain2.Size = new System.Drawing.Size(70, 16);
            this.LblContain2.TabIndex = 8;
            this.LblContain2.Text = "입력값 B";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 11;
            // 
            // LblContain3
            // 
            this.LblContain3.AutoSize = true;
            this.LblContain3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblContain3.Location = new System.Drawing.Point(21, 192);
            this.LblContain3.Name = "LblContain3";
            this.LblContain3.Size = new System.Drawing.Size(71, 16);
            this.LblContain3.TabIndex = 10;
            this.LblContain3.Text = "입력값 C";
            this.LblContain3.Click += new System.EventHandler(this.LblContain3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 13;
            // 
            // LblContain4
            // 
            this.LblContain4.AutoSize = true;
            this.LblContain4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblContain4.Location = new System.Drawing.Point(22, 234);
            this.LblContain4.Name = "LblContain4";
            this.LblContain4.Size = new System.Drawing.Size(70, 16);
            this.LblContain4.TabIndex = 12;
            this.LblContain4.Text = "입력값 D";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(104, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 15;
            // 
            // LblContain5
            // 
            this.LblContain5.AutoSize = true;
            this.LblContain5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblContain5.Location = new System.Drawing.Point(22, 280);
            this.LblContain5.Name = "LblContain5";
            this.LblContain5.Size = new System.Drawing.Size(70, 16);
            this.LblContain5.TabIndex = 14;
            this.LblContain5.Text = "입력값 E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(257, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "출력값";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.MintCream;
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(134, 346);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 36);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(243, 346);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(101, 36);
            this.CloseBtn.TabIndex = 19;
            this.CloseBtn.Text = "닫기";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OutputData
            // 
            this.OutputData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutputData.AutoSize = true;
            this.OutputData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutputData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OutputData.Location = new System.Drawing.Point(12, 5);
            this.OutputData.Name = "OutputData";
            this.OutputData.Size = new System.Drawing.Size(97, 12);
            this.OutputData.TabIndex = 20;
            this.OutputData.Text = "데이터 출력 위치";
            this.OutputData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutputData.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(228, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 11);
            this.label2.TabIndex = 21;
            this.label2.Text = "레이아웃 : 정송화 선임";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(250, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 11);
            this.label3.TabIndex = 22;
            this.label3.Text = "개발 : 김동휘 주임";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(48, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "RPA 기능 테스트 프로그램";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.OutputData);
            this.panel1.Location = new System.Drawing.Point(227, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 21);
            this.panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.LblContain5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LblContain4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblContain3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblContain2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblContain);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Box_1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "RPA 기능 테스트 프로그램";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Box_1;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label LblContain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblContain2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblContain3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblContain4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label LblContain5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label OutputData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

