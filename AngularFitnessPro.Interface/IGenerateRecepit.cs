using AngularFitnessPro.ViewModels;

namespace AngularFitnessPro.Interface
{
    public interface IGenerateRecepit
    {
        GenerateRecepitViewModel Generate(int paymentId);
    }
}