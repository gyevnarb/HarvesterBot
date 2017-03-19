using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Bot {

	public static bool betOrFold(Gene gene) {
		// True is bet, False is fold
		double stateEval = gene.get(0) * getSelfWinProb() - gene.get(1) * getEnemyWinProb() + gene.get(2) * getPossibleWin() - gene.get(3) * getPossibleLoss();
		return stateEval > 0.0;
	}

	public static int makeBet(Gene gene) {
		// returns the ammount to bet
		double betEval = gene.get(6) * (gene.get(4) * getSelfWinProb() - gene.get(5) * getEnemyWinProb()) * ((gene.get(7) * getEnemyWinProb() > 0.5) ? 0.0 : 1.0);
		return ((int) betEval * (GameStateWrapper.maxBet() - GameStateWrapper.minBet())) + GameStateWrapper.minBet();
	}

	private static double getEnemyWinProb() {
        // Returns the probability of the enemy winning
        return 0.50;
	}

    private static int PossibleWin()
    {
        return 2000;
    }
    private static int PossibleLoss()
    {
        //not 2000
        return 2000;
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



        return 0.50;
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
    private static double calculateOneChance()
    {
        if (GameStateWrapper.ourCard(0).Index == GameStateWrapper.ourCard(1).Index)
        {
            return 1;
        }
        else
        {

            if (GameStateWrapper.THGS.Round.Equals("Preflop"))
            {
                return 0.4874;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Flop") && hasOneChance("Flop"))
            {
                return 0.2882;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Turn") && hasOneChance("Turn"))
            {
                return 0.2414;
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
       

            if (GameStateWrapper.THGS.Round.Equals("Preflop") && GameStateWrapper.ourCard(1) == GameStateWrapper.ourCard(2))
        {
            return;
        }
            {
                return 0.4874;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Flop") && hasOneChance("Flop"))
            {
                return 0.2882;
            }
            else if (GameStateWrapper.THGS.Round.Equals("Turn") && hasOneChance("Turn"))
            {
                return 0.2414;
            }
            else if (GameStateWrapper.THGS.Round.Equals("River") && hasOneChance("River"))
            {
                return 0;
            }
            else return 1;




        

    }






}
