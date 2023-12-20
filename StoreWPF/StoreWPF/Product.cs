using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWPF
{
    public class Product
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //  public int Id { get; set; }
        
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int maxAmount;
        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }
        public Product(int id, string imagePath, string name, string description, int price, int maxAmount) 
        {
            var Id = "dsdsds";
            this.Id = Id;
            // в свойство класса сохраняется одноименная локальная переменная , если названия не совпадают, this можно опустить
            
            this.Id = id;
            //Id = id; - это тоже самое, что выше, т.к. названия разные
            this.ImagePath = imagePath;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.MaxAmount = maxAmount;
        }
    }
}
