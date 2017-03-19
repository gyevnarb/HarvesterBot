using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Bot {
	

	

	public static bool betOrFold(int currentBet) {
		// True is bet, False is fold
		return true;
	}

	public static int makeBet() {
		// returns the ammount to bet
		return 0;
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
