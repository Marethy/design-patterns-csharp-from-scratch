namespace Interpreter
{
    public interface IExpression
    {
        bool Interpret(OrderContext context);
    }

    public class VipExpression : IExpression
    {
        public bool Interpret(OrderContext context) => context.IsVIP;
    }

    public class TotalExpression : IExpression
    {
        private readonly decimal _amount;
        public TotalExpression(decimal amount) => _amount = amount;
        public bool Interpret(OrderContext context) => context.Total > _amount;
    }

    public class AndExpression(IExpression left, IExpression right) : IExpression
    {
        public bool Interpret(OrderContext context) => left.Interpret(context) && right.Interpret(context);
    }

    public class OrExpression(IExpression left, IExpression right) : IExpression
    {
        public bool Interpret(OrderContext context) => left.Interpret(context) || right.Interpret(context);
    }

    // Context
    public class OrderContext
    {
        public bool IsVIP { get; set; }
        public decimal Total { get; set; }
    }
}