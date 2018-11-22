using BOT_WBG.Discord;
using BOT_WBG.Discord.Entities;
using BOT_WBG.Storage;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace BOT_WBG
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord!");

            var storage = Unity.Resolve<IDateStorage>();

            var token = "ABC";
            storage.StoreObject(token, "Config/BotToken");

            System.Console.WriteLine("Feito");

            Console.ReadKey();
            return;
            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsyng(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
            // NDkxMDM1Nzg4NzkyOTU0ODgy.DtIYtQ.vnIuTMD-m5q9unJCASh3aVo1cpc
            Console.ReadKey();
        }
    }
}