using System;
using System.Collections.Generic;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS
{
    class Airport
    {
        static Timer _timer;
        static Timer _timer2;

        public static List<Passenger> _passengers = new List<Passenger>();

        public static int numberOfPassenger = 0;

        public static Gate gate1 = new Gate();
        public static Gate gate2 = new Gate();
        public static Gate gate3 = new Gate();

        public static int AddNumberOfPassenger()
        {
            return ++numberOfPassenger;
        }

        public static void Start()
        {
            var timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            timer.Enabled = true;
            _timer = timer;

            var timer2 = new Timer(333);
            timer2.Elapsed += new ElapsedEventHandler(_timer2_Elapsed);
            timer2.Enabled = true;
            _timer2 = timer2;

        }

        static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            AddNumberOfPassenger();
            Passenger passenger = new Passenger();
            passenger.generate(numberOfPassenger);
            Console.WriteLine("New passenger number: " + passenger.number);
            Console.WriteLine("New passenger priority: " + passenger.priority);
            _passengers.Add(passenger);
            PrintTimes();
        }

        static void _timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_passengers.Count > 0)
            {
                switch (_passengers[0].priority)
                {
                    case 1:
                        if (gate1.available == true)
                        {
                            gate1.StartExecute(gate1.generateTimeExecute(2, 3), _passengers[0].number, _passengers[0].priority);
                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate2.available == true)
                        {
                            gate2.StartExecute(gate2.generateTimeExecute(1, 4), _passengers[0].number, _passengers[0].priority);

                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate3.available == true)
                        {
                            gate3.StartExecute(gate3.generateTimeExecute(3, 7), _passengers[0].number, _passengers[0].priority);
                            _passengers.RemoveAt(0);
                            break;
                        }
                        else break;
                    case 2:
                        if (gate2.available == true)
                        {
                            gate2.StartExecute(gate2.generateTimeExecute(1, 4), _passengers[0].number, _passengers[0].priority);

                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate1.available == true)
                        {
                            gate1.StartExecute(gate1.generateTimeExecute(2, 3), _passengers[0].number, _passengers[0].priority);

                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate3.available == true)
                        {
                            gate3.StartExecute(gate3.generateTimeExecute(3, 7), _passengers[0].number, _passengers[0].priority);

                            _passengers.RemoveAt(0);
                            break;
                        }
                        else break;
                    case 3:
                        if (gate3.available == true)
                        {
                            gate3.StartExecute(gate3.generateTimeExecute(3, 7), _passengers[0].number, _passengers[0].priority);

                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate1.available == true)
                        {
                            gate1.StartExecute(gate1.generateTimeExecute(2, 3), _passengers[0].number, _passengers[0].priority);
                            _passengers.RemoveAt(0);
                            break;
                        }
                        else if (gate2.available == true)
                        {
                            gate2.StartExecute(gate2.generateTimeExecute(1, 4), _passengers[0].number, _passengers[0].priority);
                            _passengers.RemoveAt(0);
                            break;
                        }
                        else break;
                    default:
                        Console.WriteLine("Sth wrong");
                        break;

                }
            }
        }

        public static void PrintTimes()
        {

            Console.WriteLine("GATE 1: ");
            Console.WriteLine("Available: " + gate1.available + "   ID of Passenger: " + gate1.numberOfExecutedPassenger);
            Console.WriteLine("GATE 2: ");
            Console.WriteLine("Available: " + gate2.available + "   ID of Passenger: " + gate2.numberOfExecutedPassenger);
            Console.WriteLine("GATE 3: ");
            Console.WriteLine("Available: " + gate3.available + "   ID of Passenger: " + gate3.numberOfExecutedPassenger);
            Console.WriteLine("---------------------------");
            if (_passengers.Count > 0)
            {
                Console.WriteLine("WAITING LINE: ");
                foreach (var iPassenger in _passengers)
                {
                    Console.Write(iPassenger.number + "," + iPassenger.priority + " ");
                }
                Console.WriteLine("\n---------------------------");

            }
            Console.WriteLine();
        }

    }
}
