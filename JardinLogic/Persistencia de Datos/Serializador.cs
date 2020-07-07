using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

namespace JardinLogic.Persistencia_de_Datos
{
    public class Serializador<T> where T : class, new()

    {
        static string rutaAprobados = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\APROBADOS");
        static string rutaDesaprobados = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\DESAPROBADOS");
        /// <summary>
        /// Serializa un objeto a formato binario.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="ruta">Ruta donde se creará el archivo de serialización.</param>
        public static void SerializarABinario(T objeto, string ruta)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(ruta, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, objeto);
            }
            catch (Exception ex)
            {
                throw new JardinException("Ocurrió un error al tratar de serializar el archivo a binario.", ex);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        /// <summary>
        /// Serializa un objeto a formato XML.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="ruta">Ruta donde se creará el archivo de serialización.</param>
        public static void SerializarAXml(T objeto, string ruta)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new JardinException("Error: Directorio no encontrado.", ex);
            }
            
            finally
            {
                

                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
        /// <summary>
        /// Deserializa el archivo en la ruta indicada de binario al tipo genérico T.
        /// </summary>
        /// <param name="ruta">Ruta del archivo a deserializar.</param>
        /// <returns></returns>
        public static T DeserializarBinario(string ruta)
        {
            FileStream fileStream = null;
            T objeto = default(T);

            try
            {
                BinaryFormatter reader = new BinaryFormatter();
                fileStream = new FileStream(ruta, FileMode.Open);
                objeto = (T)reader.Deserialize(fileStream);
            }
            catch (Exception ex)
            {
                throw new JardinException("Ocurrió un error al tratar de deserializar el archivo binario.", ex);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return objeto;
        }

        /// <summary>
        /// Deserializa el archivo en la ruta indicada de XML al tipo genérico T.
        /// </summary>
        /// <param name="ruta">Ruta del archivo a deserializar.</param>
        /// <returns></returns>
        public static T DeserializarXml(string ruta)
        {
            XmlTextReader reader = null;
            T objeto = default(T);
            try
            {
                reader = new XmlTextReader(ruta);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new JardinException("Ocurrió un error al tratar de deserializar el archivo XML.", ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return objeto;
        }

    }
}
