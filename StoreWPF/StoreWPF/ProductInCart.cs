using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWPF
{
    public class ProductInCart : Product
    {
        private int idUser;
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public ProductInCart(int idUser, int id, string imagePath, string name, string description, int price, int amount, int maxAmount) : base( id, imagePath, name, description, price, maxAmount)
        {
            this.IdUser = idUser;
            this.amount = amount;
        }
    }
}
