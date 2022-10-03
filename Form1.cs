namespace BaiThucHanhChuong1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

      
        //Delete button khả dụng khi có text trong 2 ô đăng nhập và mật khẩu
        private void checkDelete()
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        //Delete đăng nhập
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkDelete();
        }
        //Delete mật khẩu
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkDelete();
        }

        //Thoát chương trình khi có dấu check trong checkbox ask
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {

                if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
            
          
        }
        //Delete bằng click 
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
        //GÕ
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
            }
            else
            {
                //Thong tin = True
                if (textBox1.Text == "ngonguyenhuyanh" && textBox2.Text == "111200022")
                {

                    if (checkBox1.CheckState == CheckState.Unchecked)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    //Chon trang thai hien thi 
                    string selectedStatus, selectedLanguage;
                    if (radioButton1.Checked)
                    {
                        selectedStatus = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        selectedStatus = radioButton2.Text;
                    }
                    else 
                    {
                        selectedStatus = radioButton3.Text;
                    };

                    //Chon ngon ngu hien thi
                    if (radioButton4.Checked)
                    {
                        selectedLanguage = radioButton4.Text;
                    }
                    else if (radioButton5.Checked)
                    {
                        selectedLanguage = radioButton5.Text;
                    }
                    else 
                    {
                        selectedLanguage = radioButton6.Text;
                    };

                    MessageBox.Show("Đăng nhập thành công!" + Environment.NewLine + "Trạng thái đăng nhập đã chọn: " +selectedStatus+Environment.NewLine+"Ngôn ngữ đã chọn: "+selectedLanguage,"Thông báo");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                }





            }
        }
        //Enter đăng nhập khi nhập xong text
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
        }
        //
         

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                button1_Click(sender, e);
            }
        }

        //Checked de save thong tin dang nhap

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Da luu thong tin dang nhap!" + checkBox1.CheckState, "Thông báo");
            }
            else
            {
                MessageBox.Show("Chua luu thong tin dang nhap!" + checkBox1.CheckState, "Thong bao!");
            }
            
        }
        //Enter de xuong dong go mat khau
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.SelectAll();
                textBox2.Focus();
            }
        }
    }

}