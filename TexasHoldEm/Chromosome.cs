using System;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Gene<Type> {

	private Type[] data;
	private double fitness = 0.0;

    public Gene(int size) {
		data = new Type[size];
	}

	public Gene(Type[] data) {
		this.data = data;
	}

	public int getLength() {
		return data.Length;
	}

	public Type get(int index) {
		return data[index];
	}

	public void set(int index, Type value) {
		data[index] = value;
	}

	/// THIS SHIT BELOW MIGHT BREAK BY WRITING OVER ARRAY BOUNDS

	public Type[] getLeft(double percent) {
		if (percent > 1.0 || percent < 0.0)
			throw new System.Exception();
		int index = (int) (data.Length * percent);
		if (index == 0)
			throw new SystemException();
		Type[] left = new Type[index-1];
		Array.Copy(data, left, index-1);
		return left;
	}

	public Type[] getRight(double percent) {
		if (percent > 1.0 || percent < 0.0)
			throw new System.Exception();
		int index = (int)(data.Length * (1.0 - percent));
		if (index == 0)
			throw new SystemException();
		Type[] right = new Type[data.Length - index];
		Array.Copy(data, index, right, 0, (data.Length - index));
		return right;
	}

	public double getFitness() {
		return fitness;
	}

	public void adjustFitness(int winnings) {
		if (winnings > 0)
			fitness += winFunction(winnings);
		else
			fitness -= lossFunction(winnings);
	}

	private double winFunction(int winnings) {
		return winnings;
	}

	private double lossFunction(int winnings) {
		   return winnings^2;
	}

}
