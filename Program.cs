using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Program
    {
        public Program()
        {
            TratamentoDados tratador = new TratamentoDados();



            GerenciadorLista lista = new GerenciadorLista();
            
            Equipamentos novo1 = new Equipamentos(200,"leo", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo2 = new Equipamentos(200, "veronica", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo3 = new Equipamentos(200, "clemir", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo4 = new Equipamentos(200, "joao", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            lista.AdicionarEquipamento(novo1);
            lista.AdicionarEquipamento(novo2);
            lista.AdicionarEquipamento(novo3);
            lista.AdicionarEquipamento(novo4);


            Equipamentos aux = lista.SelecionarEquipamento("leo", 0);

            lista.RemoverEquipamento("leo",0);
            lista.SelecionarEquipamento("leo", 0);


            Chamados chama = new Chamados("Tela Iphone", "Minha téla quebrou", Convert.ToDateTime( "20-03-2001"), novo1);

            lista.MostrarEquipamentos();            

            Console.Read();


            

            lista.MostrarEquipamentos();
        }

        static void Main(string[] args)
        {
            new Program();
            
        }
    }
}
