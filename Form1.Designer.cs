namespace ProyectoTiendita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_umedida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_lupa_umedida = new System.Windows.Forms.Button();
            this.btn_lupa_categoria = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(148, 46);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(144, 20);
            this.txt_descripcion.TabIndex = 1;
            // 
            // txt_umedida
            // 
            this.txt_umedida.Location = new System.Drawing.Point(148, 93);
            this.txt_umedida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_umedida.Name = "txt_umedida";
            this.txt_umedida.ReadOnly = true;
            this.txt_umedida.Size = new System.Drawing.Size(144, 20);
            this.txt_umedida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "U. Medida";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(441, 46);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(144, 20);
            this.txt_marca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(441, 93);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.ReadOnly = true;
            this.txt_categoria.Size = new System.Drawing.Size(144, 20);
            this.txt_categoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria";
            // 
            // txt_stock_actual
            // 
            this.txt_stock_actual.Location = new System.Drawing.Point(148, 137);
            this.txt_stock_actual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_stock_actual.Name = "txt_stock_actual";
            this.txt_stock_actual.ReadOnly = true;
            this.txt_stock_actual.Size = new System.Drawing.Size(144, 20);
            this.txt_stock_actual.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock Actual";
            // 
            // btn_lupa_umedida
            // 
            this.btn_lupa_umedida.Location = new System.Drawing.Point(295, 93);
            this.btn_lupa_umedida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lupa_umedida.Name = "btn_lupa_umedida";
            this.btn_lupa_umedida.Size = new System.Drawing.Size(24, 19);
            this.btn_lupa_umedida.TabIndex = 10;
            this.btn_lupa_umedida.Text = ":::";
            this.btn_lupa_umedida.UseVisualStyleBackColor = true;
            // 
            // btn_lupa_categoria
            // 
            this.btn_lupa_categoria.Location = new System.Drawing.Point(588, 93);
            this.btn_lupa_categoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lupa_categoria.Name = "btn_lupa_categoria";
            this.btn_lupa_categoria.Size = new System.Drawing.Size(24, 19);
            this.btn_lupa_categoria.TabIndex = 11;
            this.btn_lupa_categoria.Text = ":::";
            this.btn_lupa_categoria.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(354, 137);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 27);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(449, 137);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 27);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(982, 31);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(97, 69);
            this.btn_nuevo.TabIndex = 14;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(982, 115);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(97, 69);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(982, 200);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(97, 69);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.Location = new System.Drawing.Point(982, 286);
            this.btn_reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(97, 69);
            this.btn_reporte.TabIndex = 17;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(982, 373);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(97, 69);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AllowUserToAddRows = false;
            this.dgv_articulos.AllowUserToDeleteRows = false;
            this.dgv_articulos.AllowUserToOrderColumns = true;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Location = new System.Drawing.Point(36, 243);
            this.dgv_articulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.RowHeadersWidth = 51;
            this.dgv_articulos.RowTemplate.Height = 24;
            this.dgv_articulos.Size = new System.Drawing.Size(909, 242);
            this.dgv_articulos.TabIndex = 19;
            this.dgv_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulos_CellClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(95, 209);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(296, 210);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(24, 19);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = ":::";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 505);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_lupa_categoria);
            this.Controls.Add(this.btn_lupa_umedida);
            this.Controls.Add(this.txt_stock_actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_umedida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_umedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stock_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_lupa_umedida;
        private System.Windows.Forms.Button btn_lupa_categoria;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_buscar;
    }
}

