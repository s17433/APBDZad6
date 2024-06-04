using APBD_06.Model;

namespace APBD_06.Services;

public interface IPrescriptionService
{
    int createPerscription(NewPrescriptionRequest newPrescription);
    PatientInfo GetPatientInfo(int id);
}