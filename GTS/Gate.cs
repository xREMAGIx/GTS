using System;
using System.Timers;

class Gate
{
    static Timer _timer;
    // public int timeExecute;
    public bool available { get; set; } = true;

    public int numberOfExecutedPassenger { get; set; }

    public int passengerPriority { get; set; }

    public int generateTimeExecute(int from, int to)
    {
        Random rnd = new Random();
        return rnd.Next(from, to + 1);
    }

    public void StartExecute(int time, int number, int priority)
    {
        numberOfExecutedPassenger = number;
        passengerPriority = priority;
        available = false;
        numberOfExecutedPassenger = number;
        var timer = new Timer(1000 * time);
        timer.Elapsed += new ElapsedEventHandler(_timer_execute_Elapsed);
        timer.Enabled = true;
        timer.AutoReset = false;
        _timer = timer;
    }

    private void _timer_execute_Elapsed(object sender, ElapsedEventArgs e)
    {
        available = !available;
        numberOfExecutedPassenger = 0;
        passengerPriority = 0;
    }
}