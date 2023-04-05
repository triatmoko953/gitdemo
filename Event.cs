public class Event
{
    public event EventHandler<string> Process;

    public void TriggerEvent(string pesan)
    {
        OnProcess(pesan);
    }

    protected virtual void OnProcess(string pesan)
    {
        Process?.Invoke(this, pesan);
    } 
}