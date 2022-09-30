using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiendita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Métodos

        private void Listado_ar(string cTexto)
        {
            Data_Articulos Datos = new Data_Articulos();
            dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }
    }
}
