using FifaScrape.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaScrape.DataHolders
{
    class ItemLists
    {
        private static SortedDictionary<int, Club> clubs = new SortedDictionary<int, Club>();
        private static SortedDictionary<int, Player> players = new SortedDictionary<int, Player>();
        private static SortedDictionary<int, Nation> nations = new SortedDictionary<int, Nation>();
        private static SortedDictionary<int, League> leagues = new SortedDictionary<int, League>();

        static object clubLock = new object();
        static object playerLock = new object();
        static object nationLock = new object();
        static object leagueLock = new object();

        public static void AddClub(Club c)
        {
            lock (clubLock)
            {
                if (!clubs.ContainsKey(c.id))
                {
                    clubs.Add(c.id, c);
                }
            }
        }

        public static void AddPlayer(Player p)
        {
            lock (playerLock)
            {
                if (!players.ContainsKey(p.Id))
                {
                    players.Add(p.Id, p);
                }
            }
        }

        public static void AddLeague(League l)
        {
            lock (leagueLock)
            {
                if (!leagues.ContainsKey(l.id))
                {
                    leagues.Add(l.id, l);
                }
            }
        }

        public static void AddNation(Nation n)
        {
            lock (nationLock)
            {
                if (!nations.ContainsKey(n.id))
                {
                    nations.Add(n.id, n);
                }
            }
        }

        public static SortedDictionary<int, Player> GetPlayers()
        {
            lock(playerLock)
            {
                return players;
            }
        }
    }
}
