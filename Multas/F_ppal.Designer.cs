
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
            this.lb_conductores = new System.Windows.Forms.ListBox();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_cargar_archivo = new System.Windows.Forms.Button();
            this.b_crear = new System.Windows.Forms.Button();
            this.tb_edad = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.cb_tipo_id = new System.Windows.Forms.ComboBox();
            this.tb_nro_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_menor = new System.Windows.Forms.Button();
            this.b_mayor = new System.Windows.Forms.Button();
            this.cb_mayor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_menor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.Label();
            this.cb_ano = new System.Windows.Forms.ComboBox();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.tb_acom_menores = new System.Windows.Forms.TextBox();
            this.tb_acomu_mayores = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_multas = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
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
            // b_cargar_archivo
            // 
            this.b_cargar_archivo.Location = new System.Drawing.Point(131, 245);
            this.b_cargar_archivo.Name = "b_cargar_archivo";
            this.b_cargar_archivo.Size = new System.Drawing.Size(97, 22);
            this.b_cargar_archivo.TabIndex = 3;
            this.b_cargar_archivo.Text = "Cargar Archivo";
            this.b_cargar_archivo.UseVisualStyleBackColor = true;
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
            // tb_edad
            // 
            this.tb_edad.Location = new System.Drawing.Point(8, 202);
            this.tb_edad.Name = "tb_edad";
            this.tb_edad.Size = new System.Drawing.Size(29, 20);
            this.tb_edad.TabIndex = 1;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(8, 151);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(220, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // cb_tipo_id
            // 
            this.cb_tipo_id.FormattingEnabled = true;
            this.cb_tipo_id.Location = new System.Drawing.Point(9, 42);
            this.cb_tipo_id.Name = "cb_tipo_id";
            this.cb_tipo_id.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_id.TabIndex = 1;
            // 
            // tb_nro_id
            // 
            this.tb_nro_id.Location = new System.Drawing.Point(8, 97);
            this.tb_nro_id.Name = "tb_nro_id";
            this.tb_nro_id.Size = new System.Drawing.Size(88, 20);
            this.tb_nro_id.TabIndex = 1;
            this.tb_nro_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre completo";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Identificación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_menor);
            this.groupBox2.Controls.Add(this.b_mayor);
            this.groupBox2.Controls.Add(this.cb_mayor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_menor);
            this.groupBox2.Location = new System.Drawing.Point(279, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infracciones";
            // 
            // b_menor
            // 
            this.b_menor.Location = new System.Drawing.Point(57, 68);
            this.b_menor.Name = "b_menor";
            this.b_menor.Size = new System.Drawing.Size(153, 23);
            this.b_menor.TabIndex = 5;
            this.b_menor.Text = "Imponer Infraccón Menor";
            this.b_menor.UseVisualStyleBackColor = true;
            this.b_menor.Click += new System.EventHandler(this.b_menor_Click);
            // 
            // b_mayor
            // 
            this.b_mayor.Location = new System.Drawing.Point(57, 145);
            this.b_mayor.Name = "b_mayor";
            this.b_mayor.Size = new System.Drawing.Size(153, 23);
            this.b_mayor.TabIndex = 4;
            this.b_mayor.Text = "Imponer Infracción Mayor";
            this.b_mayor.UseVisualStyleBackColor = true;
            // 
            // cb_mayor
            // 
            this.cb_mayor.FormattingEnabled = true;
            this.cb_mayor.Location = new System.Drawing.Point(6, 118);
            this.cb_mayor.Name = "cb_mayor";
            this.cb_mayor.Size = new System.Drawing.Size(244, 21);
            this.cb_mayor.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lista de infracciones mayores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lista de infracciones menores";
            // 
            // cb_menor
            // 
            this.cb_menor.FormattingEnabled = true;
            this.cb_menor.Location = new System.Drawing.Point(6, 41);
            this.cb_menor.Name = "cb_menor";
            this.cb_menor.Size = new System.Drawing.Size(244, 21);
            this.cb_menor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_placa);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.marca);
            this.groupBox3.Controls.Add(this.cb_ano);
            this.groupBox3.Controls.Add(this.cb_modelo);
            this.groupBox3.Controls.Add(this.cb_marca);
            this.groupBox3.Location = new System.Drawing.Point(279, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehículo";
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(6, 176);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(100, 20);
            this.tb_placa.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Placa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Modelo";
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(6, 16);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(37, 13);
            this.marca.TabIndex = 4;
            this.marca.Text = "Marca";
            // 
            // cb_ano
            // 
            this.cb_ano.FormattingEnabled = true;
            this.cb_ano.Location = new System.Drawing.Point(6, 124);
            this.cb_ano.Name = "cb_ano";
            this.cb_ano.Size = new System.Drawing.Size(68, 21);
            this.cb_ano.TabIndex = 2;
            // 
            // cb_modelo
            // 
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(6, 79);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(184, 21);
            this.cb_modelo.TabIndex = 1;
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(6, 32);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(210, 21);
            this.cb_marca.TabIndex = 0;
            this.cb_marca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_acom_menores
            // 
            this.tb_acom_menores.Location = new System.Drawing.Point(587, 299);
            this.tb_acom_menores.Name = "tb_acom_menores";
            this.tb_acom_menores.ReadOnly = true;
            this.tb_acom_menores.Size = new System.Drawing.Size(217, 20);
            this.tb_acom_menores.TabIndex = 3;
            // 
            // tb_acomu_mayores
            // 
            this.tb_acomu_mayores.Location = new System.Drawing.Point(587, 376);
            this.tb_acomu_mayores.Name = "tb_acomu_mayores";
            this.tb_acomu_mayores.ReadOnly = true;
            this.tb_acomu_mayores.Size = new System.Drawing.Size(217, 20);
            this.tb_acomu_mayores.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(584, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Acomulado Multas Mayores";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(584, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Acomulado Multas Menores";
            // 
            // lb_multas
            // 
            this.lb_multas.FormattingEnabled = true;
            this.lb_multas.Location = new System.Drawing.Point(587, 44);
            this.lb_multas.Name = "lb_multas";
            this.lb_multas.Size = new System.Drawing.Size(217, 212);
            this.lb_multas.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Lista Multas";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(Bibl_Multas.Clases.Vehiculo);
            // 
            // F_ppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 448);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_multas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_acomu_mayores);
            this.Controls.Add(this.tb_acom_menores);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "F_ppal";
            this.Text = "Oficina de Tránsito de Springfield";
            this.Load += new System.EventHandler(this.F_ppal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_menor;
        private System.Windows.Forms.Button b_mayor;
        private System.Windows.Forms.ComboBox cb_mayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_menor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.TextBox tb_placa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.ComboBox cb_ano;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.TextBox tb_acom_menores;
        private System.Windows.Forms.TextBox tb_acomu_mayores;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lb_multas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
    }
}

