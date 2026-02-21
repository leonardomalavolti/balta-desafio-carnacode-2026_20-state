using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class CancelledState : IOrderState
{
    public string StatusName => "Cancelled";

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"❌ Pedido cancelado.");
    }

    public void Ship(Order order, string trackingCode)
    {
        Console.WriteLine($"❌ Pedido cancelado.");
    }

    public void Deliver(Order order)
    {
        Console.WriteLine($"❌ Pedido cancelado.");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine($"❌ Pedido já cancelado.");
    }

    public void RequestReturn(Order order)
    {
        Console.WriteLine($"❌ Pedido cancelado não pode ser devolvido.");
    }
}
