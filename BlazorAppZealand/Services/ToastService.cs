using System.Timers;
using Timer = System.Timers.Timer;

namespace BlazorAppZealand.Services;

public class ToastService : IDisposable
{
    public event Action<string, ToastLevel, string> OnShow;
    public event Action OnHide;
    private Timer Countdown;

    public void ShowToast(string message, ToastLevel level, string type)
    {
        OnShow?.Invoke(message, level, type);
        StartCountdown();
    }

    private void StartCountdown()
    {
        SetCountdown();

        if (Countdown.Enabled)
        {
            Countdown.Stop();
            Countdown.Start();
        }
        else
        {
            Countdown.Start();
        }
    }

    private void SetCountdown()
    {
        if (Countdown == null)
        {
            Countdown = new Timer(5000);
            Countdown.Elapsed += HideToast;
            Countdown.AutoReset = false;
        }
    }

    private void HideToast(object source, ElapsedEventArgs args)
    {
        OnHide?.Invoke();
    }

    public void Dispose()
    {
        Countdown?.Dispose();
    }
}