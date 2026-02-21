using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.States;

public class PendingState : IOrderState
{
    public string StatusName => "Pending";

    public void ProcessPayment(Order order)
    {
        order.SetState(new PaidState());
        Console.WriteLine($"✅ Pagamento confirmado! Total: R$ {order.TotalAmount:N2}");
    }

    public void Ship(Order order, string trackingCode)
    {
        Console.WriteLine($"❌ Pedido ainda não foi pago!");
    }

    public void Deliver(Order order)
    {
        Console.WriteLine($"❌ Pedido ainda não foi enviado!");
    }

    public void Cancel(Order order)
    {
        order.SetState(new CancelledState());
        Console.WriteLine($"✅ Pedido cancelado. Nenhuma cobrança realizada.");
    }

    public void RequestReturn(Order order)
    {
        Console.WriteLine($"❌ Pedido ainda não foi entregue. Use cancelamento.");
    }
}
