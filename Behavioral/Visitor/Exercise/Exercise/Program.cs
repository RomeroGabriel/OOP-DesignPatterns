﻿using System.Text;
using static System.Console;

namespace Exercise
{
    class Program
    {
        public abstract class ExpressionVisitor
        {
            public abstract void Visit(Value value);
            public abstract void Visit(AdditionExpression value);
            public abstract void Visit(MultiplicationExpression value);
        }

        public abstract class Expression
        {
            public abstract void Accept(ExpressionVisitor ev);
        }

        public class Value : Expression
        {
            public readonly int TheValue;

            public Value(int value)
            {
                TheValue = value;
            }

            public override void Accept(ExpressionVisitor ev)
            {
                ev.Visit(this);
            }

        }

        public class AdditionExpression : Expression
        {
            public readonly Expression LHS, RHS;

            public AdditionExpression(Expression lhs, Expression rhs)
            {
                LHS = lhs;
                RHS = rhs;
            }

            public override void Accept(ExpressionVisitor ev)
            {
                ev.Visit(this);
            }
        }

        public class MultiplicationExpression : Expression
        {
            public readonly Expression LHS, RHS;

            public MultiplicationExpression(Expression lhs, Expression rhs)
            {
                LHS = lhs;
                RHS = rhs;
            }

            public override void Accept(ExpressionVisitor ev)
            {
                ev.Visit(this);
            }
        }

        public class ExpressionPrinter : ExpressionVisitor
        {
            StringBuilder sb = new StringBuilder();

            public override void Visit(Value value)
            {
                sb.Append(value.TheValue);
            }

            public override void Visit(AdditionExpression ae)
            {
                sb.Append("(");
                ae.LHS.Accept(this);
                sb.Append("+");
                ae.RHS.Accept(this);
                sb.Append(")");
            }

            public override void Visit(MultiplicationExpression me)
            {
                me.LHS.Accept(this);
                sb.Append("*");
                me.RHS.Accept(this);
            }

            public override string ToString()
            {
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            var teste = new Value(1);
            var ep = new ExpressionPrinter();
            ep.Visit(teste);
            WriteLine(ep.ToString());
            ReadKey();
        }
    }
}
