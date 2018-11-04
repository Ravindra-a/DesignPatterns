using System;

namespace Command
{
    /// The 'ConcreteCommand' class
    public class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        //Constructor
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._operand = operand;
            this._operator = @operator;
            this._calculator = calculator;
        }

        // Gets operator
        public char Operator
        {   set { _operator = value; }  } 

        // Get operand
        public int Operand
        {   set { _operand = value; }  }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }    
        }
    }
}