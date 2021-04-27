using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class TratamentoDados
    {
        /*         
        float preco;
        string nome;
        int serie;
        string fabricante;
        DateTime dataFabricacao;  
         */
        /*
         string titulo
         string descricao
         Equipamentos equipamento
         DateTime dataAbertura
         */


        public void AlterarValorChamada(ref Chamados chama)
        {

        }

        public void AlterarValorEquipamento( ref Equipamentos equip)
        {
            Console.WriteLine("Informe o Nome do Equipamento: ");
            equip.Nome = PegarValor();
            Console.WriteLine("Informe o Preço Do Equipamento: ");
            equip.Preco = Convert.ToDecimal(PegarValor());
            Console.WriteLine("Insira o Nº série: ");
            equip.Serie = PegarNumero();
            return;
        }

        public Chamados PegarDadosChamados( Equipamentos equipamento)
        {
            while (true)
            {
                string titulo;
                string descricao;
                DateTime dataAbertura;
                try
                {
                    Console.WriteLine("Informe o Titulo do Chamado: ");
                    titulo = PegarValor();
                    Console.WriteLine("Informe a descrição do Chamado: ");
                    descricao = PegarValor();
                    Console.WriteLine("Informe a data de Abertura do Chamado: ");
                    dataAbertura = Convert.ToDateTime(PegarValor());
                    Chamados chamado = new Chamados(titulo,descricao,dataAbertura,equipamento);
                    return chamado;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro Valor Invalido.\nTente Novamente!");
                    Console.ReadLine();
                    Console.Clear();
                    return null;
                }
            }
        }
        public Equipamentos PegarDadosEquipamento()
        {
            while (true)
            {
                decimal preco;
                string nome;
                int serie;
                string fabricante;
                DateTime dataFabricacao;
                try
                {
                    Console.WriteLine("Informe o Nome do Equipamento: ");
                    nome = PegarValor();
                    if (nome.Length < 6)
                    {
                        Console.WriteLine("Nome Curto de mais.\nTente Novamente!");
                        Console.ReadLine();
                        Console.Clear();
                        return null;
                    }
                    Console.WriteLine("Informe o Preço Do Equipamento: ");
                    preco = Convert.ToDecimal(PegarValor());
                    Console.WriteLine("Insira o Nº série: ");
                    serie = PegarNumero();
                    Console.WriteLine("Informe o Fabricante: ");
                    fabricante = PegarValor();
                    Console.WriteLine("Informe a Data de Fabricação, [Ano-Mês-Dia]: ");
                    dataFabricacao = Convert.ToDateTime(PegarValor());
                    Equipamentos equipamento = new Equipamentos(preco, nome, serie, dataFabricacao, fabricante);
                    return equipamento;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro Valor Invalido.\nTente Novamente!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public void PegarNomeIdChamado(out string titulo, out int id)
        {
            Console.WriteLine("Informe o titulo do Chamado: ");
            titulo = PegarValor();
            Console.WriteLine("Informe o Id do Chamado: ");
            id = PegarNumero();
        }
        public void PegarNomeIdEquipamento(out string nome, out int id)
        {
            Console.WriteLine("Informe o Nome do Equipamento: ");
            nome = PegarValor();
            Console.WriteLine("Informe o Id do Equipamento: ");
            id = PegarNumero();
        }
        private int PegarNumero()
        {
            try
            {
                return Convert.ToInt32(PegarValor());
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Inválido, Tente Novamente!");
                PegarNumero();
                return 0;
            }           
        }
        private String PegarValor()
        {
            return Console.ReadLine();
        }
    }
}
