using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Gene<Type>
{

	private List<Type> data;
	private double fitness = 0.0;

	public Gene(int size)
	{
		data = new List<Type>(size);
	}

	public Gene(List<Type> data)
	{
		this.data = data;
	}

	public int getLength()
	{
		return data.Capacity;
	}

	public Type get(int index)
	{
		return data[index];
	}

	public void set(int index, Type value)
	{
		data[index] = value;
	}

	/// THIS SHIT BELOW MIGHT BREAK BY WRITING OVER ARRAY BOUNDS

	public List<Type> getLeft(double percent)
	{
		if (percent > 1.0 || percent < 0.0)
			throw new System.Exception();
		int index = (int)(data.Capacity * percent);
		if (index == 0)
			throw new SystemException();
		return data.GetRange(0, index - 1);
	}

	public List<Type> getRight(double percent)
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
