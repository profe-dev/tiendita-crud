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

        #region "Variables"
        int nCodigo_ar = 0;
        int nEstado_guarda = 0;

        #endregion

        #region "Métodos"

        private void Formato_ar()
        {
            dgv_articulos.Columns[0].Width = 80;
            dgv_articulos.Columns[0].HeaderText = "CODIGO";
            dgv_articulos.Columns[1].Width = 250;
            dgv_articulos.Columns[1].HeaderText = "ARTICULO";
            dgv_articulos.Columns[2].Width = 150;
            dgv_articulos.Columns[2].HeaderText = "MARCA";
            dgv_articulos.Columns[3].Width = 80;
            dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            dgv_articulos.Columns[4].Width = 150;
            dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            dgv_articulos.Columns[5].Width = 150;
            dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            dgv_articulos.Columns[6].Visible = false;
            dgv_articulos.Columns[7].Visible = false;
        }

        private void Listado_ar(string cTexto)
        {
            Data_Articulos Datos = new Data_Articulos();
            dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        private void Estado_texto(bool lEstado)
        {
            txt_descripcion.ReadOnly = !lEstado;
            txt_marca.ReadOnly = !lEstado;
            txt_stock_actual.ReadOnly = !lEstado;
        }

        private void Estado_botones_proceso(bool lEstado)
        {
            btn_lupa_umedida.Enabled = lEstado;
            btn_lupa_categoria.Enabled = lEstado;
            btn_cancelar.Visible = lEstado;
            btn_guardar.Visible = lEstado;

            //Otros detalles
            txt_buscar.ReadOnly = lEstado;
            btn_buscar.Enabled = !lEstado;
            dgv_articulos.Enabled = !lEstado;    
        }

        private void Estado_botones_principales(bool lEstado)
        {
            btn_nuevo.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_eliminar.Enabled = lEstado;
            btn_reporte.Enabled = lEstado;
            btn_salir.Enabled = lEstado;
        }

        private void Limpia_Texto()
        {
            txt_descripcion.Text = "";
            txt_marca.Text = "";
            txt_umedida.Text = "";
            txt_categoria.Text = "";
            txt_stock_actual.Text = "";
;        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Selecciona un registro válido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ar = Convert.ToInt32(dgv_articulos.CurrentRow.Cells["codigo_ar"].Value);
                txt_descripcion.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["descripcion_ar"].Value);
                txt_marca.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["marca_ar"].Value);
                txt_umedida.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_um"].Value);
                txt_categoria.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_ca"].Value);
                txt_stock_actual.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["stock_actual_ar"].Value);
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //Botón que realiza la búsqueda
            this.Listado_ar("%" + txt_buscar.Text.Trim() + "%");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 1; //Nuevo Registro
            this.Limpia_Texto();
            this.Estado_texto(true);
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);

            //Enviamos el cursor al txt_descripcion
            txt_descripcion.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_Texto();
            this.Estado_texto(false);
            this.Estado_botones_proceso(false);
            this.Estado_botones_principales(true);
            nCodigo_ar = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            Prop_Articulos oAr = new Prop_Articulos();
            oAr.Codigo_ar = nCodigo_ar;
            oAr.Descripcion_ar = txt_descripcion.Text.Trim();
            oAr.Marca_ar = txt_marca.Text.Trim();
            oAr.Codigo_um = 1;
            oAr.Codigo_ca = 1;
            oAr.Stock_actual = Convert.ToInt32(txt_stock_actual.Text);
            oAr.Fecha_crea = DateTime.Now.ToString("yyyy-MM-dd");
            oAr.Fecha_modifica = DateTime.Now.ToString("yyyy-MM-dd");

            Data_Articulos Datos = new Data_Articulos();
            Rpta = Datos.Guardar_ar(nEstado_guarda, oAr);

            if (Rpta.Equals("OK"))
            {
                this.Estado_texto(false);
                this.Estado_botones_proceso(false);
                this.Estado_botones_principales(true);
                this.Listado_ar("%");
                this.Limpia_Texto();
                nCodigo_ar = 0;
                nEstado_guarda = 0;

                MessageBox.Show("Los datos se han guardado correctamente","Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 2; //Actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_proceso(true); //Botones cancelar y guardar se visualizan
            this.Estado_botones_principales(false); //Se desactivan los botones principales

            txt_descripcion.Focus(); //Se envia el cursor al textbox descripcion_ar

        }

        private void dgv_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (nCodigo_ar > 0 )
            {
                string Rpta = "";
                Data_Articulos Datos = new Data_Articulos();
                Rpta = Datos.Eliminar_ar(nCodigo_ar);

                if (Rpta.Equals("OK"))
                {
                    this.Limpia_Texto();
                    this.Listado_ar("%");
                    nCodigo_ar = 0;
                    MessageBox.Show("Registro eliminado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    MessageBox.Show("No tiene seleccionado ningún registro", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
