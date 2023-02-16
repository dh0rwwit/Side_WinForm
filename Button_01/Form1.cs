using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Button_01
{
    public partial class Form1 : Form
    {
        Random RandomNumber = new Random(); // 난수생성 변수 선언

        // 데이터베이스 연결을 위한 사전 준비
        public class DBHelper
        {
            private static SqlConnection conn = null;
            public static string DBConnString { get; private set; }
        }

        public Form1()
        {
            InitializeComponent();
            this.SubmitBtn.Click += SubmitBtn_Click; // 제출 버튼 클릭
            this.SaveBtn.Click += SaveBtn_Click_1; // 저장 버튼 클릭
            this.CloseBtn.Click += CloseBtn_Click; // 닫기 버튼 클릭
        }

        // Submit 버튼 클릭
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("메세지 박스");
            // throw new NotImplementedException();
            int a = RandomNumber.Next(10000000, 99999999); // 클릭하면 1~99999999까지 값 생성
            // 각각의 textbox에 값들이 들어와 있지 않으면 값이 생성 안 되고 메세지 박스 출력         
            if (!String.IsNullOrWhiteSpace(textBox1.Text)
                && !String.IsNullOrWhiteSpace(textBox2.Text)
                && !String.IsNullOrWhiteSpace(textBox3.Text)
                && !String.IsNullOrWhiteSpace(textBox4.Text)
                && !String.IsNullOrWhiteSpace(textBox5.Text)
                )
            { OutputData.Text = a.ToString();
              OutputData.AutoSize = false;
              OutputData.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {   OutputData.TextAlign = ContentAlignment.MiddleCenter;
                OutputData.AutoSize = false;
                MessageBox.Show("누락된 값을 확인하세요.", "Error");
            }

            if (String.IsNullOrWhiteSpace(textBox1.Text)
                || String.IsNullOrWhiteSpace(textBox2.Text)
                || String.IsNullOrWhiteSpace(textBox3.Text)
                || String.IsNullOrWhiteSpace(textBox4.Text)
                || String.IsNullOrWhiteSpace(textBox5.Text)
                )
            { OutputData.Text = "데이터 출력 위치";
              OutputData.AutoSize = false;
              OutputData.TextAlign = ContentAlignment.MiddleCenter;
            }

        }

        // 저장버튼 클릭하면 textbox 초기화

        private void LblContain3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        // 저장버튼 클릭하면 textbox값 초기화
        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            OutputData.AutoSize = false;
            OutputData.TextAlign = ContentAlignment.MiddleCenter;
            OutputData.Text = "데이터 출력 위치";
        }

        // 클릭하면 WinForm 닫기
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
