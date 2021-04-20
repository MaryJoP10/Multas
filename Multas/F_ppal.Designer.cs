
namespace Multas
{
    partial class F_ppal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nro_id = new System.Windows.Forms.TextBox();
            this.cb_tipo_id = new System.Windows.Forms.ComboBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_edad = new System.Windows.Forms.TextBox();
            this.b_crear = new System.Windows.Forms.Button();
            this.b_cargar_archivo = new System.Windows.Forms.Button();
            this.lb_conductores = new System.Windows.Forms.ListBox();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_conductores);
            this.groupBox1.Controls.Add(this.b_cargar_archivo);
            this.groupBox1.Controls.Add(this.b_crear);
            this.groupBox1.Controls.Add(this.tb_edad);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.cb_tipo_id);
            this.groupBox1.Controls.Add(this.tb_nro_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conductores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Edad";
            // 
            // tb_nro_id
            // 
            this.tb_nro_id.Location = new System.Drawing.Point(8, 97);
            this.tb_nro_id.Name = "tb_nro_id";
            this.tb_nro_id.Size = new System.Drawing.Size(100, 20);
            this.tb_nro_id.TabIndex = 1;
            this.tb_nro_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_tipo_id
            // 
            this.cb_tipo_id.FormattingEnabled = true;
            this.cb_tipo_id.Location = new System.Drawing.Point(9, 42);
            this.cb_tipo_id.Name = "cb_tipo_id";
            this.cb_tipo_id.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_id.TabIndex = 1;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(8, 151);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(174, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // tb_edad
            // 
            this.tb_edad.Location = new System.Drawing.Point(8, 202);
            this.tb_edad.Name = "tb_edad";
            this.tb_edad.Size = new System.Drawing.Size(100, 20);
            this.tb_edad.TabIndex = 1;
            // 
            // b_crear
            // 
            this.b_crear.Location = new System.Drawing.Point(6, 244);
            this.b_crear.Name = "b_crear";
            this.b_crear.Size = new System.Drawing.Size(75, 23);
            this.b_crear.TabIndex = 1;
            this.b_crear.Text = "Crear";
            this.b_crear.UseVisualStyleBackColor = true;
            this.b_crear.Click += new System.EventHandler(this.b_crear_Click);
            // 
            // b_cargar_archivo
            // 
            this.b_cargar_archivo.Location = new System.Drawing.Point(131, 245);
            this.b_cargar_archivo.Name = "b_cargar_archivo";
            this.b_cargar_archivo.Size = new System.Drawing.Size(97, 22);
            this.b_cargar_archivo.TabIndex = 3;
            this.b_cargar_archivo.Text = "Cargar Archivo";
            this.b_cargar_archivo.UseVisualStyleBackColor = true;
            // 
            // lb_conductores
            // 
            this.lb_conductores.DataSource = this.conductorBindingSource;
            this.lb_conductores.FormattingEnabled = true;
            this.lb_conductores.Location = new System.Drawing.Point(9, 279);
            this.lb_conductores.Name = "lb_conductores";
            this.lb_conductores.Size = new System.Drawing.Size(219, 134);
            this.lb_conductores.TabIndex = 1;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataSource = typeof(Bibl_Multas.Clases.Conductor);
            // 
            // F_ppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "F_ppal";
            this.Text = "Oficina de Tránsito de Springfield";
            this.Load += new System.EventHandler(this.F_ppal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nro_id;
        private System.Windows.Forms.Button b_cargar_archivo;
        private System.Windows.Forms.Button b_crear;
        private System.Windows.Forms.TextBox tb_edad;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.ComboBox cb_tipo_id;
        private System.Windows.Forms.ListBox lb_conductores;
        private System.Windows.Forms.BindingSource conductorBindingSource;
    }
}

