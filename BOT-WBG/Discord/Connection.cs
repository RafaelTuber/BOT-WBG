using Discord.WebSocket;
using BOT_WBG.Discord.Entities;
using System.Threading.Tasks;

namespace BOT_WBG.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }
        internal async Task ConnectAsyng(BotConfig config)
        {
            _client.Log += _logger.Log;
            //Tudo: Continua
        }
    }
}
