namespace EceYalcin_HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optCase = false;
        double Result = 0;
        string Opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void NumberEvent(object sender, EventArgs e)
        {
            if(txtResult.Text=="0" || optCase)
                txtResult.Clear();

            optCase = false;
            Button btn = (Button)sender;
            txtResult.Text+=btn.Text;

        }

        private void Operators(object sender, EventArgs e)
        {
            optCase = true;
            Button btn = (Button)sender;
            string newOpt = btn.Text;

            labelResult.Text = labelResult.Text + " " + txtResult.Text + " " + newOpt;
            switch (Opt)
            {
                case "+": txtResult.Text = (Result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (Result - Double.Parse(txtResult.Text)).ToString(); break;
                case "x": txtResult.Text = (Result * Double.Parse(txtResult.Text)).ToString(); break;
                case "÷": txtResult.Text = (Result / Double.Parse(txtResult.Text)).ToString(); break;
            }
            Result = double.Parse(txtResult.Text);
            Opt = newOpt;
            txtResult.Text = Result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            labelResult.Text = "";
            Opt = "";
            Result = 0;
            optCase = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            optCase = true;
            switch (Opt)
            {
                case "+": txtResult.Text = (Result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (Result - Double.Parse(txtResult.Text)).ToString(); break;
                case "x": txtResult.Text = (Result * Double.Parse(txtResult.Text)).ToString(); break;
                case "÷": txtResult.Text = (Result / Double.Parse(txtResult.Text)).ToString(); break;
            }
            Result = double.Parse(txtResult.Text);
            Opt = "";
            txtResult.Text = Result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else if (optCase)
            {
                txtResult.Text = "0";
            }
            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            optCase = false;
        }
    }
}