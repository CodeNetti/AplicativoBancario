using Aplicativo_Bancario;

internal class Program
{
 
    private static void Main()
    {
        string opcao_selecionda;
        double valor;
        double saldo;
        bool encerrar;
        Console.WriteLine("Digite o seu saldo");
        saldo = Convert.ToDouble(Console.ReadLine());

        encerrar = false;
        
        Operacoes metodo = new Operacoes();
       

        while(encerrar == false)
        {

           opcao_selecionda = metodo.mostrarMenu();   
            if(opcao_selecionda == "a")
            {
                Console.WriteLine(saldo);
            }
            else if(opcao_selecionda=="b")
            {
                Console.WriteLine("Digite o valor a depositar");
                valor = Convert.ToDouble(Console.ReadLine());
                saldo = valor + saldo;
                Console.WriteLine("valor depositado");
            }
            else if (opcao_selecionda == "c")
            {
                Console.WriteLine("Digite o valor a ser sacado");
                valor = Convert.ToDouble(Console.ReadLine());
                if(valor > saldo)
                {
                    Console.WriteLine("Saldo insuficiente)");

                }
                else
                {
                    saldo = saldo - valor;
                    Console.WriteLine("Saque realizado");
                }
            }
            else if(opcao_selecionda == "d")
            {
                encerrar = true;
            }
            else
            {
                Console.Write("Digite a,b,c ou d");
            }
            

        }


    }
   

   
}