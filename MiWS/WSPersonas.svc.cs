using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string identificacion)
        {
            if (identificacion == "0")
            {
                return new Persona { Nombre = "Felix", Edad = 31 };
            }
            else if(identificacion=="1")
            {
                return new Persona { Nombre = "Antonio", Edad = 25 };
            }
            else
            {
                return new Persona { Error=true,MensajeRespuesta = "Persona no encontrada!" };
            }
        }
    }

}
