using System;

class GSMCallHistoryTest
{
    static void Main()
    {
        GSM MyGSM = new GSM("Defy", "Motorola");
        MyGSM.AddCall("0884567891", 24);
        MyGSM.AddCall("0883234156", 180);
        MyGSM.AddCall("0889356721", 35);
        MyGSM.AddCall("0888876543", 530);
        MyGSM.AddCall("0888876543", 350);
        MyGSM.AddCall("0888876543", 670);
        MyGSM.DisplayCallInformation();
        Console.WriteLine("Total price: {0} Leva.\n", MyGSM.GetCallsPrice(0.37m));
        MyGSM.RemoveCall();
        MyGSM.DisplayCallInformation();
        MyGSM.ClearCallHistory();
        MyGSM.DisplayCallInformation();
    }
}
