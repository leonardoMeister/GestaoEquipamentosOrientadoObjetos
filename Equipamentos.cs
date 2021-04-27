using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Equipamentos
    {

        private decimal preco;
        private string nome;
        private int serie;
        private string fabricante;
        private int id_equipamento;
        private DateTime dataFabricacao;

        private static int id;
        
        

        public override string ToString()
        {
            return $"Nome: {nome}\nSerie: {serie}\nFabricante: {fabricante}\nPreço: {preco}\nData Fabricação: {dataFabricacao}\nId Equipamento: {id_equipamento}\n";
        }

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

        public decimal Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Serie { get => serie; set => serie = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }

        public Equipamentos(decimal preco, string nome, int serie, DateTime data, string fabricante)
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
