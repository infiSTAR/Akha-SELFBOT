
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Figgle;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Diagnostics;
using System.Threading;
using System.Configuration;




namespace Akha.Commands
{
    public class Commands : ModuleBase<SocketCommandContext>
    {

        private DiscordSocketClient Client;
        

        [Command("serveravatar")]
        public async Task testuser()
        {
            
 
                string avatar = Context.Guild.IconUrl;

                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);


            
            Console.WriteLine($"[COMMAND] The server {Context.Guild.Name} avatar link is: {avatar}");
            

        }


        [Command("test")]
        public async Task invisiblepfp()
        {

        }


        [Command("serverinfo")]
        public async Task soon()
        {
            
                string avatar = Context.Guild.IconUrl;

                EmbedBuilder builder = new EmbedBuilder();

                SocketGuild server = ((SocketGuildChannel)Context.Channel).Guild;

                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                builder.WithTitle("Server Infos");
                builder.WithThumbnailUrl(avatar);
                builder.AddInlineField("Name: ", $"      {server.Name}");    // true - for inline
                builder.AddInlineField("Owner: ", $"      {server.Owner}");    // true - for inline

                builder.AddInlineField("Members: ", $"      {server.MemberCount}");    // true - for inline
                builder.AddInlineField("Server ID: ", $"      {server.Id}");    // true - for inline
                builder.WithColor(Color.Gold);
                await Context.Channel.SendMessageAsync("", false, builder.Build());
            
        }

        [Command("credits")]
        public async Task credits()
        {
           

                SocketGuild server = ((SocketGuildChannel)Context.Channel).Guild;

                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
            Console.WriteLine("[COMMAND] Credits: Rzy#0002 - Developer of akha selfbot");
            
        }
      
           
            
        



