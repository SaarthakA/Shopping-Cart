using System.IO;
using System;

public class Registered : IOrderState
    {
        private readonly OrderState _Parent;
        public void NewOrderPlaced(){
            throw new Exception("OrderState has already been placed");
        }
        public Registered(OrderState OrderState){
               _Parent = OrderState;
               this.Register();
           }
           public void Dispatch(){
               throw new Exception("OrderState has not been registered yet");
           }
           public void Register(){
               Console.WriteLine("Registered");
           }
           public void Approve(){
               _Parent._CurrentState = new Approved(_Parent);
           }
       }