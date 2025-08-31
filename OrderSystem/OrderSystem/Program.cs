using OrderSystem;

Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();