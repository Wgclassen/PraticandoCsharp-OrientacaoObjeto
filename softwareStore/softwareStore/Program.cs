using softwareStore;

InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
produto.ExibirDetalhes();