using CitizenFX.Core;
using CitizenFX.FiveM.Native;
using CitizenFX.Server.Native; // server
using CitizenFX.Shared.Native; // shared (for shared libraries)
using System;

namespace AnotherCfxFramework.Server
{
    public class Server : BaseScript
    {

        public static BaseScript instance { get; set; }

        public Server()
        {
            instance = this;
        }

        public void RegisterEventHandler(string name, Delegate action)
        {
            EventHandlers[name] += action;
        }
    }
}
