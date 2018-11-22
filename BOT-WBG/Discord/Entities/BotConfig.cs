using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOT_WBG.Discord.Entities
{
    class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
