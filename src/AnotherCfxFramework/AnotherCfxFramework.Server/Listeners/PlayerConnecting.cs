using CitizenFX.Core;
using CitizenFX.Server;
using CitizenFX.Server.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherCfxFramework.Server.Listeners
{
    internal class PlayerConnecting
    {

        [EventHandler("playerConnecting")]
        public async void Connecting([Source] Player player, string playerName, dynamic setKickReason,
            dynamic deferrals)
        {
            deferrals.defer();

            await Task.Delay(0);

            var discordId = Natives.GetPlayerIdentifierByType(CString.Create(player.Handle.ToString()), "discord").ToString();
            var steamId = Natives.GetPlayerIdentifierByType(CString.Create(player.Handle.ToString()), "steam").ToString();

            Console.WriteLine(discordId + " " + steamId);
            //var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.DiscordId == discordId);
            //if (user is null)
            //{
            //    deferrals.done("no user exists");
            //}

            //deferrals.done("nara");
        }
    }
}
