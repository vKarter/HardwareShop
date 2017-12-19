using System.Runtime.Serialization;

namespace HardwareShop.Entities
{
    [DataContract]
    public class OrderStatus
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
