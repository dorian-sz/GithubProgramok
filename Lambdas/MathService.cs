using System;
using System.Timers;

public class MathSerivce
{
    public event EventHandler<MathPerformedEventArgs> MathPerformed;

    public void MultiplyNumbers(double value1, double value2)
    {
        Timer timer = new Timer(500);
        MathPerformed(this, )
    }
}
