using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Tiktaktoe.Data.EnumsData;

namespace Tiktaktoe.Models
{
    public class PlayerModel
    {
        [Key]
        public string Name { get; set; }
        public string OpponentName { get; set; }
        public string GameDuration { get; set; }
        public string GridSize { get; set; }

        public GameMode GameMode { get; set; }
        
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
        public int Score { get; set; }
        public bool isOpponentVirtual { get; set; }

    }
}
