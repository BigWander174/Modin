using Modin.Services;
using Modin.Views;

namespace Modin
{
    public partial class Form1 : Form
    {
        private SecondaryForms.Medicine.Add _addMedicineForm;
        private SecondaryForms.Pharmacy.Add _addPharmacyForm;
        private SecondaryForms.MedicineInPharmacies.Add _addMedicineToPharmacyForm;
        private SecondaryForms.Medicine.Change _changeMedicineForm;
        private SecondaryForms.MedicineInPharmacies.Change _changeMedicineInPharmacyForm;
        private Tables _tables;

        private Service _service;

        public Action<int> OnMedicineRemove;
        public Action<int> OnPharmacyRemove;
        public Action<int> OnPharmacyMedicineRemove;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _addPharmacyForm = new SecondaryForms.Pharmacy.Add();
            _addMedicineForm = new SecondaryForms.Medicine.Add();
            _addMedicineToPharmacyForm = new SecondaryForms.MedicineInPharmacies.Add();
            _changeMedicineForm = new SecondaryForms.Medicine.Change();
            _changeMedicineInPharmacyForm = new SecondaryForms.MedicineInPharmacies.Change();

            _service = new Service(_addPharmacyForm, _addMedicineForm, _changeMedicineForm, _addMedicineToPharmacyForm, _changeMedicineInPharmacyForm,this);

            _tables = new Tables(dataGridView1, dataGridView2, dataGridView3, _service);
            _tables.Bind();
        }

        private void addPharmacyButton_Click(object sender, EventArgs e)
        {
            _addPharmacyForm.ShowDialog();
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            _addMedicineForm.ShowDialog();
        }

        private void addMedicineToPharmacyButton_Click(object sender, EventArgs e)
        {
            _addMedicineToPharmacyForm.ShowDialog();
        }

        private void changeReaderButton_Click(object sender, EventArgs e)
        {
            _changeMedicineForm.ShowDialog();
        }

        private void deleteReaderButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            OnMedicineRemove.Invoke(id);
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.SelectedRows[0].Index;
            OnPharmacyRemove.Invoke(index);
        }

        private void removeMedicineFromPharmacyButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            OnPharmacyMedicineRemove.Invoke(id);
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _changeMedicineForm.Set(dataGridView2.Rows[e.RowIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _changeMedicineInPharmacyForm.ShowDialog();
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _changeMedicineInPharmacyForm.Set(dataGridView3.Rows[e.RowIndex]);
        }
    }
}