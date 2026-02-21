using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.States;

namespace DesignPatternChallenge.Models;

public class Order
{
    private IOrderState _state;

    public string OrderId { get; }
    public decimal TotalAmount { get; }
    public string TrackingCode { get; set; }
    public DateTime? ShippedDate { get; set; }
    public DateTime? DeliveredDate { get; set; }

    public string Status => _state.StatusName;

    public Order(string orderId, decimal totalAmount)
    {
        OrderId = orderId;
        TotalAmount = totalAmount;
        _state = new PendingState();
    }

    public void SetState(IOrderState newState)
    {
        _state = newState;
    }

    public void ProcessPayment() => _state.ProcessPayment(this);
    public void Ship(string trackingCode) => _state.Ship(this, trackingCode);
    public void Deliver() => _state.Deliver(this);
    public void Cancel() => _state.Cancel(this);
    public void RequestReturn() => _state.RequestReturn(this);
}
