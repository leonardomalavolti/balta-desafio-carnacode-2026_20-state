using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class ReturnedState : IOrderState
{
    public string StatusName => "Returned";

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"❌ Pedido devolvido.");
    }

    public void Ship(Order order, string trackingCode)
    {
        Console.WriteLine($"❌ Pedido devolvido.");
    }

    public void Deliver(Order order)
    {
        Console.WriteLine($"❌ Pedido devolvido.");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine($"❌ Pedido devolvido.");
    }

    public void RequestReturn(Order order)
    {
        Console.WriteLine($"❌ Pedido já devolvido.");
    }
}