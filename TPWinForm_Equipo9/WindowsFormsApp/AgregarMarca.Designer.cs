
namespace WindowsFormsApp
{
    partial class AgregarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtBoxCategoria = new System.Windows.Forms.TextBox();
            this.BtnSaveNewCategoria = new System.Windows.Forms.Button();
            this.lblAgregarMarcCat = new System.Windows.Forms.Label();
            this.lblElimMarcCate = new System.Windows.Forms.Label();
            this.cmbEliminarMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.cmbEliminarCategoria = new System.Windows.Forms.ComboBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnVolverGestionMarcCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(148, 88);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(116, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(313, 84);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(110, 27);
            this.btnGuardarMarca.TabIndex = 2;
            this.btnGuardarMarca.Text = "Guardar Marca";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(74, 144);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.Location = new System.Drawing.Point(148, 137);
            this.txtBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(116, 20);
            this.txtBoxCategoria.TabIndex = 4;
            // 
            // BtnSaveNewCategoria
            // 
            this.BtnSaveNewCategoria.Location = new System.Drawing.Point(313, 130);
            this.BtnSaveNewCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveNewCategoria.Name = "BtnSaveNewCategoria";
            this.BtnSaveNewCategoria.Size = new System.Drawing.Size(110, 27);
            this.BtnSaveNewCategoria.TabIndex = 5;
            this.BtnSaveNewCategoria.Text = "Guardar Categoria";
            this.BtnSaveNewCategoria.UseVisualStyleBackColor = true;
            this.BtnSaveNewCategoria.Click += new System.EventHandler(this.BtnSaveNewCategoria_Click);
            // 
            // lblAgregarMarcCat
            // 
            this.lblAgregarMarcCat.AutoSize = true;
            this.lblAgregarMarcCat.Location = new System.Drawing.Point(179, 43);
            this.lblAgregarMarcCat.Name = "lblAgregarMarcCat";
            this.lblAgregarMarcCat.Size = new System.Drawing.Size(127, 13);
            this.lblAgregarMarcCat.TabIndex = 10;
            this.lblAgregarMarcCat.Text = "Agregar Marca/Categoria";
            // 
            // lblElimMarcCate
            // 
            this.lblElimMarcCate.AutoSize = true;
            this.lblElimMarcCate.Location = new System.Drawing.Point(172, 201);
            this.lblElimMarcCate.Name = "lblElimMarcCate";
            this.lblElimMarcCate.Size = new System.Drawing.Size(126, 13);
            this.lblElimMarcCate.TabIndex = 11;
            this.lblElimMarcCate.Text = "Eliminar Marca/Categoria";
            // 
            // cmbEliminarMarca
            // 
            this.cmbEliminarMarca.FormattingEnabled = true;
            this.cmbEliminarMarca.Location = new System.Drawing.Point(148, 241);
            this.cmbEliminarMarca.Name = "cmbEliminarMarca";
            this.cmbEliminarMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbEliminarMarca.TabIndex = 12;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(89, 249);
            this.lblMarca2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(40, 13);
            this.lblMarca2.TabIndex = 13;
            this.lblMarca2.Text = "Marca:";
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Location = new System.Drawing.Point(74, 295);
            this.lblCat2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(55, 13);
            this.lblCat2.TabIndex = 14;
            this.lblCat2.Text = "Categoria:";
            // 
            // cmbEliminarCategoria
            // 
            this.cmbEliminarCategoria.FormattingEnabled = true;
            this.cmbEliminarCategoria.Location = new System.Drawing.Point(148, 287);
            this.cmbEliminarCategoria.Name = "cmbEliminarCategoria";
            this.cmbEliminarCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbEliminarCategoria.TabIndex = 15;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(313, 241);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(110, 27);
            this.btnEliminarMarca.TabIndex = 16;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(313, 283);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(110, 27);
            this.btnEliminarCategoria.TabIndex = 17;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnVolverGestionMarcCat
            // 
            this.btnVolverGestionMarcCat.Location = new System.Drawing.Point(339, 358);
            this.btnVolverGestionMarcCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverGestionMarcCat.Name = "btnVolverGestionMarcCat";
            this.btnVolverGestionMarcCat.Size = new System.Drawing.Size(110, 27);
            this.btnVolverGestionMarcCat.TabIndex = 18;
            this.btnVolverGestionMarcCat.Text = "Volver";
            this.btnVolverGestionMarcCat.UseVisualStyleBackColor = true;
            this.btnVolverGestionMarcCat.Click += new System.EventHandler(this.btnVolverGestionMarcCat_Click);
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 414);
            this.Controls.Add(this.btnVolverGestionMarcCat);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.cmbEliminarCategoria);
            this.Controls.Add(this.lblCat2);
            this.Controls.Add(this.lblMarca2);
            this.Controls.Add(this.cmbEliminarMarca);
            this.Controls.Add(this.lblElimMarcCate);
            this.Controls.Add(this.lblAgregarMarcCat);
            this.Controls.Add(this.BtnSaveNewCategoria);
            this.Controls.Add(this.txtBoxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarca";
            this.Load += new System.EventHandler(this.AgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtBoxCategoria;
        private System.Windows.Forms.Button BtnSaveNewCategoria;
        private System.Windows.Forms.Label lblAgregarMarcCat;
        private System.Windows.Forms.Label lblElimMarcCate;
        private System.Windows.Forms.ComboBox cmbEliminarMarca;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Label lblCat2;
        private System.Windows.Forms.ComboBox cmbEliminarCategoria;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnVolverGestionMarcCat;
    }
}