using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Damage_Indicator
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Sets the message when someone join the server. ({player} will be replaced with the players name.)")]
        public string JoinedMessage { get; set; } = "{player} has joined the server!";

        [Description("Sets the message when someone leaves the server. ({player} will be replaced with the players name.)")]
        public string LeftMessage { get; set; } = "{player} has left the server.";
    }
}
