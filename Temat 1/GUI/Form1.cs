using Temat1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtItems.Text);
                int seed = int.Parse(txtSeed.Text);
                int capacity = int.Parse(txtCapacity.Text);

                Problem problem = new(n, seed);
                Result result = problem.Solve(capacity);

                txtResult1.Items.Clear();
                txtResult2.Items.Clear();

                txtResult2.Items.Add("Ilość przedmiotów: " + problem.IloscPrzedmiotow);

                foreach (var item in problem.Przedmioty)
                {
                    txtResult2.Items.Add(item.ToString());
                }

                txtResult1.Items.Add("Przedmioty w plecaku:");

                foreach (var id in result.Przedmioty)
                {
                    txtResult1.Items.Add("Item " + id);
                }

                txtResult1.Items.Add("");
                txtResult1.Items.Add("Wartość całkowita: " + result.TotalWartosc);
                txtResult1.Items.Add("Waga całkowita: " + result.TotalWaga);
            }
            catch
            {
                MessageBox.Show("Podano niepoprawne dane!");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
