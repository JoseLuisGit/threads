static void countNumbers(){
    Console.WriteLine("Starting");
    for(int i = 1; i <= 10; i++){
        Console.WriteLine(i);
    }
}

Thread thread = new Thread(countNumbers);
thread.Start();

countNumbers();