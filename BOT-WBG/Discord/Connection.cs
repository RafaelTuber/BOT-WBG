using Discord.WebSocket;
using BOT_WBG.Discord.Entities;

namespace BOT_WBG.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;
        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }
        internal void ConnectAsyng(BotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);
            _client.Log += _logger.Log;
            //Tudo: Continua
        }
    }
}
