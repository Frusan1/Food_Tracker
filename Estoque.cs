public class Estoque : Produto 
{
    private List<Produto> produtos_estoque = new List<Produto>();

    public Estoque(){}
   

    public List<Produto> Produtos_estoque { get => produtos_estoque; set => produtos_estoque = value; }

    public void Adicionar(Produto produto)
    {
        this.produtos_estoque.Add(produto);
    }
/*
     public void Excluir(Produto nome_produto)
    {
        produtos.Remove(produto.Nome(nome_produto));
    }

    public void ListarEstoque(){

    }
*/
}
