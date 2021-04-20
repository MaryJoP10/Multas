using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibl_Multas.Clases;

namespace Multas
{
    public partial class F_ppal : Form
    {
        List<Conductor> l_conductores = new List<Conductor>();
        public F_ppal()
        {
            InitializeComponent();
            cb_tipo_id.DataSource = Enum.GetValues(typeof(Conductor.l_tipo_id));
        }

        private void F_ppal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_crear_Click(object sender, EventArgs e)
        {
            try
            {
                //validar si el tb_edad tiene un dato válido
                byte edad;

                if (byte.TryParse(tb_edad.Text, out edad))
                {
                    l_conductores.Add (new Conductor((Conductor.l_tipo_id)Enum.Parse(typeof(Conductor.l_tipo_id), cb_tipo_id.Text), tb_nro_id.Text, tb_nombre.Text, edad));

                    //cargar lista mostrar en List Box 
                    lb_conductores.DataSource = null;
                    lb_conductores.DataSource = l_conductores;
                }
                else throw new Exception("Revisar el campo de Edad, hay un error.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error creando el conductor " + error);
            }
        }
    }
}
