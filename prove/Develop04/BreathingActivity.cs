public class BreathingActivity : Activity
{
    public  BreathingActivity(string name,string description):base( name, description)
    {
    }

    public void Run()
    {
        int timeLeft = _duration; // Variable local para realizar el conteo
        while (timeLeft > 0)
        {
            // Breathing phase: inhale
            for (int i = 4; i >= 0 && timeLeft > 0; i--) 
            {
                Console.Write($"Breathe in...{i}  ");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                timeLeft--;
            }

            // Breathing phase: exhale
            if (timeLeft <= 0) break; 
            for (int i = 6; i >= 0 && timeLeft > 0; i--) 
            {
                Console.Write($"Breathe out...{i}  ");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                timeLeft--;
            }
                if (timeLeft <= 0) break;
        }
        Console.WriteLine(" ");
    }
}