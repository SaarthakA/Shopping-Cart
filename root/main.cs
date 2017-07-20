using System.IO;
using System;

class Program
{
    static void Main()
    {
        OrderState OrderState = new OrderState();
            OrderState.Register();
            OrderState.Approve();
            OrderState.Dispatch();
    }
}




