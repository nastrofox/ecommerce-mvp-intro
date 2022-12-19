using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce_mvp_intro.model
{
    //base version by Marco Borelli Nov 2022
    //extended and modified by olprofesur Nov-Dic 2022
    public class Cart
    {
        //attributes
        private const int MAXCART = 999;
        private string _id;
        private int currentLenght;
        private Product[] _prod = new Product[MAXCART];

        //properties
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
                    throw new Exception("Invalid Id");
            }
        }

        public Product[] Products
        {
            get
            {
                Product[] p = new Product[currentLenght];
                for(int i=0; i<currentLenght; i++)
                {
                    p[i] = _prod[i];
                }
                return p;
            }

        }

        //constructors
        public Cart(string id)
        {
            this.Id = id;
            Clear();
        }

        //copy constructor for clone
        protected Cart(Cart c) : this(c.Id)
        {
            Id = c.Id;
            currentLenght = c.currentLenght;
            for (int i = 0; i < c._prod.Length; i++)
            {
                if (c._prod[i] != null)
                {
                    _prod[i] = c._prod[i].Clone();
                }
            }


        }

        public Cart Clone()
        {
            return new Cart(this);
        }

        //metodi specifici
        public void Clear()
        {
            currentLenght = 0;
            for (int i = 0; i < _prod.Length; i++)
                _prod[i] = null;
        }
        public void Add(Product p)
        {
            if (currentLenght == MAXCART)
            {
                throw new Exception("Unable to add, MAX dimension of internal array reached");
            }

            if (p != null)
            {
                _prod[currentLenght] = p;
                ++currentLenght;
            }
            else
                throw new Exception("Invalid product");
        }

        public int Length()
        {
            if (currentLenght != _prod.Length)
                return currentLenght;
            else
                throw new Exception("Cart full");
        }

        public int IndexOf(Product q)
        {
            for (int i = 0; i < currentLenght; i++)
            {
                if (_prod[i].Equals(q))
                    return i;
            }
            return -1;
        }

        public void Modify(Product p)
        {
            int i = IndexOf(p);
            if (i>=0)
            {
                _prod[i] = p;
            }
            else
                throw new Exception("Product not found");
        }

        public Product Remove(Product p)
        {
            if (IndexOf(p) != -1)
            {
                for (int i = IndexOf(p); i < _prod.Length - 1; i++)
                    _prod[i] = _prod[i + 1];

                _prod[_prod.Length - 1] = null;

                --currentLenght;

                return p;
            }
            else
                throw new Exception("Product not found");
        }


 

    }
}
