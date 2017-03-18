using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Trainer {
	
	private int popSize;
	private List<Gene<double>> pop;
	private int currentGene = 0;
	private int generation = 1;
	private const double crossoverSplit = 0.5;

	public Trainer(int popSize = 10) {
		this.popSize = popSize;
		pop = new List<Gene<double>>();
		for (int i = 0; i < popSize; i++) {
			pop.Add(new Gene<double>(10));
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
		pop.Sort(geneSort);		// Sorting
		List<Gene<double>> fittest = getFittest();
	}

	private static int geneSort(Gene<double> geneA, Gene<double> geneB) {
		double diff = geneA.getFitness() - geneB.getFitness();
		if (diff > 0)
			return 1;
		if (diff < 0)
			return -1;
		return 0;
	}

	private List<Gene<double>> getFittest() {
		return new List<Gene<double>>();
	}

	private Gene<double> crossover(Gene<double> geneA, Gene<double> geneB) {
		List<double> left = geneA.getLeft(crossoverSplit);
		List<double> right = geneB.getRight(1 - crossoverSplit);
		left.AddRange(right);
		return new Gene<double>(left);
	}
}