namespace EventEaseApp.Data;

public class AttendanceService
{
    public int AttendingCount { get; private set; }

    public event Action? OnChange;

    public void Increment()
    {
        AttendingCount++;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
