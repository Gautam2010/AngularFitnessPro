using System.Linq;
using AngularFitnessPro.Models;
using AngularFitnessPro.ViewModels;

namespace AngularFitnessPro.Interface
{
    public interface IPaymentDetails
    {
        IQueryable<PaymentDetailsViewModel> GetAll(QueryParameters queryParameters, int userId);
        int Count(int userId);
        bool RenewalPayment(RenewalViewModel renewalViewModel);
    }
}