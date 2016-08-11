using Exercise.Entities;
using System;
using static Exercise.Utils.NullValidator;
using static System.Console;

namespace Exercise
{
    public class OrderProcessor
    {
        public void Execute(Order order)
        {
            Check(order, "order");
            if (order.IsValid() && order.QualifiesForDiscount())
            {
                //Code
                WriteLine("Order processed");
            }
            else
            {
                throw new Exception("Order not processed");
            }
        }
    }
}
