namespace Clase_18_de_mayo
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
            this.buttonProvar = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNiveldepoder = new System.Windows.Forms.NumericUpDown();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechadecreacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNiveldepoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProvar
            // 
            this.buttonProvar.Location = new System.Drawing.Point(616, 204);
            this.buttonProvar.Name = "buttonProvar";
            this.buttonProvar.Size = new System.Drawing.Size(139, 26);
            this.buttonProvar.TabIndex = 0;
            this.buttonProvar.Text = "Provar conexion";
            this.buttonProvar.UseVisualStyleBackColor = true;
            this.buttonProvar.Click += new System.EventHandler(this.buttonProvar_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(27, 519);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 62;
            this.dataGridViewPersonajes.RowTemplate.Height = 28;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(1071, 328);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(573, 430);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(147, 66);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel de poder";
            // 
            // numericUpDownNiveldepoder
            // 
            this.numericUpDownNiveldepoder.Location = new System.Drawing.Point(280, 229);
            this.numericUpDownNiveldepoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownNiveldepoder.Name = "numericUpDownNiveldepoder";
            this.numericUpDownNiveldepoder.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownNiveldepoder.TabIndex = 7;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(280, 127);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(294, 26);
            this.textBoxRaza.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(280, 75);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(294, 26);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(280, 32);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(294, 26);
            this.textBoxid.TabIndex = 10;
            this.textBoxid.Leave += new System.EventHandler(this.textBoxid_Leave);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(639, 273);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(98, 45);
            this.buttoninsertar.TabIndex = 11;
            this.buttoninsertar.Text = "Crear";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(280, 177);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRaza.TabIndex = 12;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(639, 16);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(98, 43);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Creacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Historia";
            // 
            // dateTimePickerFechadecreacion
            // 
            this.dateTimePickerFechadecreacion.Location = new System.Drawing.Point(280, 291);
            this.dateTimePickerFechadecreacion.Name = "dateTimePickerFechadecreacion";
            this.dateTimePickerFechadecreacion.Size = new System.Drawing.Size(294, 26);
            this.dateTimePickerFechadecreacion.TabIndex = 16;
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(280, 357);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(475, 26);
            this.textBoxHistoria.TabIndex = 17;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(114, 430);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(143, 66);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(350, 430);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(149, 66);
            this.buttonActualizar.TabIndex = 19;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(639, 103);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(98, 50);
            this.buttonLimpiar.TabIndex = 20;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 859);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.dateTimePickerFechadecreacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.numericUpDownNiveldepoder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonProvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNiveldepoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProvar;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNiveldepoder;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechadecreacion;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

