static void countNumbers(){
    Console.WriteLine("Starting");
    for(int i = 1; i <= 10; i++){
        Console.WriteLine(i);
    }
}

static void countNumbersDelay(){
    Console.WriteLine("Starting With Delay");
    for(int i = 1; i <= 10; i++){
        Thread.Sleep(TimeSpan.FromSeconds(1));
        Console.WriteLine(i);
    }
}

Console.WriteLine("Starting");
Thread thread1 = new Thread(countNumbersDelay);
thread1.Start();
Thread.Sleep(TimeSpan.FromSeconds(6));
thread1.Interrupt();
Console.WriteLine("The thread1 has been aborted");
Thread thread2 = new Thread(countNumbers);
thread2.Start();
countNumbers();
Console.WriteLine("This is completed");
