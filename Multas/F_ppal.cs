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
        enum l_marcas { Renault, Chevrolet, Nissan}
        enum l_mod_ren {  Duster, Sandero, Alaskan, Logan}
        enum l_mod_che { Onix, Beat, Aveo, Captiva }
        enum l_mod_nis { March, Xtrail, Pathfinder}
        Transito Springfield = new Transito("Calle 25", 3183365574);
        Vehiculo veh_ppal;

        public F_ppal()
        {
            InitializeComponent();
            cb_tipo_id.DataSource = Enum.GetValues(typeof(Conductor.l_tipo_id));
            cb_marca.DataSource = Enum.GetValues(typeof(l_marcas));
            List<short> l_anos = new List<short>();
            for(short i =1930; i<= DateTime.Today.Year+1; i++)
            {
                l_anos.Add(i);
            }
            cb_ano.DataSource = l_anos;
            cb_ano.Text = DateTime.Today.Year.ToString();
            cb_mayor.DataSource = Enum.GetValues(typeof(Mayor.lista_mayores));
            cb_menor.DataSource = Enum.GetValues(typeof(Menor.lista_menores));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch((l_marcas)Enum.Parse(typeof(l_marcas), cb_marca.SelectedItem.ToString()))
                {
                    case l_marcas.Renault:
                        cb_modelo.DataSource = Enum.GetValues(typeof(l_mod_ren));
                        break;
                    case l_marcas.Chevrolet:
                        cb_modelo.DataSource = Enum.GetValues(typeof(l_mod_che));
                        break;
                    case l_marcas.Nissan:
                        cb_modelo.DataSource = Enum.GetValues(typeof(l_mod_nis));
                        break;
                    default:
                        break;
                }
            }
             catch (Exception error)
            {
                MessageBox.Show("Error al cambiar el dato de marca  " + error);
            }
        }

        private void b_menor_Click(object sender, EventArgs e)
        {
            try
            {
                //crear vehiculo
                veh_ppal = new Vehiculo(tb_placa.Text, cb_marca.Text, cb_modelo.Text, new DateTime(int.Parse(cb_ano.Text), 1, 1));
                Menor nueva_multa = new Menor((Conductor)lb_conductores.SelectedItem, veh_ppal, (Menor.lista_menores)Enum.Parse(typeof(Menor.lista_menores), cb_menor.Text), Springfield.Val_sal_min);
                Springfield.L_multas.Add(nueva_multa);
                //Llevar lista de multas a control
                lb_multas.DataSource = null;
                lb_multas.DataSource = Springfield.L_multas;
                //modificar tb de los totales de las multas
                Presentar_Acomulados();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al imponer multa menor  " + error);
            }
        }
        private void b_mayor_Click(object sender, EventArgs e)
        {
            try
            {
                //crear vehiculo
                veh_ppal = new Vehiculo(tb_placa.Text, cb_marca.Text, cb_modelo.Text, new DateTime(int.Parse(cb_ano.Text), 1, 1));
                Mayor nueva_multa = new Mayor((Conductor)lb_conductores.SelectedItem, veh_ppal, (Mayor.lista_mayores)Enum.Parse(typeof(Mayor.lista_mayores), cb_mayor.Text), Springfield.Val_sal_min);
                Springfield.L_multas.Add(nueva_multa);
                //Llevar lista de multas a control
                lb_multas.DataSource = null;
                lb_multas.DataSource = Springfield.L_multas;
                //modificar tb de los totales de las multas
                Presentar_Acomulados();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al imponer multa mayor  " + error);
            }
        }
        internal void Presentar_Acomulados()
        {
            try
            {
                tb_acom_mayores.Text = Springfield.Totalizar_multas()[0].ToString();
                tb_acom_menores.Text = Springfield.Totalizar_multas()[1].ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show("\nError presentando acomulados \n" + error);
            }
        }
    }
}
