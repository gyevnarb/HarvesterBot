using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class GeneReadWriter {

	public static Gene readGene(string path) {

        Gene gene = new Gene(1, new Random());

        if (File.Exists(path))
        {
            Stream stream = File.OpenRead(path);
            BinaryFormatter deserializer = new BinaryFormatter();
            gene = (Gene)deserializer.Deserialize(stream);
            stream.Close();
        }
        return gene;
	}

	public static void writeGene(string path, Gene gene) {
        Stream stream = File.Create(path);
		var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        serializer.Serialize(stream, gene);
        stream.Close();
	}	
}
