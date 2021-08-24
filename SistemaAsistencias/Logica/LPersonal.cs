using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias.Logica
{
    public class LPersonal
    {
        #region Atributos
        private int idPersonal;
        private string nombres;
        private string identificacion;
        private string pais;
        private int idCargo;
        private double sueldoPorHora;
        private string estado;
        private string codigo;

        #endregion

        #region Propiedades
        public int IdPersonal { get { return this.idPersonal; } set { this.idPersonal = value; } }
        public string Nombres { get { return this.nombres; } set { this.nombres = value; } }
        public string Identificacion { get { return this.identificacion; } set { this.identificacion = value; } }
        public string Pais { get { return this.pais; } set { this.pais = value; } }
        public int IdCargo { get { return this.idCargo; } set { this.idCargo = value; } }
        public double SueldoPorHora { get { return this.sueldoPorHora; } set { this.sueldoPorHora = value; } }
        public string Estado { get { return this.estado; } set { this.estado = value; } }
        public string Codigo { get { return this.codigo; } set { this.codigo = value; } }
        #endregion


    }
}
