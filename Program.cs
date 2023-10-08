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

Thread thread = new Thread(countNumbersDelay);
thread.Start();

countNumbers();