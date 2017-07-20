using System.IO;
using System;

public class NewOrder : IOrderState
       {
           private readonly OrderState _Parent;
           public NewOrder(OrderState OrderState)
           {
               _Parent = OrderState;
               this.NewOrderPlaced();

           }
           public bool IsDispatched
           {
               get { return false; }
           }
           public void NewOrderPlaced()
           {
               Console.WriteLine("NewOrderPlaced");
           }
           public void Dispatch()
           {
               _Parent._CurrentState = new Dispatched(_Parent);
           }
           public void Register()
           {
               _Parent._CurrentState = new Registered(_Parent);
           }
           public void Approve()
           {
               _Parent._CurrentState = new Approved(_Parent);
           }
       }