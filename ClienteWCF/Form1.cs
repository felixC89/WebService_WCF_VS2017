using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string identificador = tbidentificacion.Text;

            using (WSPersonas.WSPersonasClient cliente = new WSPersonas.WSPersonasClient())
            {
                var persona = cliente.ObtenerPersona(identificador);

                if (!persona.Error)
                {
                    MessageBox.Show(string.Format(@"Nombre:{0}, Edad:{1}", persona.Nombre, persona.Edad));
                }
                else
                {
                    MessageBox.Show(string.Format(@"Error:{0}", persona.MensajeRespuesta));
                }
            }
        }
    }
}
