using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIGaming.Core.Games;
using AIGaming.Core.Games.Helpers;

public static class GameStateWrapper
{
	public static TexasHoldEmGameState THGS;

	public static Card ourCard(int x) {
		return THGS.PlayerHand[x-1];
	}
	public static Card tableCard(int x) {
        switch (x)
        {
            case 1:  return THGS.BoardCards.FirstOrDefault();
            case 2:  return THGS.BoardCards.SecondOrDefault();
            case 3:  return THGS.BoardCards.ThirdOrDefault();
            case 4:  return THGS.BoardCards.FourthOrDefault();
            case 5:  return THGS.BoardCards.FifthOrDefault();
            default: return null;
        }
	}
    public static int minBet(){
        return (THGS.OpponentRoundBetTotal ?? 0) - (THGS.PlayerRoundBetTotal ?? 0);
    }
    public static int maxBet(){
        return minBet() + THGS.OpponentStack;
    }
}