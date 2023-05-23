using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Bancario
{
    internal class Operacoes
    {
         

        public string mostrarMenu()
        {
            string selecionada;
            Console.WriteLine("Menu de operação");
            Console.WriteLine("[a] Mostrar saldo");
            Console.WriteLine("[b] Efetuar Deposito");
            Console.WriteLine("[c] Efetuar Saque");
            Console.WriteLine("[d]Finalizar");
            selecionada = Console.ReadLine();
            return selecionada;

        }
    }
}
