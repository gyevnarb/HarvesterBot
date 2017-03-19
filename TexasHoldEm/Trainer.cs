using System;
using System.Collections.Generic;
using System.Random;
using System.Tuple;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Trainer {

	private int popSize;
	private List<Gene<double>> pop;
	private int currentGene = 0;
	private int generation = 1;
	private const double crossoverSplit = 0.5;
	private const double genepoolSize = 0.5;
	private const double selectionSize = 0.5;
	private Random rand;

	public Trainer(int popSize = 10) {
		this.popSize = popSize;
		rand = new Random(Guid.NewGuid().GetHashCode());
		pop = new List<Gene<double>>();
		for (int i = 0; i < popSize; i++) {
			pop.Add(new Gene<double>(popSize));
		}
		initPop();
	}

	private void initPop() {
		// TODO: a better solution
		foreach (Gene<double> gene in pop) {
			for (int i = 0; i < gene.getLength(); i++) {
				gene.set(i, rand.NextDouble());
			}
		}
	}

	public int getGeneration() {
		return generation;
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
		pop.Sort(geneSort);
		List<Gene<double>> newPop = new List<Gene<double>>(popSize);
	}

	private static int geneSort(Gene<double> geneA, Gene<double> geneB) {
		double diff = geneA.getFitness() - geneB.getFitness();
		if (diff < 0)
			return 1;
		if (diff > 0)
			return -1;
		return 0;
	}

	private List<Gene<double>> getGenepool() {
		List<Gene<double>> genepool = new List<Gene<double>>((int) (popSize * genepoolSize));
		for (int i = 0; i < genepool.Capacity; i++) {
			genepool[i] = crossover(tournamentSelection(pop), tournamentSelection(pop));
		}
		return genepool;
	}

	private Gene<double> tournamentSelection(List<Gene<double>> list) {
		Gene<double> mate = pop[rand.Next(1, popSize - 1];
		return mate;
	}

	private Gene<double> crossover(Gene<double> geneA, Gene<double> geneB) {
		List<double> left = geneA.getLeft(crossoverSplit);
		List<double> right = geneB.getRight(1 - crossoverSplit);
		left.AddRange(right);
		return new Gene<double>(left);
	}
}