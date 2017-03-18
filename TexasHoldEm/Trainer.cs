using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Trainer {
	
	private int popSize;
	private Gene<double>[] pop;
	private int currentGene = 0;
	private const double crossoverSplit = 0.5;

	public Trainer(int popSize = 10) {
		this.popSize = popSize;
		for (int i = 0; i < popSize; i++) {
			pop[i] = new Gene<double>(10);
		}
	}
	
	public bool nextGene() {
		return ++currentGene < popSize;
	}

	public Gene<double> getCurrentGene() {
		return this.pop[currentGene];
	}

	private void nextGeneration() {
		
	}

	private Gene<double> crossover(Gene<double> geneA, Gene<double> geneB) {
		double[] left = geneA.getLeft(crossoverSplit);
		double[] right = geneB.getRight(1 - crossoverSplit);
		double[] newData = new double[left.Length + right.Length];
		left.CopyTo(newData, 0);
		right.CopyTo(newData, left.Length);
		return new Gene<double>(newData);
	}
}
