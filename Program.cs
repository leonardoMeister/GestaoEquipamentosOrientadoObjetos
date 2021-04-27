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
                string nome = "";
                int id= 0;
                Equipamentos auxEquipamentos;
                Chamados auxChamados;
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
                         auxEquipamentos = lista.SelecionarEquipamento(nome,id);
                        if (auxEquipamentos != null)
                        {
                            Console.WriteLine(auxEquipamentos.ToString());
                        }
                        else Console.WriteLine("Equipamento não localizado");
                        break;
                    case 5:
                        tratador.PegarNomeIdEquipamento(out nome, out id);
                        auxEquipamentos = lista.SelecionarEquipamento(nome, id);
                        if (auxEquipamentos!= null)
                        {
                            tratador.AlterarValorEquipamento(ref auxEquipamentos);
                        }
                        break;
                    case 6:
                        tratador.PegarNomeIdEquipamento(out nome, out id);
                        auxEquipamentos = lista.SelecionarEquipamento(nome, id);
                        if (auxEquipamentos != null)
                        {
                            lista.AdicionarChamado(tratador.PegarDadosChamados(auxEquipamentos));
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
                        tratador.PegarNomeIdChamado(out nome, out id);
                        auxChamados = lista.SelecionarChamado(nome,id);
                        if (auxChamados != null)
                        {
                            tratador.AlterarValorChamada(ref auxChamados);
                        }
                        else Console.WriteLine("Chamado Não localizado!");
                        break;
                    case 10:
                        Environment.Exit(0);
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
