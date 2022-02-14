using System;

namespace InterfaceBikeCar
{
    interface Vehicle
    {
        void start (int a);
        void speedup(int a);
        void stop(int a);

    }
    class bicycle
    {
        int speed;
        int engine;

    
    public void start (int enginestart)
    {
            engine = enginestart;
    }
        public void speedup(int increment)
        {
            speed = speed + increment;
        }
        public void stop(int enginestop) 
        {
            speed = speed - enginestop;
        }
        public void printstates()
        {
            Console.WriteLine("Speed:" + speed + "Engine Start" + engine);
        }
        class car
        {
            int speed;
            int engine;


            public void start(int enginestart)
            {
                engine = enginestart;
            }
            public void speedup(int increment)
            {
                speed = speed + increment;
            }
            public void stop(int enginestop)
            {
                speed = speed - enginestop;
            }
            public void printstates()
            {
                Console.WriteLine("Speed:" + speed + "Engine Start" + engine);
            }
            class Bike
            {
                int speed;
                int engine;


                public void start(int enginestart)
                {
                    engine = enginestart;
                }
                public void speedup(int increment)
                {
                    speed = speed + increment;
                }
                public void stop(int enginestop)
                {
                    speed = speed - enginestop;
                }
                public void printstates()
                {
                    Console.WriteLine("Speed:" + speed + "Engine Start" + engine);
                }
            }
        }
            static void Main(string[] args)
        {
            bicycle bi = new bicycle();
            bi.start(2);
            bi.speedup(20);
            bi.stop(1);
            Console.WriteLine("bicycle Present State: ");
            bi.printstates();

            car cr = new car();
            cr.start(2);
            cr.speedup(20);
            cr.stop(1);
            Console.WriteLine("Car Present State: ");
            bi.printstates();

            bicycle bik = new bicycle();
            bik.start(2);
            bik.speedup(20);
            bik.stop(1);
            Console.WriteLine("bicycle Present State: ");
            bik.printstates();


        }
    }
}
