using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto_Atributo : Ancestral
    {
        private int intProjeto;
        private int intCodigo;
        private int intAtributo;
        private string strngDescricao;
        private int intComplexidade;
        private double dblQuantidadeParametro1;
        private double dblQuantidadeParametro2;
        private double dblQuantidadeParametro3;
        private double dblQuantidadeParametro4;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public int Atributo
        {
            get { return intAtributo; }
            set { intAtributo = value; }
        }

        public string Descricao
        {
            get { return strngDescricao; }
            set { strngDescricao = value; }
        }

        public int Complexidade
        {
            get { return intComplexidade; }
            set { intComplexidade = value; }
        }

        public double QuantidadeParametro1
        {
            get { return dblQuantidadeParametro1; }
            set { dblQuantidadeParametro1 = value; }
        }

        public double QuantidadeParametro2
        {
            get { return dblQuantidadeParametro2; }
            set { dblQuantidadeParametro2 = value; }
        }

        public double QuantidadeParametro3
        {
            get { return dblQuantidadeParametro3; }
            set { dblQuantidadeParametro3 = value; }
        }

        public double QuantidadeParametro4
        {
            get { return dblQuantidadeParametro4; }
            set { dblQuantidadeParametro4 = value; }
        }
    }
}
