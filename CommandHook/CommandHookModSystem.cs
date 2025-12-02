using Vintagestory.API.Server;
using Vintagestory.API.Common;

namespace CommandHook;

public class CommandHookModSystem : ModSystem
{

    public override bool ShouldLoad(EnumAppSide forSide)
    {
        return forSide == EnumAppSide.Server;
    }


    public override void StartServerSide(ICoreServerAPI api)
    {
        Mod.Logger.Notification("Loaded");
    }

}
