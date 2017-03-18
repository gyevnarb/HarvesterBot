using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Trainer {
	
	private int popSize;
	private Gene<double>[] pop;
	private int currentGene = 0;
	private int generation = 1;
	private const double crossoverSplit = 0.5;

	public Trainer(int popSize = 10) {
		this.popSize = popSize;
		for (int i = 0; i < popSize; i++) {
			pop[i] = new Gene<double>(10);
		}
	}
	
	public bool nextGene() {
		if(++currentGene < popSize)
			return true;
		currentGene = 0;
		return false;
	}

	public Gene<double> getCurrentGene() {
		return this.pop[currentGene];
	}

	public void nextGeneration() {
		generation++;

	}

	private Gene<double> crossover(Gene<double> geneA, Gene<double> geneB) {
		List<double> left = geneA.getLeft(crossoverSplit);
		List<double> right = geneB.getRight(1 - crossoverSplit);
		left.AddRange(right);
		return new Gene<double>(left);
	}
}
