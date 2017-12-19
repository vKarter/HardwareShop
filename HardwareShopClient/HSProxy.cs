using HardwareShop.Entities;
using HardwareShopClient.HSService;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Zza.Client
{
    //Własne proxy, a nie te wygenrowane przez VisualStudio
    class HSProxy : ClientBase<IHSService>, IHSService
    {
        public HSProxy() { }
        public HSProxy(string endpointName) : base(endpointName) { }
        public HSProxy(Binding binding, string address) : base(binding, new EndpointAddress(address)) { }

        public ObservableCollection<Product> GetProducts()
        {
            return Channel.GetProducts();
        }

        public ObservableCollection<Customer> GetCustomer()
        {
            return Channel.GetCustomer();
        }

        public void SubmitOrder(Order order)
        {
            Channel.SubmitOrder(order);
        }
    }
}
