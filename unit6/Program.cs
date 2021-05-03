using System;
using System.Threading;

public class DressingRooms
{
    // A dressing room that simulates a limited resource pool.
    //
    private static Semaphore DressingRooms1;
    private static Semaphore DressingRooms2;



    // A padding interval to make the output more orderly.
    private static int _padding;

    public static void Main()
    {
        // Create 3 dressing rooms that can satisfy up to three concurrent requests. 

        
        Console.WriteLine("Enter number of rooms:");
        int room = Convert.ToInt32(Console.ReadLine());        
        DressingRooms1 = new Semaphore(room, 15);
        DressingRooms2 = new Semaphore(room, 20);


            // Start with some number of customers. 
            Console.WriteLine("Enter number of customers:");
            int cust = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= cust; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(customers));

                // Start the thread, passing the number.
                //
                t.Start(i);
            }

        // Wait for half a second, to allow all the
        // threads to start and to block on the dressing room.
        //
        Thread.Sleep(5500);

        // The main thread starts out holding the entire
        // dressing room count. Calling the function brings the 
        // dressing room count to its maximum value, and
        // allows the waiting threads to enter the dressing room
        // 1 at a time.
        //

        DressingRooms1.Release(cust);
        DressingRooms2.Release(cust);
    }

    private static void customers(object num)
    {
        // Each customer begins by requesting the
        // dressing room.
        Console.WriteLine("Customer {0} begins " +
            "and waits for dressing rooms to be available.", num);
        DressingRooms1.WaitOne();
        DressingRooms2.WaitOne();

        // Start timer to test how long it takes
        var watch = new System.Diagnostics.Stopwatch();                    
        watch.Start();

        // A padding interval to make the output more orderly.
        int padding = Interlocked.Add(ref _padding, 100);

        Console.WriteLine("Customer {0} enters a dressing room.", num);
        
        // The thread's "work" consists of sleeping for 
        // about a second. Each thread "works" a little 
        // longer, just to make the output more orderly.
        //
        Thread.Sleep(1000 + padding);

        Console.WriteLine("Customer {0} releases a dressing room.", num);
    
        watch.Stop();
        Console.WriteLine($"Algorithm Execution Time is: {watch.ElapsedMilliseconds} ms");
    }    
}