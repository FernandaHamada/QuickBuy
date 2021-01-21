using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entitie
    {
        private List<string> _validationMessage { get; set; }
        private List<string>  validationMessage
        {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }

        protected void ClearMessage()
        {
            validationMessage.Clear();
        }

        protected void AddMessage(string message)
        {
            validationMessage.Add(message);
        }

        public abstract void Validate();
        protected bool isValid
        {
            get { return !validationMessage.Any(); }
        }
    }
}