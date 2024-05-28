using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace PubSubApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MachinePlayerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MachinePlayerService.svc or MachinePlayerService.svc.cs at the Solution Explorer and start debugging.

    public class MachinePlayerService : IMachine, IPlayer
    {
        private static readonly Dictionary<string, ICallbackSummary> Callbacks = new Dictionary<string, ICallbackSummary>();
        private static readonly Dictionary<string, Player> Players = new Dictionary<string, Player>();
        private static readonly List<Ticket> Tickets = new List<Ticket>();

        public void DrawLotteryNumbers(LotteryNumbers numbers)
        {
            var playerEarnings = new Dictionary<string, double>();
            var playerHitCount = new Dictionary<string, int>();

            foreach (var ticket in Tickets)
            {
                var earning = 0.0;
                var hitCount = 0;
                if (ticket.Number1 == numbers.Number1) hitCount++;
                if (ticket.Number2 == numbers.Number2) hitCount++;

                switch (hitCount)
                {
                    case 0:
                        earning = -ticket.Stake;
                        break;
                    case 1:
                        earning = 0;
                        break;
                    case 2:
                        earning = ticket.Stake * 5;
                        break;
                }

                playerEarnings[ticket.PlayerName] = earning;
                playerHitCount[ticket.PlayerName] = hitCount;
                Players[ticket.PlayerName].Earnings += earning;
            }

            var rankedPlayers = Players.Values.OrderByDescending(p => p.Earnings).ToList();

            Players.Values.ToList().Where(p => p.IsPlayingCurrentRound).ToList().ForEach(p => Callbacks[p.Name]
                .SummaryArrived(new Summary
                {
                    Player = p,
                    Rank = rankedPlayers.IndexOf(p) + 1,
                    CurrentTurnEarnings = playerEarnings[p.Name],
                    HitCount = playerHitCount[p.Name]
                }));

            Players.Values.ToList().ForEach(p => p.IsPlayingCurrentRound = false);
            Tickets.Clear();
        }

        public void InitPlayer(string name)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICallbackSummary>();
            Callbacks[name] = callback;
            if (Players.ContainsKey(name)) return;

            Players.Add(name, new Player { Name = name });
        }

        public bool SubmitTicket(Ticket ticket)
        {
            if (!Players.ContainsKey(ticket.PlayerName)) return false;
            if (Players[ticket.PlayerName].IsPlayingCurrentRound) return false;

            Tickets.Add(ticket);
            Players[ticket.PlayerName].UpdateStats(ticket);
            return true;
        }
    }
}