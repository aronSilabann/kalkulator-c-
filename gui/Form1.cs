namespace gui
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                double Angka1, Angka2, hasil;
                Angka1 = Convert.ToDouble(input1.Text);
                Angka2 = Convert.ToDouble(input2.Text);
                hasil = Angka1 + Angka2;
                outputhasil.Text = Convert.ToString(hasil);
            }
            catch (Exception ex) { }
        }

        private void hasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {
            try
            {
                double Angka1, Angka2, hasil;
                Angka1 = Convert.ToDouble(input1.Text);
                Angka2 = Convert.ToDouble(input2.Text);
                hasil = Angka1 - Angka2;
                outputhasil.Text = Convert.ToString(hasil);
            }
            catch (Exception ex) { }
        }

        private void BtnBagi_Click(object sender, EventArgs e)
        {
            try
            {
                double Angka1, Angka2, hasil;
                Angka1 = Convert.ToDouble(input1.Text);
                Angka2 = Convert.ToDouble(input2.Text);
                hasil = Angka1 / Angka2;
                outputhasil.Text = Convert.ToString(hasil);
            }
            catch (Exception ex) { }
        }

        private void BtnKali_Click(object sender, EventArgs e)
        {
            try
            {
                double Angka1, Angka2, hasil;
                Angka1 = Convert.ToDouble(input1.Text);
                Angka2 = Convert.ToDouble(input2.Text);
                hasil = Angka1 * Angka2;
                outputhasil.Text = Convert.ToString(hasil);
            }
            catch (Exception ex) { }
        }
    }
}