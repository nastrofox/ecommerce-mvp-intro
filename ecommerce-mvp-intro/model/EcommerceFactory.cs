using ecommerce_mvp_intro.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_mvp_intro.model
{
    public class EcommerceFactory
    {
        static int idProductCount=1;
        static int idCartCount = 1;

        public static string getCartID()
        {
            string id = "C" + idProductCount;
            idCartCount++;
            return id;
        }

        public static string getProductID()
        {
            string id = "P" + idProductCount;
            idProductCount++;
            return id;
        }

        public static Cart getSampleCart()
        {
            Cart carr = new Cart(getCartID());
            Product p = new Product(EcommerceFactory.getProductID(), "iPhone 14 128GB", "Apple", "Apple iPhone 14 128GB", 950);
            carr.Add(p);
            return carr;
        }
    }
}
