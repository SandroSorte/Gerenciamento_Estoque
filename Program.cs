using static System.Console;
using Veiculos;

namespace Gerenciamento
{
    class Program
    {
        static int Menu()
        {
            Clear();
            WriteLine("");
            WriteLine("------------ Gerenciamento de Stock ------------");
            WriteLine("");
            WriteLine("OPÇAO |   CONSULTA   ");
            WriteLine("");
            WriteLine("  1   -    Carros    ");
            WriteLine("");
            WriteLine("  2   -    Motos     ");
            WriteLine("");
            WriteLine("  3   -    Sair      ");
            WriteLine("");
            Write("Digite a opção: ");
            int opcao = int.Parse(ReadLine());
            return opcao;
        }
        static void Main(string[] args)

        {
            var moto = new Veiculo();
            int opcao = Menu();

            switch (opcao)
            {
                case 1:
                case 2:
                    WriteLine("");
                    WriteLine("MOTOS DISPONÍVEIS:");
                    moto.ConsultarMoto();
                    WriteLine("");
                    break;
                case 3:
                    break;
            }

        }

    }
}

