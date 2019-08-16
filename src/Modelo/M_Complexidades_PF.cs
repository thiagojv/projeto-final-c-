using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Complexidades_PF : Ancestral
    {
        private int intAtributo;
        private int intCodigo;
        private decimal dcmlParametro1Min;
        private decimal dcmlParametro1Max;
        private decimal dcmlParametro2Min;
        private decimal dcmlParametro2Max;
        private decimal dcmlParametro3Min;
        private decimal dcmlParametro3Max;
        private decimal dcmlParametro4Min;
        private decimal dcmlParametro4Max;
        private string strngNivel;
        private decimal dcmlPeso;

        public int Atributo
        {
            get { return intAtributo; }
            set { intAtributo = value; }
        }

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public decimal Parametro1Min
        {
            get { return dcmlParametro1Min; }
            set { dcmlParametro1Min = value; }
        }

        public decimal Parametro1Max
        {
            get { return dcmlParametro1Max; }
            set { dcmlParametro1Max = value; }
        }

        public decimal Parametro2Min
        {
            get { return dcmlParametro2Min; }
            set { dcmlParametro2Min = value; }
        }

        public decimal Parametro2Max
        {
            get { return dcmlParametro2Max; }
            set { dcmlParametro2Max = value; }
        }

        public decimal Parametro3Min
        {
            get { return dcmlParametro3Min; }
            set { dcmlParametro3Min = value; }
        }

        public decimal Parametro3Max
        {
            get { return dcmlParametro3Max; }
            set { dcmlParametro3Max = value; }
        }

        public decimal Parametro4Min
        {
            get { return dcmlParametro4Min; }
            set { dcmlParametro4Min = value; }
        }

        public decimal Parametro4Max
        {
            get { return dcmlParametro4Max; }
            set { dcmlParametro4Max = value; }
        }

        public string Nivel
        {
            get { return strngNivel; }
            set { strngNivel = value; }
        }

        public decimal Peso
        {
            get { return dcmlPeso; }
            set { dcmlPeso = value; }
        }
    }
}
