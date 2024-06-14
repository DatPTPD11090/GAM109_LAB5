using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
   
    public class Program
    {
        public static void Main(string[] args)
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

            Console.WriteLine("Danh sách UserAccount ban dau:");
            foreach (var user in list)
            {
                Console.WriteLine($"{user.Name}, Rank: {user.Rank}, WinRate: {user.winRate}, Game: {user.Type}, Skin: {user.Skin}");
            }

            // Sắp xếp danh sách UserAccount theo “Rank” giảm dần
            var sortedByRank = list.OrderByDescending(u => u.Rank).ToList();
            Console.WriteLine("\nDanh sach UserAccount sap xep theo rank giam dan:");
            foreach (var user in sortedByRank)
            {
                Console.WriteLine($"{user.Name}, Rank: {user.Rank}, WinRate: {user.winRate}, Game: {user.Type}, Skin: {user.Skin}");
            }

            // Sắp xếp danh sách UserAccount theo “Name” và “Skin” giảm dần
            var sortedByNameAndSkin = list.OrderByDescending(u => u.Name).ThenByDescending(u => u.Skin).ToList();
            Console.WriteLine("\nDanh sach UserAccount sap xep theo Name và Skin giam dan:");
            foreach (var user in sortedByNameAndSkin)
            {
                Console.WriteLine($"{user.Name}, Rank: {user.Rank}, WinRate: {user.winRate}, Game: {user.Type}, Skin: {user.Skin}");
            }

            // Liệt kê danh sách các người có Name bắt đầu bằng ký tự “B”
            var startsWithB = list.Where(u => u.Name.StartsWith("B", StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nDanh sach UserAccount co ten bat dau bang ky tu 'B':");
            foreach (var user in startsWithB)
            {
                Console.WriteLine($"{user.Name}, Rank: {user.Rank}, WinRate: {user.winRate}, Game: {user.Type}, Skin: {user.Skin}");
            }
        }
    }
}

    

