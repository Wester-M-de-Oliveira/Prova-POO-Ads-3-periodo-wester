Console.WriteLine("Digite quantos funcionários deseja cadastrar");
int quantidade;

while (!int.TryParse(Console.ReadLine(), out quantidade))
{
    Console.WriteLine("Entrada inválida. Digite um valor numérico.");
}

Medico medico;
List<Medico> medicos = new List<Medico>();
Administrativo adm;
List<Administrativo> adms = new List<Administrativo>();
FolhaPagamento folhaPagamento;
List<FolhaPagamento> pagamentos = new List<FolhaPagamento>();

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine("Você deseja inserir um Funcionário médico ou administrativo? (1 - médico; 2 - adm)");
    int escolha;

    while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha != 1 && escolha != 2))
    {
        Console.WriteLine("Entrada inválida. Digite 1 para médico ou 2 para adm.");
    }

    if (escolha == 1)
    {
        Console.WriteLine("Digite o nome do funcionário");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF do funcionário");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a matrícula do funcionário");
        string matricula = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento do funcionário");
        string dataNasc = Console.ReadLine();
        Console.WriteLine("Digite o sexo do funcionário");
        string sexo = Console.ReadLine();
        Console.WriteLine("Digite o salario do funcionario");
        double salario;
        while (!double.TryParse(Console.ReadLine(), out salario))
        {
            Console.WriteLine("Entrada inválida. Digite um valor numérico para o salário.");
        }
        Console.WriteLine("Digite o CRM do médico");
        string crm = Console.ReadLine();
        Console.WriteLine("Digite o valor da Hora Extra do funcionario");
        double horaExt;
        while (!double.TryParse(Console.ReadLine(), out horaExt))
        {
            Console.WriteLine("Entrada inválida. Digite um valor numérico para a hora extra.");
        }
        Console.WriteLine("Digite a especialidade do médico");
        string especialidade = Console.ReadLine();

        medico = new Medico(nome, cpf, matricula, dataNasc, sexo, salario, crm, horaExt, especialidade);
        medicos.Add(medico);

        folha_pag(medico);
    }
    else if (escolha == 2)
    {
        Console.WriteLine("Digite o nome do funcionário");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF do funcionário");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a matrícula do funcionário");
        string matricula = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento do funcionário");
        string dataNasc = Console.ReadLine();
        Console.WriteLine("Digite o sexo do funcionário");
        string sexo = Console.ReadLine();
        Console.WriteLine("Digite o salario do funcionario");
        double salario;
        while (!double.TryParse(Console.ReadLine(), out salario))
        {
            Console.WriteLine("Entrada inválida. Digite um valor numérico para o salário.");
        }
        Console.WriteLine("Digite a função do funcionário");
        string funcao = Console.ReadLine();
        adm = new Administrativo(nome, cpf, matricula, dataNasc, sexo, salario, funcao);
        adms.Add(adm);

        folha_pag(adm);
    }
    else
    {
        Console.WriteLine("Opção Inválida");
        i--;
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Digite qual mês quer relatório de gatos");
string mes = Console.ReadLine().ToLower();
double valorGasto = FolhaPagamento.VerificarValorGasto(pagamentos, mes);
Console.WriteLine($"Valor gasto neste mês: {valorGasto}");
void folha_pag(Funcionario funcionario)
{
    folhaPagamento = new FolhaPagamento();
    Console.WriteLine("Digite o mês correspondente");
    folhaPagamento.mesCorresp = Console.ReadLine().ToLower();
    Console.WriteLine("Digite as horas extra trabalhado");
    double horasTrab;
    while (!double.TryParse(Console.ReadLine(), out horasTrab))
    {
        Console.WriteLine("Entrada inválida. Digite um valor numérico para as horas trabalhadas.");
    }
    folhaPagamento.horasTrab = horasTrab;
    folhaPagamento.funcionario = funcionario;
    pagamentos.Add(folhaPagamento);
}
