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
                // Vyhodnocen� v�razu (pou��v�me DataTable.Compute pro jednoduch� p��klady)
                var dt = new DataTable();
                vysledek = Convert.ToDouble(dt.Compute(priklad, ""));
                MessageBox.Show("V�sledek: " + vysledek);

                // Vykreslen� ��seln� osy s v�sledkem
                //label1.Text = VykresliCiselnouOsu(vysledek);
            }
            catch
            {
                MessageBox.Show("Neplatn� p��klad!");
                label1.Text = "";
            }
        }


    }
}
