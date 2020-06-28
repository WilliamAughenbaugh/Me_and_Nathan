using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiscordBot;

namespace DiscordBot.Commands
{
    public class Yeet : ModuleBase<SocketCommandContext>
    {
        [Command("This Bitch Empty")]
        public async Task YeetAsync()
        {
            await ReplyAsync("Yeet");
        }
    }
}
