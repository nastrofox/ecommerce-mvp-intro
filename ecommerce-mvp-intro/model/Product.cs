using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ecommerce_mvp_intro.model
{

    //base version by Marco Borelli Nov 2022
    //extended and modified by olprofesur Nov-Dic 2022
    public class Product
    {   
        
        //ATTRIBUTES
        private string _id, _name, _manufacturer, _description;
        private float _price;

        //SET AND GET MEDIANTE PROPERTIES
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Invalid ID");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value != null)
                    _name = value;
                else
                    throw new Exception("Invalid name");
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            private set
            {
                if (value != null)
                    _manufacturer = value;
                else
                    throw new Exception("Invalid manufacturer");
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                if (value != null)
                    _description = value;
                else
                    throw new Exception("Invalid description");
            }
        }

        //CONSTRUCTORS

        public Product(string id, string name, string prod, string descr, float price)
        {
            if(String.IsNullOrEmpty(id) )
            {
                throw new Exception("invalid product parameters");
            }
            Id = id;
            Name = name;
            Manufacturer = prod;
            Description = descr;
            Price = price;
        }

        public Product(string id, string name, string prod, string descr) : this(id, name, prod, descr, 10)
        {
        }

        public Product(string id, string name, string prod) : this(id, name, prod, "N/A", 10)
        {
        }

        public Product() : this("IDVUOTO", "N/A", "N/A", "N/A", 10)
        {
        }

        public Product(string id, string name, string prod, float price) : this(id, name, prod, "N/A", price)
        {

        }

        public Product(string id) : this(id, "N/A", "N/A", "N/A", 1)
        {

        }

        //copy constructor for clone
        protected Product(Product other) : this(other.Id, other.Name, other.Manufacturer, other.Description, other.Price)
        {
        }

        //clone
        public Product Clone()
        {
            return new Product(this);
        }


        //Equals

        public bool Equals(Product p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }

        //ToString
        public override string ToString()
        {
            return "Product:" +Id + ";" + Name + ";" + Manufacturer+";"+Description + ";" + Price;
        }

    }
}
