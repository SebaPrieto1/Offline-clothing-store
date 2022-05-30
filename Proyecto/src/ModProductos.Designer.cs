
namespace ProyectoFInal
{
    partial class ModProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModProductos));
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnpromocionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelnuevoproducto = new System.Windows.Forms.Panel();
            this.btnnuevoproducto = new System.Windows.Forms.Button();
            this.paneldescuento = new System.Windows.Forms.Panel();
            this.btnquitdescuento = new System.Windows.Forms.Button();
            this.btnagregardescuento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelnuevoproducto.SuspendLayout();
            this.paneldescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(0, 168);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(154, 40);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar Productos";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnpromocionar
            // 
            this.btnpromocionar.FlatAppearance.BorderSize = 0;
            this.btnpromocionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnpromocionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpromocionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpromocionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpromocionar.Location = new System.Drawing.Point(0, 205);
            this.btnpromocionar.Name = "btnpromocionar";
            this.btnpromocionar.Size = new System.Drawing.Size(154, 40);
            this.btnpromocionar.TabIndex = 0;
            this.btnpromocionar.Text = "Promocionar";
            this.btnpromocionar.UseVisualStyleBackColor = true;
            this.btnpromocionar.Click += new System.EventHandler(this.btnpromocionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(0, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 40);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Quitar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(10, 64);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 23);
            this.txtTipo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(116, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // txtTalle
            // 
            this.txtTalle.Location = new System.Drawing.Point(222, 64);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(100, 23);
            this.txtTalle.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(328, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Talle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio";
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.Location = new System.Drawing.Point(160, 259);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(526, 395);
            this.dgvProductos.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.btnpromocionar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 666);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelnuevoproducto
            // 
            this.panelnuevoproducto.Controls.Add(this.btnnuevoproducto);
            this.panelnuevoproducto.Controls.Add(this.txtTipo);
            this.panelnuevoproducto.Controls.Add(this.txtMarca);
            this.panelnuevoproducto.Controls.Add(this.txtTalle);
            this.panelnuevoproducto.Controls.Add(this.label4);
            this.panelnuevoproducto.Controls.Add(this.txtPrecio);
            this.panelnuevoproducto.Controls.Add(this.label3);
            this.panelnuevoproducto.Controls.Add(this.label1);
            this.panelnuevoproducto.Controls.Add(this.label2);
            this.panelnuevoproducto.Location = new System.Drawing.Point(243, 44);
            this.panelnuevoproducto.Name = "panelnuevoproducto";
            this.panelnuevoproducto.Size = new System.Drawing.Size(434, 157);
            this.panelnuevoproducto.TabIndex = 8;
            this.panelnuevoproducto.Visible = false;
            // 
            // btnnuevoproducto
            // 
            this.btnnuevoproducto.Location = new System.Drawing.Point(328, 110);
            this.btnnuevoproducto.Name = "btnnuevoproducto";
            this.btnnuevoproducto.Size = new System.Drawing.Size(100, 38);
            this.btnnuevoproducto.TabIndex = 5;
            this.btnnuevoproducto.Text = "Agregar";
            this.btnnuevoproducto.UseVisualStyleBackColor = true;
            this.btnnuevoproducto.Click += new System.EventHandler(this.btnnuevoproducto_Click);
            // 
            // paneldescuento
            // 
            this.paneldescuento.Controls.Add(this.btnquitdescuento);
            this.paneldescuento.Controls.Add(this.btnagregardescuento);
            this.paneldescuento.Controls.Add(this.label6);
            this.paneldescuento.Controls.Add(this.label5);
            this.paneldescuento.Controls.Add(this.txtdescuento);
            this.paneldescuento.Location = new System.Drawing.Point(160, 121);
            this.paneldescuento.Name = "paneldescuento";
            this.paneldescuento.Size = new System.Drawing.Size(453, 100);
            this.paneldescuento.TabIndex = 9;
            this.paneldescuento.Visible = false;
            // 
            // btnquitdescuento
            // 
            this.btnquitdescuento.Location = new System.Drawing.Point(311, 57);
            this.btnquitdescuento.Name = "btnquitdescuento";
            this.btnquitdescuento.Size = new System.Drawing.Size(93, 40);
            this.btnquitdescuento.TabIndex = 4;
            this.btnquitdescuento.Text = "Quitar";
            this.btnquitdescuento.UseVisualStyleBackColor = true;
            this.btnquitdescuento.Click += new System.EventHandler(this.btnquitdescuento_Click);
            // 
            // btnagregardescuento
            // 
            this.btnagregardescuento.Location = new System.Drawing.Point(201, 57);
            this.btnagregardescuento.Name = "btnagregardescuento";
            this.btnagregardescuento.Size = new System.Drawing.Size(94, 40);
            this.btnagregardescuento.TabIndex = 3;
            this.btnagregardescuento.Text = "Agregar";
            this.btnagregardescuento.UseVisualStyleBackColor = true;
            this.btnagregardescuento.Click += new System.EventHandler(this.btnagregardescuento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(131, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Porcentaje de descuento";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(25, 57);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(100, 23);
            this.txtdescuento.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(262, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 47);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock Tienda Online";
            // 
            // ModProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paneldescuento);
            this.Controls.Add(this.panelnuevoproducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ModProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelnuevoproducto.ResumeLayout(false);
            this.panelnuevoproducto.PerformLayout();
            this.paneldescuento.ResumeLayout(false);
            this.paneldescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnpromocionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelnuevoproducto;
        private System.Windows.Forms.Button btnnuevoproducto;
        private System.Windows.Forms.Panel paneldescuento;
        private System.Windows.Forms.Button btnagregardescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Button btnquitdescuento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}