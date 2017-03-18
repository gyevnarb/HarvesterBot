using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using AIGaming.Client;
using AIGaming.Core.Environment;
using AIGaming.Core.Games;
using TexasHold.Annotations;

namespace TexasHoldEm
{
    public partial class TexasHoldEmDesk : GameClientDeskBase, INotifyPropertyChanged
    {
        public override void Reset()
        {
            IsShow = Visibility.Hidden;
            PlayerHand = null;
            OpponentHand = null;
            BoardCards = null;
            IsDealer = false;
            PotAfterPreviousRound = 0;
            PlayerStack = 0;
            PlayerBet = null;
            OpponentStack = 0;
            OpponentBet = null;
            CurrentDealNumber = 0;
            DealCount = 0;
            PlayerDealResult = null;
            OpponentDealResult = null;
        }

        public override void ShowMove(GameStateBase response)
        {
            if (IsShow == Visibility.Hidden)
            {
                IsShow = Visibility.Visible;
            }

            var state = (TexasHoldEmGameState)response;

            PlayerStack = state.PlayerStack;
            PlayerBet = state.PlayerRoundBetTotal;
            PlayerHand = new ObservableCollection<Card>(state.PlayerHand);

            OpponentStack = state.OpponentStack;
            OpponentBet = state.OpponentRoundBetTotal;
            OpponentHand = new ObservableCollection<Card>(state.OpponentHand);

            BoardCards = new ObservableCollection<Card>(state.BoardCards);

            IsDealer = state.IsDealer;
            CurrentDealNumber = state.DealNumber;
            DealCount = state.DealCount;
            PotAfterPreviousRound = state.PotAfterPreviousRound;

            PlayerDealResult = state.PlayerDealResult;
            OpponentDealResult = state.OpponentDealResult;

        }

        public override void Clear()
        {
            IsShow = Visibility.Hidden;
        }

        private bool _isDealer;
        public bool IsDealer
        {
            set
            {
                _isDealer = value;
                OnPropertyChanged();
            }
            get { return _isDealer; }
        }

        private ObservableCollection<Card> _playerHand;
        public ObservableCollection<Card> PlayerHand
        {
            set
            {
                _playerHand = value;
                OnPropertyChanged();
            }
            get
            {
                if (_playerHand == null)
                {
                    _playerHand = new ObservableCollection<Card>();
                }
                return _playerHand;
            }
        }

        private ObservableCollection<Card> _opponentHand;
        public ObservableCollection<Card> OpponentHand
        {
            set
            {
                _opponentHand = value;
                OnPropertyChanged();
            }
            get
            {
                if (_opponentHand == null)
                {
                    _opponentHand = new ObservableCollection<Card>();
                }
                return _opponentHand;
            }
        }

        private ObservableCollection<Card> _boardCards;
        public ObservableCollection<Card> BoardCards
        {
            set
            {
                _boardCards = value;
                OnPropertyChanged();
            }
            get
            {
                if (_boardCards == null)
                {
                    _boardCards = new ObservableCollection<Card>();
                }
                return _boardCards;
            }
        }

        private int _dealCount;
        public int DealCount
        {
            set
            {
                _dealCount = value;
                OnPropertyChanged();
            }
            get { return _dealCount; }
        }

        private int _currentDealNumber;
        public int CurrentDealNumber
        {
            set
            {
                _currentDealNumber = value;
                OnPropertyChanged();
            }
            get { return _currentDealNumber; }
        }

        private int _playerStack;
        public int PlayerStack
        {
            set
            {
                _playerStack = value;
                OnPropertyChanged();
            }
            get { return _playerStack; }
        }

        private int _opponentStack;
        public int OpponentStack
        {
            set
            {
                _opponentStack = value;
                OnPropertyChanged();
            }
            get { return _opponentStack; }
        }

        private int? _playerBet;
        public int? PlayerBet
        {
            set
            {
                _playerBet = value;
                OnPropertyChanged();
            }
            get { return _playerBet; }
        }

        private int? _opponentBet;
        public int? OpponentBet
        {
            set
            {
                _opponentBet = value;
                OnPropertyChanged();
            }
            get { return _opponentBet; }
        }

        
        private DealResult? _playerDealResult;
        public DealResult? PlayerDealResult
        {
            set
            {
                _playerDealResult = value;
                OnPropertyChanged();
            }
            get { return _playerDealResult; }
        }

        private DealResult? _opponentDealResult;
        public DealResult? OpponentDealResult
        {
            set
            {
                _opponentDealResult = value;
                OnPropertyChanged();
            }
            get { return _opponentDealResult; }
        }

        private int _potAfterPreviousRound;
        public int PotAfterPreviousRound
        {
            set
            {
                _potAfterPreviousRound = value;
                OnPropertyChanged();
            }
            get { return _potAfterPreviousRound; }
        }

        public TexasHoldEmDesk()
        {
            InitializeComponent();
        }

        private Visibility _isShow = Visibility.Hidden;
        public Visibility IsShow
        {
            set
            {
                _isShow = value;
                OnPropertyChanged();
            }
            get { return _isShow; }
        }

        [NotifyPropertyChangedInvocator]
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}