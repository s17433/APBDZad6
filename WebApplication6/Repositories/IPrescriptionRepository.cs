using APBD_06.Model;

namespace APBD_06.Repositories;

public interface IPrescriptionRepository
{
    int CreatePrescription(NewPrescriptionRequest newPrescription);
    PatientInfo GetPatientInfo(int id);
}