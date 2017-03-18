using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIGaming.Core.Games;

public static class GameStateWrapper
{
	public static TexasHoldEmGameState THGS;

	public static Card ourCard(int x) {
		return THGS.playerHand[x-1];
	}
	public static Card tableCard(int x) {
		if (x == 1)
			return THGS.BoardCards.FirstOrDefault();
		if (x == 2)
			return THGS.BoardCards.SecondOrDefault();
		if (x == 3)
			return THGS.BoardCards.ThirdOrDefault();
		if (x == 4)
			return THGS.BoardCards.FourthOrDefault();
		if (x == 5)
			return THGS.BoardCards.FifthOrDefault();
	}
}