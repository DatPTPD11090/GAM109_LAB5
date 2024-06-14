using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserAccount> list = new List<UserAccount>();
            list.Add(new UserAccount("Son Tung", 10, 55.5f, "Ca nhac", 50));
            list.Add(new UserAccount("MCK", 6, 90, "Rapper", 10));
            list.Add(new UserAccount("Den Vau", 5, 70, "Ca Nhac", 25));
            list.Add(new UserAccount("MixiGaming", 2, 90, "Streamer", 274));
            list.Add(new UserAccount("PewPew", 4, 55.5f, "Vua ban hang online", 50));
            list.Add(new UserAccount("TrucTiepGame", 1, 92, "GOAT Streamer", 40));
            list.Add(new UserAccount("LOL", 1, 85.5f, "Game", 1424));
            list.Add(new UserAccount("Counter Strike 2", 2, 80, "Game", 10000));
            list.Add(new UserAccount("PUBG PC", 5, 70, "Game", 210));

            var lookupByGame = list.ToLookup(user => user.Game);

            // Xuất thông tin ra màn hình
            foreach (var group in lookupByGame)
            {
                Console.WriteLine($"Game: {group.Key}, Count: {group.Count()}");
                foreach (var user in group)
                {
                    Console.WriteLine($"\tName: {user.Name}, Rank: {user.Rank}, WinRate: {user.WinRate}, Skin: {user.Skin}");
                }
            }
        }
    }
 }

