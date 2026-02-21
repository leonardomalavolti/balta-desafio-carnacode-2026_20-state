using DesignPatternChallenge.Models;

Console.WriteLine("=== Sistema de Gerenciamento de Pedidos (State Pattern) ===");

var order1 = new Order("ORD-001", 250.00m);
order1.ProcessPayment();
order1.Ship("BR123456789");
order1.Deliver();
order1.RequestReturn();

Console.WriteLine("\n" + new string('=', 50));

var order2 = new Order("ORD-002", 150.00m);
order2.Ship("BR987654321");  // Não pago ainda
order2.ProcessPayment();
order2.ProcessPayment();     // Já pago
order2.Cancel();             // Cancelar após pagamento