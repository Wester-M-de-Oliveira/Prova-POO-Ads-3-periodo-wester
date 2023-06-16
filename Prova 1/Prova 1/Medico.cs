/*Os médicos recebem um benefício
de 20 % sobre o salário de auxílio periculosidade (não é contabilizado para esse cálculo o valor da
hora extra). */

sealed public class Medico : Funcionario
{
    public string crm { get; set; }
    public double horaExtra { get; set; }
    public string especialidade { get; set; }

    public Medico(string nome, string cpf, string matricula, string dataNasc, string sexo, double salario, string crm, double horaExtra, string especialidade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.matricula = matricula;
        this.dataNasc = dataNasc;
        this.sexo = sexo;
        this.salario = salario;
        this.crm = crm;
        this.horaExtra = horaExtra;
        this.especialidade = especialidade;
    }
    public double calcBeneficios()
    {
        return salario * 1.2;
    }

}