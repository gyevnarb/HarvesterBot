using System;
using System.Collections.Generic;
using System.Random;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Gene
{

	private List<double> data;
	private double fitness = 0.0;

	public Gene(int size)
	{
		data = new List<double>(size);
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
		return data.GetRange(0, index - 1);
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
		return winnings;
	}

	private double lossFunction(int winnings)
	{
		return winnings ^ 2;
	}
}
