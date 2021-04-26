using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Chamados
    {

        private string titulo;
        private string descricao;
        private Equipamentos equipamento;
        private DateTime dataAbertura;
        private DateTime dataAtualizacao;
        private int id_equipamento;
        
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

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }
        public Equipamentos Equipamento
        {
            get
            {
                return equipamento;
            }
        }
        public DateTime DataAbertura
        {
            get
            {
                return dataAbertura;
            }
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataAtualizacao { get => dataAtualizacao; set => dataAtualizacao = value; }

        public Chamados(string titulo, string descricao, DateTime dataAbertura, Equipamentos equipamento)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataAbertura = dataAbertura;
            this.equipamento = equipamento;
            this.dataAtualizacao = dataAbertura;
            id_equipamento = id;
            GerarId();
        }
    }
}
