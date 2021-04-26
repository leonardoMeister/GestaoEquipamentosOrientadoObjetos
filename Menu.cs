using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class Menu
    {
        public static int MenuOpcoes()
        {

            Console.WriteLine("Opções do Menu: ");
            Console.WriteLine("[1] Adicionar Equipamento");
            Console.WriteLine("[2] Remover Equipamento");
            Console.WriteLine("[3] Mostrar Equipamentos");
            Console.WriteLine("[4] Visualizar um Equipamento");
            Console.WriteLine("[5] Editar Equipamento");
            Console.WriteLine("[6] Adicionar Chamado");
            Console.WriteLine("[7] Remover Chamado");
            Console.WriteLine("[8] Mostrar Chamados");
            Console.WriteLine("[9] Editar Chamado");
            //int aux = opcaoMenu();
            return  2;
        }

       /* private static int opcaoMenu()
        {
            try
            return 1;
        }
       */
    }
}
