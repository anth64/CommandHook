using Vintagestory.API.Server;

namespace CommandHook;

public class CommandData
{
    public IServerPlayer? Sender { get; }
    public string FullCommand { get; }
    public bool IsPlayerCommand { get; }
    public bool Cancel { get; set; }


    public CommandData(IServerPlayer sender, string fullCommand)
    {
        Sender = sender;
        IsPlayerCommand = Sender != null;
        FullCommand = fullCommand?.Trim() ?? string.Empty;
        Cancel = false;
    }
}
