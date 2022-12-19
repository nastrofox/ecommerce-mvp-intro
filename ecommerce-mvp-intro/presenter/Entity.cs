using ecommerce_mvp_intro.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_mvp_intro.presenter
{
    public class Entity
    {
        public Entity()
        {
            Id = "";
            Field1 = "";
            Field3 = "";
            Field2 = "";
            Field4 = "";
        }

        public string Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
    }
}
