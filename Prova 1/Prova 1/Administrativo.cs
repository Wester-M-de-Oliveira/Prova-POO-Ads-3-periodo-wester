public class Administrativo : Funcionario
{
    public string funcao { get; set; }

    public Administrativo(string nome, string cpf, string matricula, string dataNasc, string sexo, double salario, string funcao)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.matricula = matricula;
        this.dataNasc = dataNasc;
        this.sexo = sexo;
        this.salario = salario;
        this.funcao = funcao;
    }
    public double calcBeneficios()
    {
        return salario * 1.15 + 150;
    }
}
