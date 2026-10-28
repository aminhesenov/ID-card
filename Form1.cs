namespace Idcard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox13.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label19.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label18.Text = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textBox3.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label12.Text = textBox8.Text;
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox7.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox5.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            label17.Text = textBox13.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label15.Text = textBox11.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label16.Text = textBox10.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox8.Text) ||
                string.IsNullOrEmpty(textBox10.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text))
            {
                progressBar1.Visible = true;
                MessageBox.Show("Xanalar tam doldurulmayıb", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                progressBar1.Visible = true;
                MessageBox.Show("Verilənlər yadda saxlandı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Əməliyyat tamamlandı", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op=new OpenFileDialog();
            op.Filter = "Ancaq jpg format *.jpg | *jpg";
            op.ShowDialog();
            pictureBox1.ImageLocation= op.FileName;
        }
    }
}
