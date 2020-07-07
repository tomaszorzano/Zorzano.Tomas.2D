using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinLogic
{
    public class Aula
    {
        #region Atributos
        private int idaula;
        private string salita;
        #endregion

        #region Propiedades
        public string Salita
        {
            get { return this.salita; }
            set { this.salita = value; }
        }

        public int IdAula
        {
            get { return this.idaula; }
            set { this.idaula = value; }
        }
        #endregion

        #region Constructores
        public Aula()
        {

        }
        public Aula(int id, string salita)
        {
            this.idaula = id;
            this.salita = salita;
        }
        #endregion

        public override string ToString()
        {
            return this.IdAula + " " + this.Salita;
        }
    }
}
