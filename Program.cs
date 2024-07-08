namespace Projeto_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do funcionário");
            string nome = Console.ReadLine();

            Funcionario funcionario1 = new Funcionario();
            funcionario1.Nome = nome;

            Console.WriteLine("Digite o nome do departamento do funcionário");
            string departamento = Console.ReadLine();

            Departamento departamento1 = new Departamento();
            departamento1.Nome = departamento;

            Console.WriteLine("Digite o código desse departamento");
            string codigo = Console.ReadLine();
            departamento1.Codigo = codigo;
            
            funcionario1.Departamento = departamento1;
            departamento1.Funcionarios = new List<Funcionario> { funcionario1 };

            Console.WriteLine();
            Console.WriteLine($"Nome do funcionário: {funcionario1.Nome}");
            Console.WriteLine($"Nome do departamento: {funcionario1.Departamento.Nome}");
            Console.WriteLine($"Código do departamento: {funcionario1.Departamento.Codigo}");
            

            int i = 0;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Há mais algum funcionário nesse departamento?");
                string haMais = Console.ReadLine();

                if (haMais.ToLower() == "sim" || haMais.ToLower() == "s")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Digite o nome do {i + 2}º funcionário");
                    string nomeFunc = Console.ReadLine();

                    Funcionario funcionarioX = new Funcionario();
                    funcionarioX.Nome = nomeFunc;
                    funcionarioX.Departamento = departamento1;
                    departamento1.Funcionarios.Add(funcionarioX);
                }
                else
                {
                    break;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"Nome do departamento: {departamento1.Nome}");
            Console.WriteLine($"Quantidade de funcionarios no departamento: {departamento1.Funcionarios.Count}");
            Console.WriteLine("Lista dos funcionários da empresa: ");
            foreach(Funcionario funcionario in departamento1.Funcionarios)
            {
                Console.WriteLine($"> {funcionario.Nome}");
            }
        }
    }
}