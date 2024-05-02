namespace Gabriel.Models;

public class Folha{
    public Folha() { 
        IdFolha = Guid.NewGuid().ToString();
        //CriadoEm = DateTime.Now;
    }

    public Folha(double valor, int quantidade, int mes, int ano, double salarioBruto, double irrf, double inss, double fgts, double salarioLiquido){
        IdFolha = Guid.NewGuid().ToString();
        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        Ano = ano;
        SalarioBruto = salarioBruto;
        Irrf = irrf;
        Inss = inss;
        Fgts = fgts;
        SalarioLiquido = salarioLiquido;
    }
    
    public string IdFolha { get; set; }
    public double? Valor { get; set; }
    public int? Quantidade { get; set; }
    public int? Mes { get; set; }
    public int? Ano { get; set; }
    public double? SalarioBruto { get; set; }
    public double? Irrf { get; set; }
    public double? Inss { get; set; }
    public double? Fgts { get; set; }
    public double? SalarioLiquido { get; set; }
    
    /*Salário Bruto salarioBruto = numHoras * valorHora; 
     if (salarioBruto <= 1903.98) { aliquota = 0; parcela = 0; } 
     if (salarioBruto >= 1903.99 && salarioBruto <= 2826.65){ aliquota = salarioBruto * 0,075; parcela = aliquota; } 
     if (salarioBruto >= 2826.66 && salarioBruto <= 3751.05){ aliquota = salarioBruto * 0,15; parcela = aliquota; } 
     if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68){ aliquota = salarioBruto * 0,225; parcela = aliquota; } 
     if (salarioBruto > 4664.68){ aliquota = salarioBruto * 0,275; parcela = aliquota; }
    INSS if (salarioBruto <= 1693.72){ INSS = salarioBruto * 0,08; } 
    if (salarioBruto >= 1693.73 && salarioBruto <= 2822.90){ INSS = salarioBruto * 0,09; } 
    if (salarioBruto >= 2822.91 && salarioBruto <= 5645.80){ INSS = salarioBruto * 0,11; } 
    if (salarioBruto > 5645.81 ){ INSS = salarioBruto - 621.03; }
    FGTS fgts = salarioBruto * 0,08;
    Salário Liquido salarioLiquido = salarioBruto - parcela - INSS;*/
}