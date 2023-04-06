namespace Objedinjeni_checkbox_radio_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtSiva.Checked = true;
            this.BackColor = Color.Gray;

            for (int i = 0; i < 20; i++)
            {
                textBox1.Text += i + ", ";
            }
            textBox1.Text += "20";
        }

        private void rbtZelena_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZelena.Checked) this.BackColor = Color.Green;
        }

        private void rbtPlava_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPlava.Checked) this.BackColor = Color.Blue;
        }

        private void rbtZuta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZuta.Checked) this.BackColor = Color.Yellow;
        }

        private void rbtCrvena_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCrvena.Checked) this.BackColor = Color.Red;
        }

        private void rbtSiva_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSiva.Checked) this.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = 1;
            if (chbDeljiviSaDva.Checked) d *= 2;
            if (chbDeljiviSaTri.Checked) d *= 3;
            if (chbDeljiviSaPet.Checked) d *= 5;
            if (chbDeljiviSaSedam.Checked) d *= 7;

            textBox1.Text = "";
            for (int i = 1; i <= 20; i++)
            {
                if (i % d == 0)
                    textBox1.Text += i + ", ";
            }
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 2);
        }
    }
}