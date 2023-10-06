string time;
Random rnd = new Random();
do
    {
        //work stuff///////////////////////////////////////////////////////////////////////////////////////
        //several types of work
        //1 - count up/down to 8-32 numbers
        //2 - sort stuff from categories - animals, clothes, seasons, sports, foods...
        //3 - write a letter - same mechanics as numbers ig??
        //4 - 
        //5 -
        //random number for each work
        //workx - work index
        Console.WriteLine("[[build complete]]\npress enter to generate work");
        
        int workx  = rnd.Next(4);
        Console.ReadLine();
        if (workx==0)
        {
            Console.WriteLine("work 0");
        }
        else if (workx==1)
        {
            Console.WriteLine("work 1");
        }
        else if (workx==2)
        {
            Console.WriteLine("work 2");
        }
        else if (workx==3)
        {
            Console.WriteLine("work 3");
        }
        else if (workx==4)
        {
            Console.WriteLine("work 4");
        }
        



        Console.WriteLine("> press enter to terminate:");
        Console.ReadLine();

        //end of work stuff///////////////////////////////////////////////////////////////////////////////////////
        time = "eve";
    } while (time == "work");