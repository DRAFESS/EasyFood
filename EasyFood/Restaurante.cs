public class Restaurante
{
    public string Nome { get; set; }
    public List<Mesa> Mesas { get; set; }
    public Cardapio Cardapio { get; set; }

    public Restaurante(string nome, Cardapio cardapio)
    {
        Nome = nome;
        Mesas = new List<Mesa>();
        Cardapio = cardapio;
    }

    public void AdicionarMesa(Mesa mesa)
    {
        Mesas.Add(mesa);
    }

    public void ReservarMesa(int numeroMesa)
    {
        Mesa mesa = Mesas.FirstOrDefault(m => m.Numero == numeroMesa);
        if (mesa != null && !mesa.Reservada)
        {
            mesa.Reservada = true;
            Console.WriteLine($"Mesa {numeroMesa} foi reservada.");
        }
        else
        {
            Console.WriteLine($"Mesa {numeroMesa} não pode ser reservada.");
        }
    }
}

public class Mesa
{
    public int Numero { get; set; }
    public bool Reservada { get; set; }
    public List<Pedido> Pedidos { get; set; }

    public Mesa(int numero)
    {
        Numero = numero;
        Reservada = false;
        Pedidos = new List<Pedido>();
    }

    public void FazerPedido(Pedido pedido)
    {
        Pedidos.Add(pedido);
    }
}

public class Pedido
{
    public int Id { get; set; }
    public List<ItemCardapio> Itens { get; set; }

    public Pedido(int id)
    {
        Id = id;
        Itens = new List<ItemCardapio>();
    }

    public void AdicionarItem(ItemCardapio item)
    {
        Itens.Add(item);
    }

    public double CalcularTotal()
    {
        return Itens.Sum(item => item.Preco);
    }
}


public class Cardapio
{
    public List<ItemCardapio> Itens { get; set; }

    public Cardapio()
    {
        Itens = new List<ItemCardapio>();
    }

    public void AdicionarItem(ItemCardapio item)
    {
        Itens.Add(item);
    }
}


public class ItemCardapio
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public ItemCardapio(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}
