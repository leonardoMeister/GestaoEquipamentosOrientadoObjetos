using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Equipamentos
    {

        private float preco;
        private string nome;
        private int serie;
        private string fabricante;
        private int id;
        private DateTime dataFabricacao;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public DateTime DataFabricacao
        {
            get
            {
                return dataFabricacao;
            }
        }

        public float Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Serie { get => serie; set => serie = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }

        public Equipamentos(float preco, string nome, int serie, DateTime data, string fabricante)
        {
            this.Preco = preco;
            this.Nome = nome;
            this.Serie = serie;
            this.dataFabricacao = data;
            this.Fabricante = fabricante;
        }

    }
}
