using AIGaming.Core.Games;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Bot {

	public static bool betOrFold(Gene gene) {
		// True is bet, False is fold
		double stateEval = gene.get(0) * handValuation(gene);
		return stateEval > gene.get(1);
	}

	public static int makeBet(Gene gene) {
		// returns the ammount to bet
		double betEval = Math.Pow(gene.get(2) * gameValuation(gene) / 7.5, 2);
		return ((int) betEval * (GameStateWrapper.maxBet() - GameStateWrapper.minBet())) + GameStateWrapper.minBet();
	}

	public static double handValuation(Gene gene) {
		return gene.get(3) * (double) GameStateWrapper.ourCard(1).Index + gene.get(4) * (double) GameStateWrapper.ourCard(2).Index + gene.get(5) * similarity(GameStateWrapper.ourCard(1), GameStateWrapper.ourCard(2));
	}

	private static double gameValuation(Gene gene) {
		return handValuation(gene) + ((GameStateWrapper.shownCards() > 0) ? shownValuation(gene, GameStateWrapper.shownCards()) : 0.0);
	}

	private static double shownValuation(Gene gene, int state) {
		double sum = 0;
		for (int i = 0; i < state; i++) {
			sum += gene.get(6 + (2 * i)) * similarity(GameStateWrapper.tableCard(i + 1), GameStateWrapper.ourCard(1)) + gene.get(7 + (2 * i)) * similarity(GameStateWrapper.tableCard(i + 1), GameStateWrapper.ourCard(2));
		}
		return sum;
	}

	private static double similarity(Card cardA, Card cardB) {
		if (cardA.Index.Equals(cardB.Index))
			return 1.0;
		if (cardA.Suit.Equals(cardB.Suit))
			return 0.5 + Math.Abs(cardA.Index - cardB.Index) <= 1 ? 0.25 : 0.0;
		if (Math.Abs(cardA.Index - cardB.Index) <= 1) {
			return 0.5;
		}
		return 0.0;
	}

	private static double getEnemyWinProb() {
        // Returns the probability of the enemy winning
        return 0.50;
	}

	private static double getSelfWinProb() {
        // Returns the probability of us winning

        
        double ourStraightFlushChance = calculateStraightFlushChance();
        double ourFourKindChance = calculateFourKindChance();
        double ourFullHouseChance = calculateFullHouseChance();
        double ourFlushChance;
        double ourStraightChance;
        double ourThreeKindChance;
        double ourTwoChance;
        double ourOneChance;
        double ourNoChance;

        
        double theirStraightFlushChance;
        double theirFourKindChance;
        double theirFullHouseChance;
        double theirFlushChance;
        double theirStraightChance;
        double theirThreeKindChance;
        double theirTwoChance;
        double theirOneChance;
        double theirNoChance;



        return 0.50;
	}

    //leaving out royal flush because yoloswag420#blazeit
    private static double calculateStraightFlushChance()
    {

        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.0000139;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.0000080;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.0000070;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.9999;
        }
        else return 1;



    }
    private static double calculateFourKindChance()
    {

        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.00024;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.00015;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.00013;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.9999;
        }
        else return 1;



    }
    private static double calculateFullHouseChance()
    {


        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.001441;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.0008;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.0007;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.9999;
        }
        else return 1;


    }
    private static double calculateFlushChance()
    {

        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.001965;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.0012;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.0011;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.9999;
        }
        else return 1;


    }
    private static double calculateStraightChance()
    {

        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.0039;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.0023;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.002;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.99;
        }
        else return 1;


    }
    private static double calculateThreeKindChance()
    {

        if (GameStateWrapper.THGS.Round.Equals("Preflop"))
        {
            return 0.021128;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Flop"))
        {
            return 0.013;
        }
        else if (GameStateWrapper.THGS.Round.Equals("Turn"))
        {
            return 0.01;
        }
        else if (GameStateWrapper.THGS.Round.Equals("River"))
        {
            return 0.97;
        }
        else return 1;


    }

    private static double calculateOneChance()
    {
        if (GameStateWrapper.ourCard(1).Index == GameStateWrapper.ourCard(2).Index)
        {
            return 1;
        }
        else
        {

            if (GameStateWrapper.THGS.Round == TexasHoldEmRound.Preflop)
            {
                return 0.422;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Flop") && hasOneChance("Flop"))
            {
                return 0.23;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Turn") && hasOneChance("Turn"))
            {
                return 0.19;
            }
            else if (GameStateWrapper.THGS.Round.Equals("River") && hasOneChance("River"))
            {
                return 0;
            }
            else return 1;




        }

    }

    private static bool hasOneChance(string state)
    {
               if (state == "Flop")
        {
            if (GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(1) || GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(2)
                    || GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(3) || GameStateWrapper.ourCard(2) == GameStateWrapper.tableCard(1)
                    || GameStateWrapper.ourCard(2) == GameStateWrapper.tableCard(2) || GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(3))
            {
                return false;
            }

            else return true;


        }

        else if (state == "Turn")
        {
            if (GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(4) || GameStateWrapper.ourCard(2) == GameStateWrapper.tableCard(4))

            {
                return false;
            }

            else return true;


        }

        else if (state == "River")
        {
            if (GameStateWrapper.ourCard(1) == GameStateWrapper.tableCard(5) || GameStateWrapper.ourCard(2) == GameStateWrapper.tableCard(5))

            {
                return false;
            }

            else return true;


        }
        else return false;



    }


    private static double calculateTwoChance()
    {
       

            if (GameStateWrapper.THGS.Round.Equals("Preflop"))
            {
            return 0.047;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Flop"))
            {
                return 0.025;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Turn"))
            {
                return 0.02;
            }
            else if (GameStateWrapper.THGS.Round.Equals("River"))
            {
                return 0.92;
            }
            else return 1;




        

    }



    


}
