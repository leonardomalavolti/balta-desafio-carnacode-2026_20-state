using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class DeliveredState : IOrderState
{
    public string StatusName => "Delivered";

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"❌ Pedido já entregue!");
    }

    public void Ship(Order order, string trackingCode)
    {
        Console.WriteLine($"❌ Pedido já entregue!");
    }

    public void Deliver(Order order)
    {
        Console.WriteLine($"❌ Pedido já entregue em {order.DeliveredDate:dd/MM/yyyy}");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine($"❌ Pedido já entregue. Solicite devolução se necessário.");
    }

    public void RequestReturn(Order order)
    {
        var daysSinceDelivery = (DateTime.Now - order.DeliveredDate.Value).Days;
        if (daysSinceDelivery <= 7)
        {
            order.SetState(new ReturnedState());
            Console.WriteLine($"✅ Devolução aprovada! Reembolso: R$ {order.TotalAmount:N2}");
        }
        else
        {
            Console.WriteLine($"❌ Prazo de devolução expirado ({daysSinceDelivery} dias)");
        }
    }
}
