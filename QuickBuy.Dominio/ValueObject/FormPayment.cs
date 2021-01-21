using QuickBuy.Dominio.Enums;

namespace QuickBuy.Dominio.ValueObject
{
    public class FormPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        

        public bool isBillet
        {
            get { return Id == (int)PaymentTypesEnum.Billet; }
        }

        public bool isCreditCard
        {
            get { return Id == (int)PaymentTypesEnum.CreditCard; }
        }

        public bool isDeposit
        {
            get { return Id == (int)PaymentTypesEnum.Deposit; }
        }

        public bool isNotDefined
        {
            get { return Id == (int)PaymentTypesEnum.NotDefined; }
        }

        
       
    }
}
