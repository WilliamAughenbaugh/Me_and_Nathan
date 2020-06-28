using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class RollDice : ModuleBase<SocketCommandContext>
    {

        [Command("Roll Dice")]
        [Alias("roll", "dice", "rolldice")]
        public async Task RollDiceAsync()
        {
            int roll;
            Random random = new Random();
            roll = random.Next(0, 12);

            if(roll <= 6)
            {
                await ReplyAsync("You Rolled a " + roll + ":game_die:");
            }

            if (roll >= 7)
            {
                await ReplyAsync("You Rolled a " + roll + ":game_die::game_die: ");

            }
        }

        [Command("Random Number")]
        [Alias("rnd", "random", "randomnumber")]
        public async Task ChamsShitScore()
        {
            int Score;
            Random random = new Random();
            Score = random.Next(0, 16);
            await ReplyAsync(Score.ToString());
        }
    }
}
