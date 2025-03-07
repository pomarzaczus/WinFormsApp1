using kalulator;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        calculator kalk = new calculator();
        int firstnumber = 0, seconnumber = 0;
        int dzialanie = 0;
        private void button_8_Click(object sender, EventArgs e)
        {

            if (dzialanie == 0) {
                firstnumber = firstnumber * 10 + 8;
                textBox1.AppendText(8.ToString());
            }
            else {
                seconnumber = seconnumber * 10 + 8;
                textBox1.AppendText(8.ToString());
            }
            

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 1;
                textBox1.AppendText(1.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 1;
                textBox1.AppendText(1.ToString());
                
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                dzialanie = 1;
                textBox1.AppendText("+");
            }
         
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                dzialanie = 2;
                textBox1.AppendText("-");
            }
 
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                dzialanie = 3;
                textBox1.AppendText("*");
            }
  
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 3;
                textBox1.AppendText(3.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 3;
                textBox1.AppendText(3.ToString());

            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 6;
                textBox1.AppendText(6.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 6;
                textBox1.AppendText(6.ToString());

            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 5;
                textBox1.AppendText(5.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 5;
                textBox1.AppendText(5.ToString());

            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 2;
                textBox1.AppendText(2.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 2;
                textBox1.AppendText(2.ToString());

            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 0;
                textBox1.AppendText(0.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 0;
                textBox1.AppendText(0.ToString());

            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                dzialanie = 4;
                textBox1.AppendText("/");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case 1:
                   kalk.
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:

                    break;

            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 7;
                textBox1.AppendText(7.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 7;
                textBox1.AppendText(7.ToString());

            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 9;
                textBox1.AppendText(9.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 9;
                textBox1.AppendText(9.ToString());

            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (dzialanie == 0)
            {
                firstnumber = firstnumber * 10 + 4;
                textBox1.AppendText(4.ToString());
            }
            else
            {
                seconnumber = seconnumber * 10 + 4;
                textBox1.AppendText(4.ToString());

            }
        }
    }
}
