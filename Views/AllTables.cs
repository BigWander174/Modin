using Modin.Services;

namespace Modin.Views
{
    public class Tables
    {
        private DataGridView _pharmacy;
        private DataGridView _medicine;
        private DataGridView _medicineInPharmacy;
        private Service _service;

        public Tables(DataGridView pharmacy, DataGridView medicine, DataGridView medicineInPharmacy, Service service)
        {
            _pharmacy = pharmacy;
            _medicine = medicine;
            _medicineInPharmacy = medicineInPharmacy;
            _service = service;
            service.UpdatePresenter += Bind;
        }

        internal void Bind()
        {
            _pharmacy.DataSource = _service.Pharmacies;
            _medicine.DataSource = _service.Medicines;
            _medicineInPharmacy.DataSource = _service.MedicinesInPharmacies;
        }
    }
}
