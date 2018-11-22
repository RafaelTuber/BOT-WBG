using BOT_WBG.Storage;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace BOT_WBG
{
    class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord!");
        }
    }
}
