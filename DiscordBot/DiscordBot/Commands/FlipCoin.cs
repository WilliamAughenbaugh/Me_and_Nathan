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
    public class FlipCoin : ModuleBase<SocketCommandContext>
    {
        [Command("Flip Coin")]
        [Alias("coinflip", "flip")]
        public async Task FlipCoinAsync()
        {
            int chance;
            Random random = new Random();
            chance = random.Next(0, 10);

            if (chance <= 5)
            {
                await ReplyAsync("You Flipped Heads");
            }
            else if(chance >=6)
            {
                await ReplyAsync("You Flipped Tails");
            }
        }
    }
}
