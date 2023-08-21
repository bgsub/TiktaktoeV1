using System.ComponentModel.DataAnnotations;
using Tiktaktoe.Data.EnumsData;

namespace Tiktaktoe.Models
{
    public class Player
    {
        [Key]
        public string Name { get; set; }
        public string OpponentName { get; set; }
        public bool IsOpponentVirtual { get; set; }
        public GameMode GameMode { get; set; }
        public string GameDuration { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
        public int Score { get; set; }


    }
}
