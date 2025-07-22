namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }


        static void Menu()
        {
            //Limpar tela sempre que inicia o terminal
            Console.Clear();

            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Selecione uma operação:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar a calculadora!");
                    Environment.Exit(0);
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            //Limpar tela sempre que inicia o terminal
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 + num2;
            Console.WriteLine("Resultado da soma: " + resultado);

            // E espera o usuário pressionar uma tecla antes de fechar
            Console.ReadKey();

            Menu();

        }

        static void Subtracao()
        {
            //Limpar tela sempre que inicia o terminal
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 - num2;
            Console.WriteLine("Resultado da subtração: " + resultado);

            // E espera o usuário pressionar uma tecla antes de fechar
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            //Limpar tela sempre que inicia o terminal
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 * num2;
            Console.WriteLine("Resultado da multiplicação: " + resultado);

            // E espera o usuário pressionar uma tecla antes de fechar
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            //Limpar tela sempre que inicia o terminal
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (num2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                float resultado = num1 / num2;
                Console.WriteLine("Resultado da divisão: " + resultado);
            }

            // E espera o usuário pressionar uma tecla antes de fechar
            Console.ReadKey();
            Menu();
        }


    }
}