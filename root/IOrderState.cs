using System.IO;
using System;

public interface IOrderState
        {
            void NewOrderPlaced();
            void Register();
            void Dispatch();
            void Approve();
        }