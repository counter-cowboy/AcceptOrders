using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcceptOrders.Models
{
    
    public class Orders
    {
        Random rnd = new Random();
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Номер заказа")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Number { get; set; } = Guid.NewGuid();

        

        [Required, DisplayName("Город отправителя")]
        public string? SenderCity { get; set; }

        [Required, DisplayName("Адрес отправителя")]
        [DataType(DataType.MultilineText)]

        public string? SenderAddress { get; set; }

        [Required, DisplayName("Город получателя")]
        public string? RecipientCity { get; set; }

        [Required, DisplayName("Адрес получателя"), DataType(DataType.MultilineText)]
        public string? RecipientAddress { get; set; }

        [Required, DisplayName("Вес груза")]
        public float Weight { get; set; }

        [DataType(DataType.Date), Required, DisplayName("Дата забора заказа")]
        public DateTime DatePickup { get; set; }               
    }
}
