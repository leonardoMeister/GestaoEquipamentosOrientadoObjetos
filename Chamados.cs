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
        private int id_chamado;
        private static int id;
        private static void GerarId()
        {
            id++;
        }
        public override string ToString()
        {
            return $"\nTitulo Chamado: {Titulo}\nDescrição do chamado: {descricao}\nData de Abertura: {dataAbertura}\nEquipamento do Chamado: {equipamento.Nome}\nDias Em Aberto: {DiasEmAberto()}\n";
        }
        public int Id_chamado
        {
            get
            {
                return id_chamado;
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
        public string Titulo { get => titulo; set => titulo = value; }
        public Chamados(string titulo, string descricao, DateTime dataAbertura, Equipamentos equipamento)
        {
            this.Titulo = titulo;
            this.descricao = descricao;
            this.dataAbertura = dataAbertura;
            this.equipamento = equipamento;
            this.dataAtualizacao = dataAbertura;
            id_chamado = id;
            GerarId();
        }
        public int DiasEmAberto()
        {
            DateTime dataAtual = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            return (int)dataAtual.Subtract(dataAbertura).TotalDays;        
        }
    }
}
