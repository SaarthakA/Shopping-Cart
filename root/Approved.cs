using System.IO;
using System;


 
public class Approved : IOrderState{
    private readonly OrderState _Parent;
    public Approved(OrderState OrderState){
        _Parent = OrderState;
        this.Approve();
    }
    public void NewOrderPlaced(){
        throw new Exception("OrderState has already been placed");
    }
    public void Dispatch(){
        _Parent._CurrentState = new Dispatched(_Parent);
    }
    public void Register(){
        throw new Exception("OrderState has already been registered");
    }
    public void Approve(){
        Console.WriteLine("Approved");
   }
}