using System.Timers;
using Content.Shared.Damage.Components;

public sealed class FTLTimer
{
    private static System.Timers.Timer? _aTimer;
    public static bool IsDone = false;
    public static void SetTimer(float seconds)
    {
        _aTimer = new System.Timers.Timer(seconds * 1000);
        Logger.DebugS("timer", $"timer has started");
        _aTimer.Elapsed += TimerIsDone;
        _aTimer.AutoReset = true;
        _aTimer.Enabled = true;
    }

    public static void TimerIsDone(Object? source, ElapsedEventArgs e)
    {
        if (_aTimer != null)
        {
            _aTimer.Stop();
            _aTimer.Dispose();
            IsDone = true;
        }
    }
}
