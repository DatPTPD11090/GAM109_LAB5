using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    
    public class UserAccount
    {
        public string Name;
        public int Rank;
        public float winRate;
        public string Type;
        public int Skin;

        public UserAccount(string name, int rank, float winrate, string type, int skin)
        {
            Name = name;
            Rank = rank;
            winRate = winrate;
            Type = type;
            Skin = skin;
        }
    }
    
}

