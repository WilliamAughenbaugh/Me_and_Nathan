using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class ServerControl : ModuleBase<SocketCommandContext>
    {

        [Command("Help")]
        public async Task Help()
        {
            var a = new Discord.EmbedBuilder();
            a.WithTitle("Commands");
            a.WithDescription("General Commands\n-- .help // Gives list of commands to use");
            Discord.IDMChannel gencom = await Context.Message.Author.GetOrCreateDMChannelAsync();
            await gencom.CloseAsync();
        }

        [Command("Nothing")]
        public async Task Nothing()
        {
            await ReplyAsync("Hey, y' Fuckin moron, enter a command...");
        }
    }
}
