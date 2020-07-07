using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JardinLogic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using JardinLogic.Persistencia_de_Datos;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Alumno alumno = new Alumno(20, "Test", "Unitario", 39911687, 23, "Av siempre viva 123", "Sergio Aguero");
            
            Directory.CreateDirectory((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest"));
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest", String.Format(@"TestXML.XML"));
            Serializador<Alumno>.SerializarAXml(alumno, ruta);
            bool rutaxml = File.Exists((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest\TestXML.xml"));
            
            Assert.IsTrue(rutaxml);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Alumno alumno = new Alumno(20, "Test", "Unitario", 39911687, 23, "Av siempre viva 123", "Sergio Aguero");

            Directory.CreateDirectory((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest"));
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest", String.Format(@"TestBIN.bin"));
            Serializador<Alumno>.SerializarABinario(alumno, ruta);
            bool rutabin = File.Exists((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest\TestBIN.bin"));
            Assert.IsTrue(rutabin);
        }
    }
}
