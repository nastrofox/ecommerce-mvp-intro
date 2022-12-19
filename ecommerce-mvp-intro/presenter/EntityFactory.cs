using ecommerce_mvp_intro.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_mvp_intro.presenter
{
    public class EntityFactory
    {
        public static Entity GetEntity(Product p)
        {
            Entity e=new Entity();
            e.Id = p.Id;
            e.Field1 = p.Name;
            e.Field3 = p.Description;
            e.Field2 = p.Manufacturer;
            e.Field4 = "" + p.Price;
            return e;
        }
        public static string[] GetProductFieldNames()
        {
            return new string[] { "ID", "NOME", "PRODUTTORE", "DESCRIZIONE", "PREZZO" };
        }
    }
}
