namespace Modin.SecondaryForms.MedicineInPharmacies
{
    public partial class Change : Form
    {
        public Action<int, Model.MedicineInPharmacy> OnChange;

        private int _index;

        public Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int pharmacyId) && int.TryParse(textBox2.Text, out int medicineId)
                && int.TryParse(textBox3.Text, out int price) && int.TryParse(textBox4.Text, out int amount))
            {
                var medicine = new Model.MedicineInPharmacy()
                {
                    PharmacyId = pharmacyId,
                    MedicineId = medicineId,
                    Price = price,
                    Amount = amount,
                    Date = textBox5.Text
                };

                OnChange.Invoke(_index, medicine);
            }
        }

        public void Set(DataGridViewRow row)
        {
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
            _index = row.Index;
        }
    }
}
