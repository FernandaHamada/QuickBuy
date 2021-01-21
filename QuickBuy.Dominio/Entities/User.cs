using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{ 
    public class User : Entitie
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        // Usuário pode ter nenhum ou muitos pedidos
        public virtual ICollection <Request> Requests { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddMessage("Email não informado");

            if (string.IsNullOrEmpty(Password))
                AddMessage("Senha não informado");
        }
    }
}
