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
        private int id_equipamento;
        private DateTime dataFabricacao;

        private static int id;

        private static void GerarId()
        {
            id++;
        }

        public int Id_equipamento
        {
            get
            {
                return id_equipamento;
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
            id_equipamento = id;
            GerarId();
        }

    }
}
