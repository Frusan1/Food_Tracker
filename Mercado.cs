
public class Mercado : Estoque
{
    private String? id;
    private String? nome_mercado;
    private String? localdida_mercado;
    private Estoque? estoque;
    

    public Mercado(string id, string nome, string localdida)
    {
        this.id = id;
        this.nome_mercado = nome;
        this.localdida_mercado = localdida;
        this.Estoque = new Estoque();
        
    }

    public string? Id { get => id; set => id = value; }
    public string? Nome_mercado { get => nome_mercado; set => nome_mercado = value; }
    public string? Localdida_mercado { get => localdida_mercado; set => localdida_mercado = value; }
    public Estoque? Estoque { get => estoque; set => estoque = value; }
}