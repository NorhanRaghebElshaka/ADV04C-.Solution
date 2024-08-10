﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Delegate : C# Language Feature 
        // Usages :  // 1. Functional Programming    // 2. Event_ Deriven Programming

        #region Event Example1

        // Ball ball = new Ball() { Id = 1 };
        //Console.WriteLine(ball);
        //ball.location = new Location() { x = 1, y = 1, z = 1 };
        //Console.WriteLine(ball);
        //
        //player p01 = new player() { playName = "Messi", TeamName = "Miami" };
        //player p02 = new player() { playName = "Alba", TeamName = "Miami" };
        //
        //player p03 = new player() { playName = "Pedri", TeamName = "Barcelona" };
        //player p04 = new player() { playName = "Gavi", TeamName = "Barcelona" };
        //
        //Refree refree = new Refree() { RefreeName = "Ibrahmi Nour El-Din" };
        //
        //ball.location = new Location() { x = 1 , y = 1, z = 1 };
        //
        //ball.BallLocationChanged += p01.Run;
        //ball.BallLocationChanged += p02.Run;
        //ball.BallLocationChanged += p03.Run;
        //ball.BallLocationChanged += p04.Run;
        //ball.BallLocationChanged += refree.Look;
        //
        //ball.location = new Location() { x = 1, y = 1, z = 2 };
        //
        //Console.WriteLine("\n After pedri changed Salah \n");
        //ball.BallLocationChanged -= p01.Run;
        //ball.BallLocationChanged += p02.Run;

        #endregion

        #region Event Example2
        //Channel channel = new Channel() { channelName = "ABC" };
        //
        //channel.Addvideo(new Video { Title = "Title1", Description = "Desc1"});
        //
        //Subscriber subscriber01 = new Subscriber() { SubscriberName = "chgchg"};
        //Subscriber subscriber02 = new Subscriber() { SubscriberName = "nooor"};
        //Subscriber subscriber03 = new Subscriber() { SubscriberName = "nada"};
        //Subscriber subscriber04 = new Subscriber() { SubscriberName = "samy"};
        //Subscriber subscriber05 = new Subscriber() { SubscriberName = "ragheb"};
        //
        //channel.uploadvideo += subscriber01.Notify;
        //channel.uploadvideo += subscriber02.Notify;
        //channel.uploadvideo += subscriber03.Notify;
        //channel.uploadvideo += subscriber04.Notify;
        //
        //channel.Addvideo(new Video { Title = "Title2", Description = "Desc2" });
        //Console.WriteLine("After nooor cancel subscription");
        //Console.WriteLine("After ragheb Subscribe ");

        #endregion

        #region  //// Collection : Built in Ds In C# 
        //// Collection : Built in Ds In C# 
        //// List 
        ////HashTable

        //// Non_Generic Collection
        //// Generic Collection

        ////List 
        //// Non-Generic : ArrayList
        //// Generic : List , LikedList , Stack , Queue

        //// Hashtable :
        //// Non-Generic Collection : Hashtable
        //// Generic Collection 
        #endregion

        #region Hashtable


        //Hashtable Note = new Hashtable();
        //Note.Add("Ahmed", 999999);
        //Note.Add("Ali", 88888);
        //Note.Add("omar", 7777);
        //
        //Console.WriteLine();
        //Console.WriteLine("------------- Item of HashTable---------------");
        //
        //foreach (DictionaryEntry item in Note) 
        //{
        //    Console.WriteLine($"Key: {item.Key } , value: {item.Value}");
        //}

        //string name01 = "Ahmed";
        //string Name02 = "Ahmed";

        //Console.WriteLine($"name01 = {name01.GetHashCode()}");
        //Console.WriteLine($"name02 = {Name02.GetHashCode()}");


        //Console.WriteLine(name01.Equals(Name02)); 


        //int x = 10;
        //int y = 10;
        //Console.WriteLine(x.GetHashCode());


        //x.Equals(y);


        #endregion

        #region Dictionary

        ////Dictionary<string, long> Note = new Dictionary<string, long>();

        ////Note.Add("Ahmed", 99999999);
        ////Note.Add("Mahmoued", 999999999);
        ////Note.Add("ali", 888888);
        ////Note.Add("omar", 77777777777);

        ////// 100
        ////Note.EnsureCapacity(120);
        ////Note.TryGetValue("ali", out long result);


        ////foreach (KeyValuePair<string, long> item in Note)
        ////{
        ////    Console.WriteLine($"Key {item.Key} , value : {item.Value}");
        ////}

        #endregion

    }
}
