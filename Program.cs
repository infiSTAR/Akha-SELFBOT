using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading;
using System.Configuration;
using System.Windows;

namespace Akha
{
    class Program: ModuleBase<SocketCommandContext>
    {

        private DiscordSocketClient Client;
        private CommandService Commands;



        static void Main(string[] args)


            
            => new Program().MainAsync().GetAwaiter().GetResult();


        private async Task MainAsync()
        {
            Console.Title = "Shell SelfBOT";
      
            
           
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {

                LogLevel = LogSeverity.Debug
            });

            //help
            Commands = new CommandService(new CommandServiceConfig
            {

                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug

            });

            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly());

            Client.Ready += Client_Ready;
            Client.Log += Client_Log;

            string Token = "";

            Console.Clear();

            //  string textToEnter10 = "Username                        Status";
            // string textToEnter20 = $"{Client.CurrentUser.Username}                             {Client.CurrentUser.Status}";



            

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("");
            Console.WriteLine("");
            string textToEnter1 = "   ▄████████    ▄█    █▄       ▄████████  ▄█        ▄█       ";
            string textToEnter2 = "  ███    ███   ███    ███     ███    ███ ███       ███       ";
            string textToEnter3 = "  ███    █▀    ███    ███     ███    █▀  ███       ███       ";
            string textToEnter4 = "  ███         ▄███▄▄▄▄███▄▄  ▄███▄▄▄     ███       ███       ";
            string textToEnter5 = "▀███████████ ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ███       ███       ";
            string textToEnter6 = "         ███   ███    ███     ███    █▄  ███       ███       ";
            string textToEnter7 = "   ▄█    ███   ███    ███     ███    ███ ███▌    ▄ ███▌    ▄ ";
            string textToEnter8 = " ▄████████▀    ███    █▀      ██████████ █████▄▄██ █████▄▄██ ";
            string textToEnter9 = "                                         ▀         ▀         ";
            var prfx = ConfigurationManager.AppSettings["prefix"];

            Console.WriteLine("                                 " + textToEnter1);
            Console.WriteLine("                                 " + textToEnter2);
            Console.WriteLine("                                 " + textToEnter3);
            Console.WriteLine("                                 " + textToEnter4);
            Console.WriteLine("                                 " + textToEnter5);
            Console.WriteLine("                                 " + textToEnter6);
            Console.WriteLine("                                 " + textToEnter7);
            Console.WriteLine("                                 " + textToEnter8);
            Console.WriteLine("                                 " + textToEnter9);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            

        //    Console.WriteLine("Send your user token below: \nINFO: Right click or ctrl+v to paste it. Your token will be hiden.");
           // Console.ForegroundColor = ConsoleColor.Black;

          //  string tks = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"[LOG] {DateTime.Now} Connecting to the bot.");



            var tkn = ConfigurationManager.AppSettings["token"];

            try
            {
                await Client.LoginAsync(TokenType.User, tkn);
            }
            catch
            {

                Console.WriteLine("INVALID TOKEN NIGGA");

            }
          
       

            await Client.StartAsync();

           

            await Task.Delay(-1);

        }



        private async Task Client_Log(LogMessage Message)
        {
            //Console.WriteLine($"{DateTime.Now} at {Message.Source}] {Message.Message}");
        }

        private async Task Client_Ready()
        {
            var prfx = ConfigurationManager.AppSettings["prefix"];
            Console.WindowHeight = 50;

            Console.WriteLine($"[LOG] {DateTime.Now} Loading akha config.");
            Thread.Sleep(750);
            Console.WriteLine($"[LOG] {DateTime.Now} Connected as {Client.CurrentUser.Username}.");
            Thread.Sleep(750);
            Console.WriteLine($"[LOG] {DateTime.Now} You can now use the bot.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Features");
            Console.WriteLine($"  clear             - {prfx}purge 'amount of messages' , delete X messages on a channel.");
            Console.WriteLine("  embed             - Embed your message **You can only embed with 1 word, if there are space it will  not work.");
            Console.WriteLine("  serveravatar      - Get a server avatar url  ");
            Console.WriteLine("  serverinfo        - Get a server informations");
            Console.WriteLine("  ping              - Shows the websocket connection's latency");
            Console.WriteLine("  avatar            - Get the pfp of the mentionned user");
            Console.WriteLine("  tcolor            - To make your message in color. Color available: orange, green, cyan, red.");
            Console.WriteLine("  ascii             - Convert text to ascii text.");
            Console.WriteLine("  poll              - Create a easy poll with 2 reactions.");
            Console.WriteLine("  playing           - Set your status to playing.");
            Console.WriteLine("  streaming         - Set your status to streaming.");
            Console.WriteLine($"  321              - {prfx}321 'msg' , Edits message from 3-2-1-yourmsg.");
            Console.WriteLine("Misc");
            Console.WriteLine("  close             - Close the bot.");
            Console.WriteLine("  help              - Get all commands for the selfbot");
            Console.WriteLine("  abc               - Edits message from A-Z");
            Console.WriteLine("  123               - Edits message from 1-10");
            Console.WriteLine("  author            - Shows dev contact info.");
            Console.WriteLine("  nuke              - Little nuke animation.");
            Console.WriteLine("  time              - Get your current time.");
            Console.WriteLine("  credits           - Show the credits.");


            Console.WriteLine($"Prefix for commands: '{prfx}'");
            Console.WriteLine("");
            Console.WriteLine("");
     

        }






        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);

            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.User.IsBot) return;

            int ArgPos = 0;
            var prfx = ConfigurationManager.AppSettings["prefix"];
            var wl1 = ConfigurationManager.AppSettings["whitelist1"];

            if (!(Message.HasStringPrefix(prfx, ref ArgPos) || Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))) return;

            if ((Context.User.Id.Equals(Client.CurrentUser.Id)))
            {



                var Result = await Commands.ExecuteAsync(Context, ArgPos);
                if (!Result.IsSuccess)


                    Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {Context.Message.Content} | Error: {Result.ErrorReason}");

                
            }
            else
            {

             

            }

        }
    }
}


