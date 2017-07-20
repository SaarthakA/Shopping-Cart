using System.IO;
using System;

    public class Dispatched : IOrderState
       {
           private readonly OrderState _Parent;
           public void NewOrderPlaced()
           {
               throw new Exception("OrderState has already been placed");
           }
           public Dispatched(OrderState OrderState)
           {
               _Parent = OrderState;
               this.Dispatch();
           }
           public void Dispatch()
           {
               Console.WriteLine("dispatched");
           }
           public void Register()
           {
               throw new Exception("OrderState has already been registered");
           }
           public void Approve()
           {
               _Parent._CurrentState = new Approved(_Parent);
           }
       }