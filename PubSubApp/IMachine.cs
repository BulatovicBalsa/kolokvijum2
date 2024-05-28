using System.Runtime.Serialization;
using System.ServiceModel;

namespace PubSubApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPubSubService" in both code and config file together.
    [ServiceContract]
    public interface IMachine
    {
        [OperationContract(IsOneWay = true)]
        void DrawLotteryNumbers(LotteryNumbers numbers);
    }

    [ServiceContract(CallbackContract = typeof(ICallbackSummary))]
    public interface IPlayer
    {
        [OperationContract(IsOneWay = true)]
        void InitPlayer(string username);

        [OperationContract]
        bool SubmitTicket(Ticket ticket);
    }

    [ServiceContract]
    public interface ICallbackSummary
    {
        [OperationContract(IsOneWay = true)]
        void SummaryArrived(Summary message);
    }

    [DataContract]
    public class Player
    {
        [DataMember] public string Name { get; set; }
        [DataMember] public double CumulativeStake { get; set; }
        [DataMember] public double Earnings { get; set; }
        public bool IsPlayingCurrentRound { get; set; }

        public void UpdateStats(Ticket ticket)
        {
            CumulativeStake += ticket.Stake;
            IsPlayingCurrentRound = true;
        }

        public override string ToString()
        {
            return $"{Name} - {CumulativeStake} - {Earnings}";
        }
    }

    [DataContract]
    public class Summary
    {
        [DataMember] public Player Player { get; set; }
        [DataMember] public int Rank { get; set; }
        [DataMember] public double CurrentTurnEarnings { get; set; }
        [DataMember] public int HitCount { get; set; }
    }

    [DataContract]
    public class Ticket
    {
        [DataMember] public string PlayerName { get; set; }
        [DataMember] public int Number1 { get; set; }
        [DataMember] public int Number2 { get; set; }
        [DataMember] public double Stake { get; set; }
    }

    [DataContract]
    public class LotteryNumbers
    {
        [DataMember] public int Number1 { get; set; }
        [DataMember] public int Number2 { get; set; }
    }
}