        [Command("nuke")]
        public async Task nuke()
        {
         
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                var Message = await Context.Channel.SendMessageAsync(":bomb:------:fire: \n " +
                    ":bomb:------:fire: \n" +
                    ":bomb:------:fire: \n" +
                    ":bomb:------:fire:");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = ":bomb:-----:fire: \n" +
                ":bomb:-----:fire: \n" +
                ":bomb:-----:fire: \n" +
                ":bomb:-----:fire: ");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = ":bomb:----:fire: \n" +
              ":bomb:----:fire: \n" +
              ":bomb:----:fire: \n" +
              ":bomb:----:fire: ");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = ":bomb:---:fire: \n" +
              ":bomb:---:fire: \n" +
              ":bomb:---:fire: \n" +
              ":bomb:---:fire:");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = ":bomb:--:fire: \n" +
              ":bomb:--:fire: \n" +
              ":bomb:--:fire: \n" +
              ":bomb:--:fire:");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = ":bomb:-:fire: \n" +
          ":bomb:-:fire: \n" +
          ":bomb:-:fire: \n" +
          ":bomb:-:fire:");
                Thread.Sleep(1000);

                await Message.ModifyAsync(msg => msg.Content = ":boom: \n" +
          ":boom: \n" +
          ":boom: \n" +
          ":boom:");
                Thread.Sleep(1000);
                var messagess = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messagess);

            
        }

        [Command("123")]
        public async Task unedeuxtrois()
        {
          
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                var Message = await Context.Channel.SendMessageAsync("1");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "2");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "3");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "4");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "5");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "6");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "7");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "8");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "9");
                Thread.Sleep(1000);
                await Message.ModifyAsync(msg => msg.Content = "10");
                Thread.Sleep(2000);
                await this.Context.Channel.DeleteMessagesAsync(messages);

            
        }

        [Command("321")]
        public async Task troisdeuxun([Remainder]string args)
        {

            var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
            await this.Context.Channel.DeleteMessagesAsync(messages);
            var Message = await Context.Channel.SendMessageAsync("3");
            Thread.Sleep(1000);
            await Message.ModifyAsync(msg => msg.Content = "2");
            Thread.Sleep(1000);
            await Message.ModifyAsync(msg => msg.Content = "1");
            Thread.Sleep(1000);
            await Message.ModifyAsync(msg => msg.Content = args);

            Thread.Sleep(2000);
            await this.Context.Channel.DeleteMessagesAsync(messages);


        }




        [Command("abc")]
        public async Task abc()
        {
           
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                var Message = await Context.Channel.SendMessageAsync("a");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "b");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "c");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "d");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "e");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "f");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "g");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "h");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "i");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "j");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "k");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "l");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "m");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "n");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "o");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "p");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "q");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "r");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "s");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "t");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "u");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "v");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "w");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "x");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "y");
                Thread.Sleep(500);
                await Message.ModifyAsync(msg => msg.Content = "z");

                Thread.Sleep(2000);
                await this.Context.Channel.DeleteMessagesAsync(messages);
            
        }


        [Command("ping")]
        [Alias("latency")]
        [Summary("Shows the websocket connection's latency and time it takes for me send a message.")]
        public async Task PingAsync()
        {
          

                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                var sw = Stopwatch.StartNew();

                var msg = await ReplyAsync($"**Websocket latency**: {Context.Client.Latency}ms\n");
                sw.Stop();

                await msg.ModifyAsync(x => x.Content = $"**Websocket latency**: {Context.Client.Latency}ms\n");
            
        }

        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        [RequireBotPermission(GuildPermission.KickMembers)]
        public async Task KickUser(IGuildUser user, string reason = "No reason provided.")
        {
            
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                await user.KickAsync(reason);
            Console.WriteLine($"[LOG] {DateTime.Now} {user} was successfully kicked from the server !");


        }

        [Command("time")]
        public async Task time()
        {
           
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                await Context.Channel.SendMessageAsync(":watch: Current time for " + Context.Client.CurrentUser.Username + " is **" + DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "**");
            
        }

        [Command("ascii")]
        public async Task ascii([Remainder]string args)
        {


            var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
            await this.Context.Channel.DeleteMessagesAsync(messages);
            await Context.Channel.SendMessageAsync("```" + FiggleFonts.Standard.Render(args) + "```");

            
        }


        [Command("playing")]
        public async Task play([Remainder]string args)
        {

            var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
            await this.Context.Channel.DeleteMessagesAsync(messages);
            await (Context.Client as DiscordSocketClient).SetGameAsync(args);
            Console.WriteLine($"[COMMAND] {DateTime.Now} Game set to `{args}`.");

        }

    


        [Command("streaming")]
        public async Task stream([Remainder]string args)
        {
            var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
            await this.Context.Channel.DeleteMessagesAsync(messages);
            await (Context.Client as DiscordSocketClient).SetGameAsync(args, "https://twitch.tv/solaryfortnite",
  StreamType.Twitch);
            Console.WriteLine($"[COMMAND] {DateTime.Now} Stream set to `{args}`.");
        }


        [Command("tcolor")]
        public async Task tcolor(string args, [Remainder]string args2)
        {
            
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);

                if (args2.Length > 1)
                {
                    if (args.Equals("orange"))
                    {

                        await Context.Channel.SendMessageAsync("```fix\n" + args2 + "```");
                    }
                    else if (args == "green")
                    {

                        await Context.Channel.SendMessageAsync("```css\n" + args2 + "```");

                    }
                    else if (args.Equals("cyan"))
                    {

                        await Context.Channel.SendMessageAsync("```yaml\n" + args2 + "```");
                    }
                    else if (args.Equals("red"))
                    {

                        await Context.Channel.SendMessageAsync("```diff\n" + "- " + args2 + "```");
                    }


                    else
                    {

                        await Context.Channel.SendMessageAsync("**Invalid** color ! Colors available: orange, green, cyan, red.");


                    
                }
            }
        }





        [Command("avatar")]
        public async Task pfp(IGuildUser user)
        {
         

                string avatar = user.GetAvatarUrl();
            var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
            await this.Context.Channel.DeleteMessagesAsync(messages);

            Console.WriteLine($"[COMMAND] The {user} avatar link is: {avatar}");

        }



        [Command("embed")]
        [Summary("Embed your message.")]
        public async Task embed([Remainder]string args)
        {

            try
            {
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);
                EmbedBuilder eb = new EmbedBuilder();
                eb.WithFooter(footer => footer.Text = "Akha SelfBOT");
                eb.WithAuthor(Context.Client.CurrentUser);
                eb.WithColor(Color.Gold);
                eb.WithCurrentTimestamp();
                eb.WithTitle(args);
                await Context.Channel.SendMessageAsync("", false, eb);
            }
            catch (Exception)
            {

                Console.WriteLine($"[LOG] {DateTime.Now} Missing permissions.");

            }
            
        }


        [Command("author")]
        public async Task author()
        {
          
                var messages = await this.Context.Channel.GetMessagesAsync((int)0 + 1).Flatten();
                await this.Context.Channel.DeleteMessagesAsync(messages);

            Console.WriteLine("[COMMAND] Made by Rzy#0002 with <3 : https://discord.gg/KGBHq9S");

            
        }






        [Command("close")]
        public async Task close()
        {
           
                Environment.Exit(0);
            
        }


        [Command("clear")]
        [Summary("Deletes the specified amount of messages.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireBotPermission(ChannelPermission.ManageMessages)]
        public async Task PurgeChat(int amount)
        {
          
                IEnumerable<IMessage> messages = await Context.Channel.GetMessagesAsync(amount + 1).Flatten();
                await ((ITextChannel)Context.Channel).DeleteMessagesAsync(messages);
                const int delay = 1500;
                await Task.Delay(delay);
               
            Console.WriteLine($"[COMMAND] {DateTime.Now} Deleted {amount}.");



        }

        [Command("poll")]
        [Summary("Creates a pool that people can respond to via reactions. Usage: `a.poll write what u want`")]
        [RequireBotPermission(ChannelPermission.AddReactions)]
        public async Task CreatePoll([Remainder, Summary("Creates a message with a question and several reaction options.")] string input)
        {
            const int REGIONAL_INDICATOR_A = 0x1F1E6;
            
            var THUMBS_UP = new Emoji("👍");
            var THUMBS_DOWN = new Emoji("👎");
            var CLIPBOARD = new Emoji("📋");
            

            var split = input.Split('|');

            if (split.Length == 1)
            {
                await Context.Message.ModifyAsync(m => m.Content = $"{CLIPBOARD}{Format.Italics(split[0])}");
                await Context.Message.AddReactionAsync(THUMBS_UP);
                await Context.Message.AddReactionAsync(THUMBS_DOWN);
            }
            else
            {
                var pollBuilder = new StringBuilder($"{CLIPBOARD}{Format.Italics(split[0])}\n");
                var emojiList = new List<string>();

                for (int i = 1; i < split.Length; i++)
                {
                    string currentEmoji = char.ConvertFromUtf32(REGIONAL_INDICATOR_A + i - 1);
                    pollBuilder.AppendLine($"{currentEmoji} {split[i]}");
                    emojiList.Add(currentEmoji);
                }

             
            }
        }

        public static String GetRandomString()
        {
            var allowedChars = "ABCDEFGHIJKLMOPKRSTUVWXYZ123456789";
            var length = 25;

            var chars = new char[length];
            var rd = new Random();

            for (var i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new String(chars);

        }



       


    }


    }

