namespace Gabriel.Models;

public class Funcionario{
    public Funcionario() { 
        Id = Guid.NewGuid().ToString();
        //CriadoEm = DateTime.Now;
    }

    public Funcionario(string nome, string cpf){
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }
    
    public string Id { get; set; }
    public string? Nome { get; set; } 
    public string? Cpf { get; set; }
    // private string nome;
    // private string descricao;
    // Colocar informações (JAVA)
    // public void setNome(string nome){
    //     this.nome = nome;
    // }

    // Pegar informações (JAVA)
    // public string getNome(){
    //     return this.nome;
    // }
   
}
// record Produto(string nome, string descricao);