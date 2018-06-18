using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        /*nome - 1° e 2°
          familia - 1°
          cor - 1° e 2°
          corAsa
          tamanhoAsa
          asaQuebrada
          é Mulher? - 2°
          fazBarulho?
          Elemento*/

        private string nome;
        private string familia;
        private string Cor;
        private string CorAsa;
        private double tamanho;
        public bool AsaQuebrada { get; set; }
        public bool Sexo { get; set; }
        public bool Barulho { get; set; }
        public string Elemento { get; set; }
        

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Count() < 3 || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve conter pelo menos 3 letras");
                }
                nome = value;

            }
        }
        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                if (value.Count() < 5 || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Família deve conter pelo menos 3 letras");
                }
                familia = value;
            }
        }
        public double Tamanho
        {
            get
            {
                return tamanho;
            }
            set
            {
                if (value < 1 || string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    throw new Exception("Tamanho inválido");
                }
                tamanho = value;
            }
        }

    }
}
