using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running();
        run.SetDateTime(DateTime.Now);
        run.SetDistance(5);
        run.SetSpeed(6);
        run.SetPace(10); // make sure that this is conguent with the speed.
        //choosing a non-congruent number will give innacurate workout data.
        run.SetUnitOfMeasurement("mile");
        string _runSummary = run.WriteSummary();
        Console.WriteLine(_runSummary);

        Swimming swim = new Swimming();
        swim.SetDateTime(DateTime.Now);
        swim.SetDistance(1);
        swim.SetSpeed(3);
        swim.SetPace(1);
        swim.SetUnitOfMeasurement("lap");
        string _Swimsummary = swim.WriteSummary();
        Console.WriteLine(_Swimsummary);

        Cycling bike = new Cycling();
        bike.SetDateTime(DateTime.Now);
        bike.SetDistance(50);
        bike.SetSpeed(20);
        bike.SetPace(20);
        bike.SetUnitOfMeasurement("mile");
        string _bikeSummary = bike.WriteSummary();
        Console.WriteLine(_bikeSummary);
    }
}