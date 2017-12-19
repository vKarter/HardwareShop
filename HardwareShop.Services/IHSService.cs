using HardwareShop.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace HardwareShop.Services
{
    [ServiceContract]
    public interface IHSService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        List<Customer> GetCustomer();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
