
namespace TP_Productos
{
    partial class FormProductos
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
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.lblDescripcionProd = new System.Windows.Forms.Label();
            this.lblStockProd = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.TabcProductos = new System.Windows.Forms.TabControl();
            this.TabpCargarProd = new System.Windows.Forms.TabPage();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.tboxStockProd = new System.Windows.Forms.TextBox();
            this.tboxDescProd = new System.Windows.Forms.TextBox();
            this.tboxCodigoProd = new System.Windows.Forms.TextBox();
            this.TabpMovDeProductos = new System.Windows.Forms.TabPage();
            this.lblStockCargado = new System.Windows.Forms.Label();
            this.lblDescripcionCargada = new System.Windows.Forms.Label();
            this.lblCodigoCargado = new System.Windows.Forms.Label();
            this.tboxCantidadProd = new System.Windows.Forms.TextBox();
            this.checkEgresar = new System.Windows.Forms.CheckBox();
            this.chekIngresar = new System.Windows.Forms.CheckBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pbLogo2 = new System.Windows.Forms.PictureBox();
            this.TabcProductos.SuspendLayout();
            this.TabpCargarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.TabpMovDeProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProd.Location = new System.Drawing.Point(6, 17);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(71, 24);
            this.lblCodigoProd.TabIndex = 0;
            this.lblCodigoProd.Text = "Código";
            // 
            // lblDescripcionProd
            // 
            this.lblDescripcionProd.AutoSize = true;
            this.lblDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProd.Location = new System.Drawing.Point(4, 58);
            this.lblDescripcionProd.Name = "lblDescripcionProd";
            this.lblDescripcionProd.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcionProd.TabIndex = 1;
            this.lblDescripcionProd.Text = "Descripción";
            // 
            // lblStockProd
            // 
            this.lblStockProd.AutoSize = true;
            this.lblStockProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProd.Location = new System.Drawing.Point(4, 99);
            this.lblStockProd.Name = "lblStockProd";
            this.lblStockProd.Size = new System.Drawing.Size(56, 24);
            this.lblStockProd.TabIndex = 2;
            this.lblStockProd.Text = "Stock";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(513, 129);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(80, 27);
            this.btCargar.TabIndex = 3;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // TabcProductos
            // 
            this.TabcProductos.Controls.Add(this.TabpCargarProd);
            this.TabcProductos.Controls.Add(this.TabpMovDeProductos);
            this.TabcProductos.Location = new System.Drawing.Point(17, 12);
            this.TabcProductos.Name = "TabcProductos";
            this.TabcProductos.SelectedIndex = 0;
            this.TabcProductos.Size = new System.Drawing.Size(771, 216);
            this.TabcProductos.TabIndex = 4;
            // 
            // TabpCargarProd
            // 
            this.TabpCargarProd.Controls.Add(this.pbLogo1);
            this.TabpCargarProd.Controls.Add(this.tboxStockProd);
            this.TabpCargarProd.Controls.Add(this.tboxDescProd);
            this.TabpCargarProd.Controls.Add(this.tboxCodigoProd);
            this.TabpCargarProd.Controls.Add(this.lblCodigoProd);
            this.TabpCargarProd.Controls.Add(this.btCargar);
            this.TabpCargarProd.Controls.Add(this.lblDescripcionProd);
            this.TabpCargarProd.Controls.Add(this.lblStockProd);
            this.TabpCargarProd.Location = new System.Drawing.Point(4, 22);
            this.TabpCargarProd.Name = "TabpCargarProd";
            this.TabpCargarProd.Padding = new System.Windows.Forms.Padding(3);
            this.TabpCargarProd.Size = new System.Drawing.Size(763, 190);
            this.TabpCargarProd.TabIndex = 0;
            this.TabpCargarProd.Text = "Carga de Producto";
            this.TabpCargarProd.UseVisualStyleBackColor = true;
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = global::TP_Productos.Properties.Resources.Almacen_logo;
            this.pbLogo1.Location = new System.Drawing.Point(510, 14);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(242, 104);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo1.TabIndex = 7;
            this.pbLogo1.TabStop = false;
            // 
            // tboxStockProd
            // 
            this.tboxStockProd.Enabled = false;
            this.tboxStockProd.Location = new System.Drawing.Point(129, 99);
            this.tboxStockProd.Name = "tboxStockProd";
            this.tboxStockProd.Size = new System.Drawing.Size(295, 20);
            this.tboxStockProd.TabIndex = 6;
            // 
            // tboxDescProd
            // 
            this.tboxDescProd.Location = new System.Drawing.Point(129, 58);
            this.tboxDescProd.Name = "tboxDescProd";
            this.tboxDescProd.Size = new System.Drawing.Size(295, 20);
            this.tboxDescProd.TabIndex = 5;
            this.tboxDescProd.TextChanged += new System.EventHandler(this.tboxDescProd_TextChanged);
            // 
            // tboxCodigoProd
            // 
            this.tboxCodigoProd.Location = new System.Drawing.Point(129, 17);
            this.tboxCodigoProd.Name = "tboxCodigoProd";
            this.tboxCodigoProd.Size = new System.Drawing.Size(295, 20);
            this.tboxCodigoProd.TabIndex = 4;
            // 
            // TabpMovDeProductos
            // 
            this.TabpMovDeProductos.Controls.Add(this.pbLogo2);
            this.TabpMovDeProductos.Controls.Add(this.lblStockCargado);
            this.TabpMovDeProductos.Controls.Add(this.lblDescripcionCargada);
            this.TabpMovDeProductos.Controls.Add(this.lblCodigoCargado);
            this.TabpMovDeProductos.Controls.Add(this.tboxCantidadProd);
            this.TabpMovDeProductos.Controls.Add(this.checkEgresar);
            this.TabpMovDeProductos.Controls.Add(this.chekIngresar);
            this.TabpMovDeProductos.Controls.Add(this.lblCantidad);
            this.TabpMovDeProductos.Controls.Add(this.btAceptar);
            this.TabpMovDeProductos.Location = new System.Drawing.Point(4, 22);
            this.TabpMovDeProductos.Name = "TabpMovDeProductos";
            this.TabpMovDeProductos.Padding = new System.Windows.Forms.Padding(3);
            this.TabpMovDeProductos.Size = new System.Drawing.Size(763, 190);
            this.TabpMovDeProductos.TabIndex = 1;
            this.TabpMovDeProductos.Text = "Movimiento de Productos";
            this.TabpMovDeProductos.UseVisualStyleBackColor = true;
            // 
            // lblStockCargado
            // 
            this.lblStockCargado.AutoSize = true;
            this.lblStockCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCargado.Location = new System.Drawing.Point(30, 78);
            this.lblStockCargado.Name = "lblStockCargado";
            this.lblStockCargado.Size = new System.Drawing.Size(0, 15);
            this.lblStockCargado.TabIndex = 9;
            // 
            // lblDescripcionCargada
            // 
            this.lblDescripcionCargada.AutoSize = true;
            this.lblDescripcionCargada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCargada.Location = new System.Drawing.Point(30, 49);
            this.lblDescripcionCargada.Name = "lblDescripcionCargada";
            this.lblDescripcionCargada.Size = new System.Drawing.Size(0, 15);
            this.lblDescripcionCargada.TabIndex = 8;
            // 
            // lblCodigoCargado
            // 
            this.lblCodigoCargado.AutoSize = true;
            this.lblCodigoCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCargado.Location = new System.Drawing.Point(30, 23);
            this.lblCodigoCargado.Name = "lblCodigoCargado";
            this.lblCodigoCargado.Size = new System.Drawing.Size(0, 15);
            this.lblCodigoCargado.TabIndex = 7;
            this.lblCodigoCargado.Click += new System.EventHandler(this.lblCodigoCargado_Click);
            // 
            // tboxCantidadProd
            // 
            this.tboxCantidadProd.Location = new System.Drawing.Point(77, 111);
            this.tboxCantidadProd.Name = "tboxCantidadProd";
            this.tboxCantidadProd.Size = new System.Drawing.Size(97, 20);
            this.tboxCantidadProd.TabIndex = 6;
            // 
            // checkEgresar
            // 
            this.checkEgresar.AutoSize = true;
            this.checkEgresar.Location = new System.Drawing.Point(265, 134);
            this.checkEgresar.Name = "checkEgresar";
            this.checkEgresar.Size = new System.Drawing.Size(62, 17);
            this.checkEgresar.TabIndex = 5;
            this.checkEgresar.Text = "Egresar";
            this.checkEgresar.UseVisualStyleBackColor = true;
            // 
            // chekIngresar
            // 
            this.chekIngresar.AutoSize = true;
            this.chekIngresar.Location = new System.Drawing.Point(265, 111);
            this.chekIngresar.Name = "chekIngresar";
            this.chekIngresar.Size = new System.Drawing.Size(64, 17);
            this.chekIngresar.TabIndex = 4;
            this.chekIngresar.Text = "Ingresar";
            this.chekIngresar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(15, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(421, 113);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(83, 33);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 234);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(771, 204);
            this.dgvProductos.TabIndex = 5;
            // 
            // pbLogo2
            // 
            this.pbLogo2.Image = global::TP_Productos.Properties.Resources.Almacen_logo;
            this.pbLogo2.Location = new System.Drawing.Point(510, 14);
            this.pbLogo2.Name = "pbLogo2";
            this.pbLogo2.Size = new System.Drawing.Size(242, 104);
            this.pbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo2.TabIndex = 10;
            this.pbLogo2.TabStop = false;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_Productos.Properties.Resources.Almacen;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.TabcProductos);
            this.Name = "FormProductos";
            this.Text = "Almacen Lo Spuntino - Stock";
            this.TabcProductos.ResumeLayout(false);
            this.TabpCargarProd.ResumeLayout(false);
            this.TabpCargarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.TabpMovDeProductos.ResumeLayout(false);
            this.TabpMovDeProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.Label lblDescripcionProd;
        private System.Windows.Forms.Label lblStockProd;
        private System.Windows.Forms.Button btCargar;
        public System.Windows.Forms.TabControl TabcProductos;
        private System.Windows.Forms.TabPage TabpCargarProd;
        private System.Windows.Forms.TabPage TabpMovDeProductos;
        private System.Windows.Forms.TextBox tboxStockProd;
        private System.Windows.Forms.TextBox tboxDescProd;
        private System.Windows.Forms.TextBox tboxCodigoProd;
        private System.Windows.Forms.TextBox tboxCantidadProd;
        private System.Windows.Forms.CheckBox checkEgresar;
        private System.Windows.Forms.CheckBox chekIngresar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lblDescripcionCargada;
        private System.Windows.Forms.Label lblCodigoCargado;
        private System.Windows.Forms.Label lblStockCargado;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.PictureBox pbLogo2;
    }
}