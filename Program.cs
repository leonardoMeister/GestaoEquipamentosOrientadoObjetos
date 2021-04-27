using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Program
    {
        TratamentoDados tratador = new TratamentoDados();
        GerenciadorLista lista = new GerenciadorLista();
        public Program()
        {

            while (true)
            {

                {           
             /* [1] Adicionar Equipamento
                [2] Remover Equipamento
                [3] Mostrar Equipamentos
                [4] Visualizar um Equipamento
                [5] Editar Equipamento
                [6] Adicionar Chamado
                [7] Remover Chamado
                [8] Mostrar Chamados
                [9] Editar Chamado
                [10] Sair*/
                }       //Descrição

                string nome = "";
                int id= 0;
                Equipamentos aux;
                switch (Menu.MenuOpcoes())
                {
                    case 1:
                        lista.AdicionarEquipamento(tratador.PegarDadosEquipamento());
                        break;
                    case 2:
                        
                        tratador.PegarNomeIdEquipamento(out nome, out id);
                        lista.RemoverEquipamento(nome,id);
                        break;
                    case 3:
                        lista.MostrarEquipamentos();
                        break;
                    case 4:
                        tratador.PegarNomeIdEquipamento(out nome, out id);
                         aux = lista.SelecionarEquipamento(nome,id);
                        Console.WriteLine(aux.ToString());
                        break;
                    case 5:

                        tratador.PegarNomeIdEquipamento(out nome, out id);
                        aux = lista.SelecionarEquipamento(nome, id);
                        tratador.AlterarValorEquipamento(ref aux);
                        


                        break;
                    case 6:
                        tratador.PegarNomeIdEquipamento(out nome, out id);
                        aux = lista.SelecionarEquipamento(nome, id);
                        if (aux != null)
                        {
                            lista.AdicionarChamado(tratador.PegarDadosChamados(aux));
                        }
                        else Console.WriteLine("Equipamento Não encontrado!");
                        
                        break;
                    case 7:
                        tratador.PegarNomeIdChamado(out nome, out id);
                        lista.RemoverChamado(nome,id);
                        break;
                    case 8:
                        lista.MostrarChamados();
                        break;
                    case 9:
                        



                        break;
                    case 10:
                        Console.WriteLine(9);
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
