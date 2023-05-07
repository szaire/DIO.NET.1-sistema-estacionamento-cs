using Sistema.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        // Entender a proposta do desafio (ok)
        // Modelar o Diagrama de Classes (ok)
        // Modelar o fluxograma do sistema (ok)
        // Criar os pseudocódigos dos métodos (ignored)
        // Implementar em C# (ok)

        short option;
        bool exibirMenu = true;

        Console.WriteLine("Seja bem vindo ao sistema de estacionamento de szaire 😎!");
        Console.Write("[💸] Digite o preço inicial: ");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.Write("[⏰] Digite o preço por hora: ");
        decimal precoHora = Convert.ToDecimal(Console.ReadLine());
        Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);
        PauseAndClearConsole();

        do
        {
            // Menu Interativo
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1[🚗] - Cadastrar veículo");
            Console.WriteLine("2[⛔] - Remover veículo");
            Console.WriteLine("3[📝] - Listar veículo");
            Console.WriteLine("4[❌] - Encerrar");
            option = (short) Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    estacionamento.CadastrarVeiculo();
                    break;
                case 2:
                    estacionamento.RemoverVeiculo();
                    break;
                case 3:
                    estacionamento.ListarVeiculos();
                    break;
                case 4:
                    Console.WriteLine("\nObrigado por utilizar o meu sistema!🥳😄\ncredits: github::szaire\n");
                    exibirMenu = false;
                    break;
                default:
                    Console.WriteLine("🚫Valor informado é inválido!🚫");
                    break;
            }
            PauseAndClearConsole();

        } while (exibirMenu);
    }

    public static void PauseAndClearConsole()
    {
        Console.Write("Pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();        
    }
}

// Coded by github::szaire
// Version: 1.1