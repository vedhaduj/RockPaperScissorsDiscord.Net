 public class RockPaperScissors : ModuleBase<SocketCommandContext>
    {
        [Command("rps")]

        public async Task rps(params string[] args)
        {
            Random rand = new Random();
            int bot = rand.Next(1, 4);
            switch (bot)
            {
                case 1:
                    await ReplyAsync("Bot chose Rock!");
                    if (args.Contains<string>("Paper"))
                    {
                        await ReplyAsync("Bot Lost");
                    }
                    if (args.Contains<string>("Scissors"))
                    {
                        await ReplyAsync("Bot Won");
                    }
                    else if (args.Contains<string>("Rock"))
                    {
                        await ReplyAsync("Its a draw!");
                    }
                    break;
                case 2:
                    await ReplyAsync("Bot Chose Paper");
                    if (args.Contains<string>("Scissors"))
                    {
                        await ReplyAsync("Bot Lost");
                    }
                    if (args.Contains<string>("Rock"))
                    {
                        await ReplyAsync("Bot Won");
                    }
                    else if (args.Contains<string>("Paper"))
                    {
                        await ReplyAsync("Its a draw!");
                    }
                    break;
                case 3:
                    await ReplyAsync("Bot Chose Scissors");
                    if (args.Contains<string>("Rock"))
                    {
                        await ReplyAsync("Bot Lost");
                    }
                    if (args.Contains<string>("Paper"))
                    {
                        await ReplyAsync("Bot Won");
                    }
                    else if (args.Contains<string>("Scissors"))
                    {
                        await ReplyAsync("Its a draw!");
                    }
                    break;
                default:
                    Console.WriteLine("Bot error...");
                    break;        
            }
        }
    }
