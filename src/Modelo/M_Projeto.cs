using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto : Ancestral
    {
        private int intCodigo;
        private string strngNome;
        private DateTime dtmData_Inicio;
        private DateTime dtmData_Termino;
        private int intModelo;
        private int intTipo_Fundamental;
        private bool blStatus;

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public string Nome
        {
            get { return strngNome; }
            set { strngNome = value; }
        }

        public DateTime Data_Inicio
        {
            get { return dtmData_Inicio; }
            set { dtmData_Inicio = value; }
        }

        public DateTime Data_Termino
        {
            get { return dtmData_Termino; }
            set { dtmData_Termino = value; }
        }

        public int Modelo
        {
            get { return intModelo; }
            set { intModelo = value; }
        }

        public int Tipo_Fundamental
        {
            get { return intTipo_Fundamental; }
            set { intTipo_Fundamental = value; }
        }

        public bool Status
        {
            get { return blStatus; }
            set { blStatus = value; }
        }
    }
}
