using ecommerce_mvp_intro.model;
using ecommerce_mvp_intro.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce_mvp_intro.presenter
{
    public class Presenter
    {
        private Form1 view;
        private Cart carr;

        private Entity[] ToEntities(Product[] list) {
            Entity[] entities = new Entity[list.Length];
            for (int i = 0; i < entities.Length; i++)
            {
                entities[i] = EntityFactory.GetEntity(list[i]);
            }
            return entities;
        }

        private void updateCartView()
        {
            Entity[] entities = ToEntities(carr.Products);

            view.updateCarrView(entities);
        }

        public Presenter(Form1 view) {

            carr = EcommerceFactory.getSampleCart();

            this.view = view;

            updateCartView();

        }

        public void OnAdd(object sender, EventArgs e)
        {
            try
            {
                
                Product p = new Product(EcommerceFactory.getProductID(), view.CurrentEntity.Field1, view.CurrentEntity.Field2, view.CurrentEntity.Field3, float.Parse(view.CurrentEntity.Field4));
                carr.Add(p);

                updateCartView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void OnEdit(object sender, EventArgs e)
        {

            Product p = new Product(view.CurrentEntity.Id, view.CurrentEntity.Field1, view.CurrentEntity.Field2, view.CurrentEntity.Field3, float.Parse(view.CurrentEntity.Field4));
            if (carr.IndexOf(p) < 0)
            {
                MessageBox.Show("invalid ID");
                return;
            }

            carr.Modify(p);

            updateCartView();

        }


        public void OnDelete(object sender, EventArgs e)
        {
            Product p = new Product(view.CurrentEntity.Id, view.CurrentEntity.Field1, view.CurrentEntity.Field2, view.CurrentEntity.Field3, float.Parse(view.CurrentEntity.Field4));
            if (carr.IndexOf(p) < 0)
            {
                MessageBox.Show("invalid ID");
                return;
            }

            carr.Remove(p);

            updateCartView();
        }


        public Entity UpdateEntity(Entity item)
        {
            Product p = new Product(item.Id);


            int i = carr.IndexOf(p);
            if (i >= 0)
                return EntityFactory.GetEntity(carr.Products[i]);
            else
                return null;
        }
    }

}
