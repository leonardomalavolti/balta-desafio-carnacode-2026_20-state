using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class PaidState : IOrderState
{
    public string StatusName => "Paid";

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"❌ Pedido já foi pago!");
    }

    public void Ship(Order order, string trackingCode)
    {
        order.TrackingCode = trackingCode;
        order.ShippedDate = DateTime.Now;
        order.SetState(new ShippedState());
        Console.WriteLine($"✅ Pedido enviado! Código de rastreio: {trackingCode}");
    }

    public void Deliver(Order order)
    {
        Console.WriteLine($"❌ Pedido ainda não foi enviado!");
    }

    public void Cancel(Order order)
    {
        order.SetState(new CancelledState());
        Console.WriteLine($"✅ Pedido cancelado. Reembolso será processado.");
    }

    public void RequestReturn(Order order)
    {
        Console.WriteLine($"❌ Pedido ainda não foi entregue. Use cancelamento.");
    }
}
