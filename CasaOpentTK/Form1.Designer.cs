namespace CasaOpentTK
{
    partial class Form1
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
            this.glControl1 = new OpenTK.GLControl();
            this.comboEscenario = new System.Windows.Forms.ComboBox();
            this.comboObjeto = new System.Windows.Forms.ComboBox();
            this.comboCaras = new System.Windows.Forms.ComboBox();
            this.grBoxTransformaciones = new System.Windows.Forms.GroupBox();
            this.rbEscalacion = new System.Windows.Forms.RadioButton();
            this.rbRotacion = new System.Windows.Forms.RadioButton();
            this.rbTraslacion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXmenos = new System.Windows.Forms.Button();
            this.btnXmas = new System.Windows.Forms.Button();
            this.btnYmas = new System.Windows.Forms.Button();
            this.btnYmenos = new System.Windows.Forms.Button();
            this.btnZmas = new System.Windows.Forms.Button();
            this.btnZmenos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grBoxTransformaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(334, 12);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(742, 563);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            // 
            // comboEscenario
            // 
            this.comboEscenario.FormattingEnabled = true;
            this.comboEscenario.Location = new System.Drawing.Point(18, 38);
            this.comboEscenario.Name = "comboEscenario";
            this.comboEscenario.Size = new System.Drawing.Size(121, 21);
            this.comboEscenario.TabIndex = 4;
            this.comboEscenario.Text = "Seleccionar Escenario";
            this.comboEscenario.SelectedIndexChanged += new System.EventHandler(this.comboEscenario_SelectedIndexChanged);
            // 
            // comboObjeto
            // 
            this.comboObjeto.FormattingEnabled = true;
            this.comboObjeto.Location = new System.Drawing.Point(18, 88);
            this.comboObjeto.Name = "comboObjeto";
            this.comboObjeto.Size = new System.Drawing.Size(121, 21);
            this.comboObjeto.TabIndex = 5;
            this.comboObjeto.Text = "Seleccionar Objeto";
            this.comboObjeto.SelectedIndexChanged += new System.EventHandler(this.comboObjeto_SelectedIndexChanged);
            // 
            // comboCaras
            // 
            this.comboCaras.FormattingEnabled = true;
            this.comboCaras.Location = new System.Drawing.Point(18, 137);
            this.comboCaras.Name = "comboCaras";
            this.comboCaras.Size = new System.Drawing.Size(121, 21);
            this.comboCaras.TabIndex = 6;
            this.comboCaras.Text = "Seleccionar Cara";
            // 
            // grBoxTransformaciones
            // 
            this.grBoxTransformaciones.Controls.Add(this.rbEscalacion);
            this.grBoxTransformaciones.Controls.Add(this.rbRotacion);
            this.grBoxTransformaciones.Controls.Add(this.rbTraslacion);
            this.grBoxTransformaciones.Enabled = false;
            this.grBoxTransformaciones.Location = new System.Drawing.Point(18, 196);
            this.grBoxTransformaciones.Name = "grBoxTransformaciones";
            this.grBoxTransformaciones.Size = new System.Drawing.Size(299, 60);
            this.grBoxTransformaciones.TabIndex = 7;
            this.grBoxTransformaciones.TabStop = false;
            this.grBoxTransformaciones.Text = "Transformaciones";
            // 
            // rbEscalacion
            // 
            this.rbEscalacion.AutoSize = true;
            this.rbEscalacion.Location = new System.Drawing.Point(215, 20);
            this.rbEscalacion.Name = "rbEscalacion";
            this.rbEscalacion.Size = new System.Drawing.Size(77, 17);
            this.rbEscalacion.TabIndex = 2;
            this.rbEscalacion.Text = "Escalacion";
            this.rbEscalacion.UseVisualStyleBackColor = true;
            // 
            // rbRotacion
            // 
            this.rbRotacion.AutoSize = true;
            this.rbRotacion.Location = new System.Drawing.Point(111, 20);
            this.rbRotacion.Name = "rbRotacion";
            this.rbRotacion.Size = new System.Drawing.Size(68, 17);
            this.rbRotacion.TabIndex = 1;
            this.rbRotacion.Text = "Rotacion";
            this.rbRotacion.UseVisualStyleBackColor = true;
            // 
            // rbTraslacion
            // 
            this.rbTraslacion.AutoSize = true;
            this.rbTraslacion.Checked = true;
            this.rbTraslacion.Location = new System.Drawing.Point(7, 20);
            this.rbTraslacion.Name = "rbTraslacion";
            this.rbTraslacion.Size = new System.Drawing.Size(74, 17);
            this.rbTraslacion.TabIndex = 0;
            this.rbTraslacion.TabStop = true;
            this.rbTraslacion.Text = "Traslacion";
            this.rbTraslacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(54, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(230, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(137, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Z";
            // 
            // btnXmenos
            // 
            this.btnXmenos.Enabled = false;
            this.btnXmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmenos.Location = new System.Drawing.Point(25, 308);
            this.btnXmenos.Name = "btnXmenos";
            this.btnXmenos.Size = new System.Drawing.Size(35, 33);
            this.btnXmenos.TabIndex = 11;
            this.btnXmenos.Text = "-";
            this.btnXmenos.UseVisualStyleBackColor = true;
            this.btnXmenos.Click += new System.EventHandler(this.btnXmenos_Click);
            // 
            // btnXmas
            // 
            this.btnXmas.Enabled = false;
            this.btnXmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmas.Location = new System.Drawing.Point(64, 308);
            this.btnXmas.Name = "btnXmas";
            this.btnXmas.Size = new System.Drawing.Size(35, 33);
            this.btnXmas.TabIndex = 12;
            this.btnXmas.Text = "+";
            this.btnXmas.UseVisualStyleBackColor = true;
            this.btnXmas.Click += new System.EventHandler(this.btnXmas_Click);
            // 
            // btnYmas
            // 
            this.btnYmas.Enabled = false;
            this.btnYmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYmas.Location = new System.Drawing.Point(240, 308);
            this.btnYmas.Name = "btnYmas";
            this.btnYmas.Size = new System.Drawing.Size(35, 33);
            this.btnYmas.TabIndex = 14;
            this.btnYmas.Text = "+";
            this.btnYmas.UseVisualStyleBackColor = true;
            this.btnYmas.Click += new System.EventHandler(this.btnYmas_Click);
            // 
            // btnYmenos
            // 
            this.btnYmenos.Enabled = false;
            this.btnYmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYmenos.Location = new System.Drawing.Point(201, 308);
            this.btnYmenos.Name = "btnYmenos";
            this.btnYmenos.Size = new System.Drawing.Size(35, 33);
            this.btnYmenos.TabIndex = 13;
            this.btnYmenos.Text = "-";
            this.btnYmenos.UseVisualStyleBackColor = true;
            this.btnYmenos.Click += new System.EventHandler(this.btnYmenos_Click);
            // 
            // btnZmas
            // 
            this.btnZmas.Enabled = false;
            this.btnZmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZmas.Location = new System.Drawing.Point(150, 390);
            this.btnZmas.Name = "btnZmas";
            this.btnZmas.Size = new System.Drawing.Size(35, 33);
            this.btnZmas.TabIndex = 16;
            this.btnZmas.Text = "+";
            this.btnZmas.UseVisualStyleBackColor = true;
            this.btnZmas.Click += new System.EventHandler(this.btnZmas_Click);
            // 
            // btnZmenos
            // 
            this.btnZmenos.Enabled = false;
            this.btnZmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZmenos.Location = new System.Drawing.Point(111, 390);
            this.btnZmenos.Name = "btnZmenos";
            this.btnZmenos.Size = new System.Drawing.Size(35, 33);
            this.btnZmenos.TabIndex = 15;
            this.btnZmenos.Text = "-";
            this.btnZmenos.UseVisualStyleBackColor = true;
            this.btnZmenos.Click += new System.EventHandler(this.btnZmenos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(235, 541);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(71, 541);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(154, 541);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 587);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnZmas);
            this.Controls.Add(this.btnZmenos);
            this.Controls.Add(this.btnYmas);
            this.Controls.Add(this.btnYmenos);
            this.Controls.Add(this.btnXmas);
            this.Controls.Add(this.btnXmenos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBoxTransformaciones);
            this.Controls.Add(this.comboCaras);
            this.Controls.Add(this.comboObjeto);
            this.Controls.Add(this.comboEscenario);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBoxTransformaciones.ResumeLayout(false);
            this.grBoxTransformaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.ComboBox comboEscenario;
        private System.Windows.Forms.ComboBox comboObjeto;
        private System.Windows.Forms.ComboBox comboCaras;
        private System.Windows.Forms.GroupBox grBoxTransformaciones;
        private System.Windows.Forms.RadioButton rbEscalacion;
        private System.Windows.Forms.RadioButton rbRotacion;
        private System.Windows.Forms.RadioButton rbTraslacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXmenos;
        private System.Windows.Forms.Button btnXmas;
        private System.Windows.Forms.Button btnYmas;
        private System.Windows.Forms.Button btnYmenos;
        private System.Windows.Forms.Button btnZmas;
        private System.Windows.Forms.Button btnZmenos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEliminar;
    }
}