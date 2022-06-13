using Modin.Model;
using Modin.Contexts;

namespace Modin.Services
{
    public class Service
    {
        private Context _context;

        public Action UpdatePresenter;

        public Service(SecondaryForms.Pharmacy.Add addPharmacyForm, 
            SecondaryForms.Medicine.Add addMedicineForm, SecondaryForms.Medicine.Change changeMedicineForm, 
            SecondaryForms.MedicineInPharmacies.Add addMedicineInPharmacyForm, 
            SecondaryForms.MedicineInPharmacies.Change changeMedicineInPharmacyForm,Form1 form)
        {
            _context = new Context();

            addPharmacyForm.OnPharmacyAdd += Add;
            addMedicineForm.OnMedicineAdd += Add;
            addMedicineInPharmacyForm.OnMedicineInPharmacyAdd += Add;
            changeMedicineForm.OnMedicineChange += Change;
            changeMedicineInPharmacyForm.OnChange += Change;
            form.OnPharmacyRemove += RemovePharmacy;
            form.OnMedicineRemove += RemoveMedicine;
            form.OnPharmacyMedicineRemove += RemoveMedicineFromPharmacy;
            UpdatePresenter += SaveInDB;
        }

        public List<Pharmacy> Pharmacies => _context.Pharmacies.ToList();
        public List<Medicine> Medicines => _context.Medicines.ToList();
        public List<MedicineInPharmacy> MedicinesInPharmacies => _context.MedicinesInFarmacies.ToList();

        private void Add(Pharmacy pharmacy)
        {
            _context.Pharmacies.Add(pharmacy);
            UpdatePresenter.Invoke();
        }

        private void RemovePharmacy(int index)
        {
            var pharmacy = _context.Pharmacies.ToList()[index];
            _context.Pharmacies.Remove(pharmacy);

            var medicinesToRemove = _context.MedicinesInFarmacies.Where(element => element.PharmacyId == pharmacy.Id);
            _context.MedicinesInFarmacies.RemoveRange(medicinesToRemove);
            UpdatePresenter.Invoke();
        }

        private void Add(Medicine medicine)
        {
            _context.Medicines.Add(medicine);
            UpdatePresenter.Invoke();
        }

        private void Add(MedicineInPharmacy medicine)
        {
            var isMedicineIdExist = _context.Medicines.FirstOrDefault(element => element.Id == medicine.MedicineId);
            var isPharmacyIdExist = _context.Pharmacies.FirstOrDefault(element => element.Id == medicine.PharmacyId);

            if (isMedicineIdExist is not null && isPharmacyIdExist is not null)
            {
                _context.MedicinesInFarmacies.Add(medicine);
                UpdatePresenter.Invoke();
            }
        }

        private void RemoveMedicine(int id)
        {
            var readerToDelete = _context.Medicines.First(reader => reader.Id == id);
            _context.Medicines.Remove(readerToDelete);

            var medicines = _context.MedicinesInFarmacies.Where(element => element.MedicineId == id);
            _context.MedicinesInFarmacies.RemoveRange(medicines);
            UpdatePresenter.Invoke();
        }

        private void Change(int index, Medicine medicine)
        {
            var medicineToChange = _context.Medicines.ToList()[index];
            medicineToChange.Title = medicine.Title;
            medicineToChange.Package = medicine.Package;
            medicineToChange.Dosage = medicine.Dosage;
            UpdatePresenter.Invoke();
        }

        private void Change(int index, MedicineInPharmacy medicine)
        {
            var isMedicineIdExist = _context.Medicines.FirstOrDefault(element => element.Id == medicine.MedicineId);
            var isPharmacyIdExist = _context.Pharmacies.FirstOrDefault(element => element.Id == medicine.PharmacyId);

            if (isMedicineIdExist is not null && isPharmacyIdExist is not null)
            {
                var medicineToChange = _context.MedicinesInFarmacies.ToList()[index];
                medicineToChange.MedicineId = medicine.MedicineId;
                medicineToChange.PharmacyId = medicine.PharmacyId;
                medicineToChange.Price = medicine.Price;
                medicineToChange.Amount = medicine.Amount;
                medicineToChange.Date = medicine.Date;

                UpdatePresenter.Invoke();
            }
        }

        private void RemoveMedicineFromPharmacy(int id)
        {
            var medicineToDelete = _context.MedicinesInFarmacies.First(book => book.Id == id);
            _context.MedicinesInFarmacies.Remove(medicineToDelete);
            UpdatePresenter.Invoke();
        }

        private void SaveInDB()
        {
            _context.SaveChanges();
        }
    }
}
