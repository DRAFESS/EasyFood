Console.WriteLine("Bem-vindo ao terminal EasyFood!\n");

Cardapio cardapio = new Cardapio();
cardapio.AdicionarItem(new ItemCardapio("Pizza", 30.00));
cardapio.AdicionarItem(new ItemCardapio("Refrigerante", 5.00));

Restaurante restaurante = new Restaurante("Restaurante Legal", cardapio);
Mesa mesa1 = new Mesa(1);
restaurante.AdicionarMesa(mesa1);

restaurante.ReservarMesa(1);

Pedido pedido = new Pedido(1);
pedido.AdicionarItem(cardapio.Itens[0]); 
pedido.AdicionarItem(cardapio.Itens[1]); 

mesa1.FazerPedido(pedido);

Console.WriteLine($"Total do pedido: {pedido.CalcularTotal()}");
