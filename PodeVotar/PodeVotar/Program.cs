namespace PodeVotar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarMenu();
        }

        public static void CarregarMenu()
        {
            Console.Clear();

            DesenharCabecalho();
            Console.WriteLine("1 - Iniciar programa");
            Console.WriteLine("0 - Fechar programa");
            Console.WriteLine("-----------------------");

            Console.Write("\n\nSelecione uma opção: ");
            string opcaoMenu = Console.ReadLine();

            switch (opcaoMenu)
            {
                case "1":
                    CriarPessoa();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    CarregarMenu();
                    break;
            }
        }

        public static void DesenharCabecalho()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Descubra se pode votar!");
            Console.WriteLine("-----------------------");
        }

        public static void MostrarDadosPessoa(string pessoaNome, int pessoaIdade)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Nome: {pessoaNome} \nIdade: {pessoaIdade}");
            Console.WriteLine("-----------------------");
        }

        public static void CriarPessoa()
        {
            Console.Clear();
            Console.Write("\nNome Completo: ");
            string pessoaNome = Console.ReadLine();

            Console.Write("\nIdade: ");
            int pessoaIdade = Int32.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(pessoaNome, pessoaIdade);
            bool resultadoVoto = pessoa.PodeVotar();

            Console.Clear();
            MostrarDadosPessoa(pessoaNome, pessoaIdade);

            if (resultadoVoto && (pessoaIdade >= 16 && pessoaIdade <= 17))
                Console.WriteLine("\nVoto Opicional!");
            else if (resultadoVoto)
                Console.WriteLine("\nVoto Obrigatório!");
            else
                Console.WriteLine("\nAinda não pode votar!");

            Console.ReadKey();
            CarregarMenu();
        }
    }
}

