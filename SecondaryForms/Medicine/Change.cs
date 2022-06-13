namespace Modin.SecondaryForms.Medicine
{
    public partial class Change : Form
    {
        public Action<int, Model.Medicine> OnMedicineChange;

        private int _index;

        public Change()
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

                OnMedicineChange.Invoke(_index, medicine);
            }
        }

        public void Set(DataGridViewRow row)
        {
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();

            _index = row.Index;
        }
    }
}
