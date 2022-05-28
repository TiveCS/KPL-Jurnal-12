using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul11_1302204090
{
	internal class PusatDataSingleton
	{
		public static PusatDataSingleton GetDataSingleton()
		{
			if (_instance == null)
			{
				_instance = new PusatDataSingleton();
			}
			return _instance;
		}

		private static PusatDataSingleton? _instance { get; set; }

		public List<string> DataTersimpan { get; set; }

		// Konstruktor private agar instance class hanya sekali dibuat
		private PusatDataSingleton()
		{
			DataTersimpan = new List<string>();
		}

		public void AddSebuahData(string input)
		{
			DataTersimpan.Add(input);
		}

		public void HapusSebuahData(int index)
		{
			DataTersimpan.RemoveAt(index);
		}

		public void PrintSemuaData()
		{
			Console.WriteLine(" ");
			foreach (var item in DataTersimpan)
			{
				Console.WriteLine(item);
			}
		}

		public List<string> GetSemuaData()
		{
			return DataTersimpan;
		}



	}
}
