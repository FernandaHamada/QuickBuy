namespace QuickBuy.Dominio.Entities
{
    public class RequestItem : Entitie
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
                AddMessage("Não foi identificado qual a referência do produto");

            if (Quantity == 0)
                AddMessage("Quantidade não informada");
        }
    }
}
