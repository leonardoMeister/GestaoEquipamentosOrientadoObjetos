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

            Equipamentos novo1 = new Equipamentos(200,"aphone", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo2 = new Equipamentos(200, "aphone", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo3 = new Equipamentos(200, "aphone", 300, Convert.ToDateTime("2002-03-20"), "lenovo");
            Equipamentos novo4 = new Equipamentos(200, "aphone", 300, Convert.ToDateTime("2002-03-20"), "lenovo");



        }

        static void Main(string[] args)
        {
            new Program();
            
        }
    }
}
