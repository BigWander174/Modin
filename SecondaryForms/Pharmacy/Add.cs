namespace Modin.SecondaryForms.Pharmacy
{
    public partial class Add : Form
    {
        public Action<Model.Pharmacy> OnPharmacyAdd;

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pharmacy = new Model.Pharmacy()
            {
                Title = textBox1.Text,
                Address = textBox2.Text,
            };

            OnPharmacyAdd.Invoke(pharmacy);
        }
    }
}
