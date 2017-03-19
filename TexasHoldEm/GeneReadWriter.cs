using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

[Serializable]
public static class GeneReadWriter {

	public static Gene readGene(string path) {
		using (Stream stream = File.Open(path, FileMode.Open)) {
			var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			return (Gene) binaryFormatter.Deserialize(stream);
		}
	}

	public static void writeGene(string path, Gene gene) {
		using (Stream stream = File.Open(path, FileMode.Create)) {
			var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			binaryFormatter.Serialize(stream, gene);
		}
	}	
}
