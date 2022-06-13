namespace Modin.SecondaryForms.MedicineInPharmacies
{
    public partial class Add : Form
    {
        public Action<Model.MedicineInPharmacy> OnMedicineInPharmacyAdd;

        public Add()
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

                OnMedicineInPharmacyAdd.Invoke(medicine);
            }
        }
    }
}
