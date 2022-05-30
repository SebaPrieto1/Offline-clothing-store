
namespace ProyectoFInal
{
    partial class ModAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGastoTotTienda = new System.Windows.Forms.Label();
            this.lblTotTarjetas = new System.Windows.Forms.Label();
            this.lblTotUsers = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Controls.Add(this.TabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dgvClientes);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(449, 423);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Clientes";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(443, 417);
            this.dgvClientes.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.dgvTarjetas);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(449, 423);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Tarjetas";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarjetas.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTarjetas.Location = new System.Drawing.Point(3, 3);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.RowTemplate.Height = 25;
            this.dgvTarjetas.Size = new System.Drawing.Size(443, 417);
            this.dgvTarjetas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblGastoTotTienda);
            this.panel1.Controls.Add(this.lblTotTarjetas);
            this.panel1.Controls.Add(this.lblTotUsers);
            this.panel1.Location = new System.Drawing.Point(461, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 223);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total gastado en la tienda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero de tarjetas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de usuarios:";
            // 
            // lblGastoTotTienda
            // 
            this.lblGastoTotTienda.AutoSize = true;
            this.lblGastoTotTienda.Location = new System.Drawing.Point(13, 178);
            this.lblGastoTotTienda.Name = "lblGastoTotTienda";
            this.lblGastoTotTienda.Size = new System.Drawing.Size(38, 15);
            this.lblGastoTotTienda.TabIndex = 0;
            this.lblGastoTotTienda.Text = "label3";
            // 
            // lblTotTarjetas
            // 
            this.lblTotTarjetas.AutoSize = true;
            this.lblTotTarjetas.Location = new System.Drawing.Point(13, 114);
            this.lblTotTarjetas.Name = "lblTotTarjetas";
            this.lblTotTarjetas.Size = new System.Drawing.Size(38, 15);
            this.lblTotTarjetas.TabIndex = 0;
            this.lblTotTarjetas.Text = "label3";
            // 
            // lblTotUsers
            // 
            this.lblTotUsers.AutoSize = true;
            this.lblTotUsers.Location = new System.Drawing.Point(13, 48);
            this.lblTotUsers.Name = "lblTotUsers";
            this.lblTotUsers.Size = new System.Drawing.Size(38, 15);
            this.lblTotUsers.TabIndex = 0;
            this.lblTotUsers.Text = "label3";
            // 
            // ModAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(647, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModAdmin";
            this.Load += new System.EventHandler(this.ModAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGastoTotTienda;
        private System.Windows.Forms.Label lblTotTarjetas;
        private System.Windows.Forms.Label lblTotUsers;
    }
}