using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using ecommerce_mvp_intro.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
using ecommerce_mvp_intro.presenter;

namespace ecommerce_mvp_intro.view
{
    public partial class Form1 : Form
    {

        private Presenter presenter;

        public Form1()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            this.buttonAdd.Click += new System.EventHandler(presenter.OnAdd);
            this.buttonEdit.Click += new System.EventHandler(presenter.OnEdit);
            this.buttonDelete.Click += new System.EventHandler(presenter.OnDelete);

            SetHeaderList();
        }

        //properties for setting/getting gui values of internals gui elements

        public Entity CurrentEntity
        {
            get
            {
                Entity e = new Entity();
                e.Id = labelID.Text;
                e.Field1 = textBoxName.Text;
                e.Field2 = textBoxManifacturer.Text;
                e.Field3 = textBoxDescription.Text; 
                e.Field4=textBoxPrice.Text;
                return e;
            }

            set
            {
                labelID.Text = value.Id;
                textBoxName.Text = value.Field1;
                textBoxManifacturer.Text = value.Field2;
                textBoxDescription.Text = value.Field3;
                textBoxPrice.Text = value.Field4;

            }
        }

        public ListViewItem GetFocusedItem()
        {

            if (list.FocusedItem == null) return null;
            int listIndex = list.FocusedItem.Index;
            return list.Items[listIndex];
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListViewItem i = GetFocusedItem();

            if (i == null) return;

            Entity entity = new Entity();
            entity.Id = i.SubItems[0].Text;
            entity = presenter.UpdateEntity(entity);
            if (entity == null) return;

            CurrentEntity = entity; 

        }

        private void SetHeaderList()
        {
            list.View = View.Details;
            list.FullRowSelect = true;

            String[] intestazione = EntityFactory.GetProductFieldNames();
            for (int i = 0; i < intestazione.Length; i++)
            {
                list.Columns.Add(intestazione[i]);
            }

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void updateCarrView(Entity[] entities)
        {

            list.Items.Clear();
            list.View = View.Details;
            list.FullRowSelect = true;
            


            for (int i = 0; i < entities.Length; i++)
            {
                ListViewItem item = new ListViewItem(entities[i].Id);
                item.SubItems.Add(entities[i].Field1);
                item.SubItems.Add(entities[i].Field2);
                item.SubItems.Add(entities[i].Field3);
                item.SubItems.Add(""+ entities[i].Field4);
                list.Items.Add(item);
            }

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

    }
}
