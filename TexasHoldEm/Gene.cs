using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Gene
{

	private List<double> data;
	private double fitness = 0.0;
	private const double mutateChance = 0.05;
	private const double mutationRate = 0.5;
	private const double upperBound = 1.0;
	private const double lowerBound = 0.0;

    public void outputData()
    {
        int i = 1;
        foreach (double value in data) {
            LogWriter.writeData("\t" + i.ToString() + ": " + value + Environment.NewLine);
            i++;
        }
		LogWriter.writeData("\tFitness: " + fitness + Environment.NewLine);
    }


	public Gene(int size, Random rand)
	{
		data = new List<double>(size);
		for (int i = 0; i < size; i++) {
			data.Add(rand.NextDouble() * upperBound);
		}
	}

	public Gene(List<double> data)
	{
		this.data = data;
	}

	public int getLength()
	{
		return data.Capacity;
	}

	public double get(int index)
	{
		return data[index];
	}

	public void set(int index, double value)
	{
		data[index] = value;
	}

	/// THIS SHIT BELOW MIGHT BREAK BY WRITING OVER ARRAY BOUNDS

	public List<double> getLeft(double percent)
	{
		if (percent > 1.0 || percent < 0.0)
			throw new System.Exception();
		int index = (int)(data.Capacity * percent);
		if (index == 0)
			throw new SystemException();
		return data.GetRange(0, index);
	}

	public List<double> getRight(double percent)
	{
		if (percent > 1.0 || percent < 0.0)
			throw new System.Exception();
		int index = (int)(data.Capacity * (1.0 - percent));
		if (index == 0)
			throw new SystemException();
		return data.GetRange(index, data.Capacity - index);
	}

	public double getFitness()
	{
		return fitness;
	}

	public void adjustFitness(int winnings)
	{
		if (winnings > 0)
			fitness += winFunction(winnings);
		else
			fitness -= lossFunction(winnings);
	}

	private double winFunction(int winnings)
	{
		return winnings ^ 2;
	}

	private double lossFunction(int winnings)
	{
		return winnings^2;
	}

	public void mutate(Random rand)
	{
		for (int i = 0; i < data.Capacity; i++)
		{
			if (rand.NextDouble() < mutateChance)
			{
				data[i] *= (rand.Next(0, 2) == 0 ? mutationRate : -mutationRate);
				if (data[i] > upperBound)
					data[i] = upperBound;
				else if(data[i] < lowerBound)
					data[i] = lowerBound;
			}
		}
	}
}
