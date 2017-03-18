using System;
using AIGaming.Core.Games;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Chromosome<Type> {

	private Type[] data;

    public Chromosome(int size) {
		data = new Type[size];
	}

	public Chromosome(Type[] data) {
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

	public Type[] getLeft(double percent) {
	
	}

	public Type[] getRight(double percent) {

	}
}
