using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Ping : ModuleBase<SocketCommandContext>
    {

        [Command("Ping")]
        public async Task PingAsync()
        {
            await ReplyAsync(":white_circle: Pong");

        }

        [Command("Bitch")]
        public async Task BitchAsync()
        {
            await ReplyAsync("Queer");
        }
    }
}
