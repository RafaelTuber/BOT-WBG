using BOT_WBG.Discord;
using BOT_WBG.Discord.Entities;
using System;

namespace BOT_WBG
{
    class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord!");


            var botConfig = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}