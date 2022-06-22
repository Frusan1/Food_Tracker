using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Key]
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Validade { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, string validade, decimal preco)
    {
        this.Nome = nome;
        this.Validade = validade;
        this.Preco = preco;
    }
    public Produto() { }
}