using QuickBuy.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Request : Entitie
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int FormPaymentId { get; set; }
        public virtual FormPayment FormPayment { get; set; }

        //Pedido pode ter pelo menos um item de pedido ou muitos itens
        public virtual ICollection<RequestItem> RequestItems { get; set; }

        public override void Validate()
        {
            ClearMessage();

            if (!RequestItems.Any())
                AddMessage("Atenção: Item de pedido não pode estar vazio");

            if (string.IsNullOrEmpty(CEP))
                AddMessage("Atenção: CEP deve estar preenchido");

            if (FormPaymentId == 0)
                AddMessage("Atenção: Não foi informado a forma de pagamento");
        }
    }
}
