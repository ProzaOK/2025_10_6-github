namespace _2025_10_6_github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCalculator calculator = new MyCalculator();
            double vysledek = calculator.Vypocet(textBox1.Text);
            MessageBox.Show("Výsledek: " + vysledek);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
           
    }
}
      
   

