
public class FolhaPagamento
{
    public string mesCorresp { get; set; }
    public Funcionario funcionario { get; set; }
    public double iprf { get; set; }
    public double horasTrab { get; set; }

    public static double valorTotal;
    public double ValorPagamento()
    {
        double salario = funcionario.salario;
        double descontoIrpf=0;
        double horaExt=0;
        if(funcionario is Medico)
        {
            Medico medico = (Medico)funcionario;
            salario = medico.calcBeneficios();
            horaExt = medico.horaExtra * horasTrab;

        } else if(funcionario is Administrativo)

        {
            Administrativo administrativo = (Administrativo)funcionario;
            salario = administrativo.calcBeneficios();
        }
        
        if (salario > 5000)
        {
            descontoIrpf =salario * 0.83;
        }

        double valor = salario + horaExt - descontoIrpf;
        valorTotal += (valor);
        return valor;
    }

    public double GetValorTotal()
    {
        return valorTotal;
    }

    public static double VerificarValorGasto(List<FolhaPagamento> folhasPagamento, string mes)
    {
        double valor = 0;
        foreach (var folhaPag in folhasPagamento)
        {
            if (folhaPag.mesCorresp == mes)
            {
                valor = folhaPag.GetValorTotal();
            }
        }
        return valor;
    }
}
