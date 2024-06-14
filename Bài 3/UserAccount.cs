using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    public class UserAccount
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public float WinRate { get; set; }
        public string Game { get; set; }
        public int Skin { get; set; }

        public UserAccount(string name, int rank, float winRate, string game, int skin)
        {
            Name = name;
            Rank = rank;
            WinRate = winRate;
            Game = game;
            Skin = skin;
        }
    }
}
