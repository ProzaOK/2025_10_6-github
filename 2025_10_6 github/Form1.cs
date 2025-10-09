using System.Data;

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
            string priklad = textBox1.Text;
            double vysledek;

            try
            {
                // Vyhodnocení výrazu (používáme DataTable.Compute pro jednoduché pøíklady)
                var dt = new DataTable();
                vysledek = Convert.ToDouble(dt.Compute(priklad, ""));
                MessageBox.Show("Výsledek: " + vysledek);

                // Vykreslení èíselné osy s výsledkem
                //label1.Text = VykresliCiselnouOsu(vysledek);
            }
            catch
            {
                MessageBox.Show("Neplatný pøíklad!");
                label1.Text = "";
            }
        }


    }
}
