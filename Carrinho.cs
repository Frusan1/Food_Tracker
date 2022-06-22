using System;
using System.Collections;
public class Carrinho : Produto 
{
    private List<Produto> produtos = new List<Produto>();

    public Carrinho(){}

    public List<Produto> Produtos { get => produtos; set => produtos = value; }

    public void Adicionar(Produto p)
    {
        Produtos.Add(p);
    }

    public void Excluir(String nome_produto)
    {
        int i;
        for (i=0; i<Produtos.Count; i++){
            if (Produtos[i].Nome == nome_produto){
                Produtos.Remove(Produtos[i]);
            }
        }

    }

    public void ListarProd()
    {
        int i;
        for (i=0; i<Produtos.Count; i++){
            Console.WriteLine(Produtos[i].Nome);
            }
        }
   
}
