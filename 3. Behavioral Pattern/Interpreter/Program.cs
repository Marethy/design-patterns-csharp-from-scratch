using Interpreter;

var context = new OrderContext { IsVIP = true, Total = 2500000 };

// (total > 1000000) OR (VIP AND total > 2000000)
IExpression rule = new OrExpression(
    new TotalExpression(1000000),
    new AndExpression(new VipExpression(), new TotalExpression(2000000))
);

bool result = rule.Interpret(context); // true → apply  discount
Console.WriteLine($"Discount applicable: {result}");