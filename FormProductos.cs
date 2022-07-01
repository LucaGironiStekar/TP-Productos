using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Entidades;

namespace TP_Productos
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();

            dgvProductos.Columns.Add("0", "Código");
            dgvProductos.Columns.Add("1", "Descripción");
            dgvProductos.Columns.Add("2", "Stock");

            dgvProductos.Columns["0"].Width = 100;
            dgvProductos.Columns["1"].Width = 300;
            dgvProductos.Columns["2"].Width = 328;
            
        }

        #region Missclick
        private void tboxDescProd_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        bool nuevo = true;
        int fila;

        void LlevarProdAlDGV(Producto Prod)
        {
            dgvProductos.Rows.Add(Prod.Vcodigo_prod.ToString(), Prod.Vdescripcion_prod.ToString(), Prod.Vstock_prod.ToString());
            fila = (dgvProductos.Rows.Count - 1);

        }


        private void btCargar_Click(object sender, EventArgs e)
        {
            Producto NuevoProducto;
            NuevoProducto = new Producto(int.Parse(tboxCodigoProd.Text), tboxDescProd.Text);
            lblCodigoCargado.Text = NuevoProducto.Vcodigo_prod.ToString();
            lblDescripcionCargada.Text = NuevoProducto.Vdescripcion_prod.ToString();
            lblStockCargado.Text = "Hay " + NuevoProducto.Vstock_prod.ToString() + " unidades";


            TabcProductos.SelectedTab = TabpMovDeProductos;
            MessageBox.Show("El producto ha sido cargado");

            LlevarProdAlDGV(NuevoProducto);
            nuevo = true;
            
        }

        #region Missclick 2
        private void lblCodigoCargado_Click(object sender, EventArgs e)
        {

        }


        private void btAceptar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
