//QSee https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");
// /*INICIALIZANDO PRODUTOS PRODUTOS*/
// Produto p1 = new Produto("sorverte", "01/10/2022", 20.5);
// Produto p2 = new Produto("arroz", "01/10/2022", 5.75);
// Produto p3 = new Produto("sabão", "01/10/2022", 3);
// Produto p4 = new Produto("detergente", "01/10/2022", 2.5);

// // INICIALIZANDO MERCADO    
// Mercado m1 = new Mercado("1","SuperBarato", "Rua Nova" );
// m1.Adicionar(p1);
// m1.Adicionar(p2);
// m1.Adicionar(p3);
// m1.Adicionar(p4);


// //INICIALIZANDO CARRINHO
// //Carrinho c1 = new Carrinho();

// // INICIALIZANDO RESTAURANTE
// Restaurante r1 = new Restaurante();
// r1.Nome_restaurante = "Sal";
// r1.Codigo_restaurante = "123";
// r1.Localidade_restaurante = "Rua Velha";

// //ADICIONANDO PRODUTOS AO CARRINHO
// r1.Adicionar(p1);
// r1.Adicionar(p2);
// r1.Adicionar(p3);
// r1.Adicionar(p4);

// //EXCLUINDO PRODUTOS DO CARRINHO
// r1.Excluir("arroz"); //'arroz' era o produto alocado no indece 1 do ArrayList Carrinho

// Console.WriteLine(r1.Produtos[0].Nome);
// Console.WriteLine(r1.Produtos[1].Nome);
// Console.WriteLine(r1.Produtos[2].Nome);
// Console.WriteLine(r1.Produtos[3].Nome);//O erro ocorre, pois o ArrayList tem tamanaho = 3
//                                       //e esta linha força a consulta no indice 4 (que foi excluído acima - linha 33)