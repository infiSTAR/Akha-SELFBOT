
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Discord;
using Discord.Commands;
using System.Reflection;
using System.IO;

namespace Premium.Commands
{
    

        public class Price : ModuleBase<SocketCommandContext>
        {
            [Command("price"), Alias("prices", "pricess"), Summary("Price command")]
            public async Task Sjustein()
            {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Price of Skin Swapper");
            Embed.WithColor(40, 200, 150);
            Embed.WithFooter("Prices");
            Embed.WithDescription("Price of the current **premium version**.\n" +
                              "Lifetime: 7**€** (Paypal)\n" +
                              "Lifetime: 10**€** (Amazon & neosurf cards)" +
                              " " +
                              "Contact <@293050821506236428> to buy it");
            await Context.Channel.SendMessageAsync("", false, Embed.Build());

        }

       
        }
    }

