using APBD_06.Model;
using APBD_06.Repositories;

namespace APBD_06.Services;

public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository _perscriptionRepository;
    
    public PrescriptionService(IPrescriptionRepository prescriptionRepository)
    {
        _perscriptionRepository = prescriptionRepository;
    }

    public int createPerscription(NewPrescriptionRequest newPrescription)
    {
        return _perscriptionRepository.CreatePrescription(newPrescription);
    }

    public PatientInfo GetPatientInfo(int id)
    {
        return _perscriptionRepository.GetPatientInfo(id);
    }
}