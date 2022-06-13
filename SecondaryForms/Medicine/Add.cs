namespace Modin.SecondaryForms.Medicine
{
    public partial class Add : Form
    {
        public Action<Model.Medicine> OnMedicineAdd;

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int result))
            {
                var medicine = new Model.Medicine()
                {
                    Title = textBox1.Text,
                    Package = textBox2.Text,
                    Dosage = result
                };

                OnMedicineAdd.Invoke(medicine);
            }
        }
    }
}
