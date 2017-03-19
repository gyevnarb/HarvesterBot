using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class LogWriter {
	private static string path = "output.log";

	public static void clear() {
		File.Delete(path);
	}

	public static void writeData(String data) {
		File.AppendAllText(path, data);
	}

}