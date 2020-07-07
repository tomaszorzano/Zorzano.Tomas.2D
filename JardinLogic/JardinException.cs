using JardinLogic.Interfaz;
using JardinLogic.Persistencia_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinLogic
{
   public class JardinException: Exception, IArchivoTexto
    {
        public JardinException(string message, Exception innerExcepcion) : base(message, innerExcepcion)
        {
            ArchivoTexto.Escribir(this, true);
        }
        public JardinException(string message) : base(message)
        {
            ArchivoTexto.Escribir(this, true);
        }
        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ":");
                sb.AppendLine(this.Message);
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                return sb.ToString();
            }
        }

        public string Ruta
        {
            get
            {
                return String.Format("{0}log.txt", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn");
            }
        }

    }
}
