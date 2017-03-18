using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Bot {
	
	private const int chromosomeSize = 10;
	private Chromosome<double> chromosome;

	public Bot() {
		chromosome = new Chromosome<double>(chromosomeSize);
	}

	public Bot(double[] values) {
		chromosome = new Chromosome<double>(values);
	}

	public bool betOrFold(int currentBet) {
		// True is bet, False is fold
		return true;
	}

	public int makeBet() {
		// returns the ammount to bet
		return 0;
	}

	private double getEnemyWinProb() {
		// Returns the probability of the enemy winning
		return 0.0;
	}

	private double getSelfWinProb() {
		// Returns the probability of us winning
		return 0.0;
	}

}
