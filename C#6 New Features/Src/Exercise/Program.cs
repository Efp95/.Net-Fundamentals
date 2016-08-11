using Exercise.Common;
using Exercise.Entities;
using Exercise.Extensions;
using Exercise.Logger;
using Exercise.Logger.Strategy;
using System;
using System.Collections.Generic;
using static System.Console;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerManager.Get(LoggerType.Console);

            try
            {
                var processor = new OrderProcessor();

                var products = new List<Product>
                {
                    {"Sugar", 10},
                    {"Chocolate", 10}
                };
                var order = new Order(new Person("Alex"), null, new Address("KK"), products);

                processor.Execute(order);
                logger.Trace(new LogMessage { Message = "Order processed" });
            }
            catch (Exception) when (logger == null)
            {
                return;
            }
            catch (Exception ex) when (ex.Message.Contains("null"))
            {
                WriteLine("Fix the null order");
                logger.Error(new LogMessage { Exception = ex, Message = "error" });
            }
            catch (Exception ex) when (ex.Message.Equals("Order not processed"))
            {
                WriteLine("Check the parameter order");
                logger.Warning(new LogMessage { Exception = ex, Message = "error" });
            }
            catch (Exception ex)
            {
                WriteLine("Only god knows what happened :S");
                logger.Fatal(new LogMessage { Exception = ex, Message = "error" });
            }

            ReadLine();
        }
    }
}
