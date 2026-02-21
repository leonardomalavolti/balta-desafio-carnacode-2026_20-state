using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class ShippedState : IOrderState
{
    public string StatusName => "Shipped";

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"❌ Pedido já foi enviado!");
    }

    public void Ship(Order order, string trackingCode)
    {
        Console.WriteLine($"❌ Pedido já foi enviado em {order.ShippedDate:dd/MM/yyyy}");
    }

    public void Deliver(Order order)
    {
        order.DeliveredDate = DateTime.Now;
        order.SetState(new DeliveredState());
        Console.WriteLine($"✅ Pedido entregue com sucesso! Data: {order.DeliveredDate:dd/MM/yyyy HH:mm}");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine($"❌ Pedido já enviado. Use processo de devolução.");
    }

    public void RequestReturn(Order order)
    {
        Console.WriteLine($"❌ Aguarde a entrega para solicitar devolução.");
    }
}
