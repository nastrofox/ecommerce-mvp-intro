namespace ecommerce_mvp_intro.view
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelIDValue = new System.Windows.Forms.Label();
            this.LabelDescrizione = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxManifacturer = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(7, 112);
            this.list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(510, 366);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(718, 436);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(74, 42);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Modifica";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(569, 165);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(135, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(566, 150);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(847, 150);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            // 
            // labelIDValue
            // 
            this.labelIDValue.AutoSize = true;
            this.labelIDValue.Location = new System.Drawing.Point(867, 150);
            this.labelIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDValue.Name = "labelIDValue";
            this.labelIDValue.Size = new System.Drawing.Size(0, 13);
            this.labelIDValue.TabIndex = 6;
            // 
            // LabelDescrizione
            // 
            this.LabelDescrizione.AutoSize = true;
            this.LabelDescrizione.Location = new System.Drawing.Point(566, 317);
            this.LabelDescrizione.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDescrizione.Name = "LabelDescrizione";
            this.LabelDescrizione.Size = new System.Drawing.Size(62, 13);
            this.LabelDescrizione.TabIndex = 8;
            this.LabelDescrizione.Text = "Descrizione";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(569, 332);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(383, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelPrezzo
            // 
            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Location = new System.Drawing.Point(566, 259);
            this.labelPrezzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(39, 13);
            this.labelPrezzo.TabIndex = 10;
            this.labelPrezzo.Text = "Prezzo";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(565, 277);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(67, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(569, 436);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 42);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Aggiungi";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produttore";
            // 
            // textBoxManifacturer
            // 
            this.textBoxManifacturer.Location = new System.Drawing.Point(566, 214);
            this.textBoxManifacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxManifacturer.Name = "textBoxManifacturer";
            this.textBoxManifacturer.Size = new System.Drawing.Size(135, 20);
            this.textBoxManifacturer.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(878, 436);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(74, 42);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Elimina";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 619);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxManifacturer);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrezzo);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.LabelDescrizione);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelIDValue);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.list);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Basic Ecommerce Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelIDValue;
        private System.Windows.Forms.Label LabelDescrizione;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPrezzo;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxManifacturer;
        private System.Windows.Forms.Button buttonDelete;
    }
}

