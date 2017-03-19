using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Bot {

	public static bool betOrFold(Gene gene) {
		// True is bet, False is fold
		double stateEval = gene.get(0) * getSelfWinProb() - gene.get(1) * getEnemyWinProb() + gene.get(2) * getPossibleWinnings() - gene.get(3) * getPossibleLoss();
		return stateEval > 0.0;
	}

	public static int makeBet(Gene gene) {
		// returns the ammount to bet
		double betEval = gene.get(6) * (gene.get(4) * getSelfWinProb() - gene.get(5) * getEnemyWinProb()) * ((gene.get(7) * getEnemyWinProb() > 0.5) ? 0.0 : 1.0);
		return ((int) betEval * (GameStateWrapper.maxBet - GameStateWrapper.minBet)) + GameStateWrapper.minBet;
	}

	private static double getEnemyWinProb() {
		// Returns the probability of the enemy winning
		return 0.0;
	}

	private static double getSelfWinProb() {
        // Returns the probability of us winning

        
        double ourStraightFlushChance;
        double ourFourKindChance;
        double ourFullHouseChance;
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

        
   
        return 0.0;
	}

    //leaving out royal flush because yoloswag420#blazeit
    private static double calculateStraightFlushChance()
    {
   

        

        return 0.0;

    }
    private static double calculateFourKindChance()
    {
        return 0.0;

    }
    private static double calculateFullHouseChance()
    {
        return 0.0;

    }
    private static double calculateFlashChance()
    {
        return 0.0;

    }
    private static double calculateStraightChance()
    {
        return 0.0;

    }
    private static double calculateThreeKindChance()
    {
        return 0.0;

    }
    private static double calculateTwoChance()
    {
        if (GameStateWrapper.ourCard(0).Index == GameStateWrapper.ourCard(1).Index)
        {
            return 1;
        }
        else
        {
            return 0.12;
        }

    }
    private static double calculateOneChance()
    {
        return 0.0;

    }






}
