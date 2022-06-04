using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul11_1302204090
{
	internal class PusatDataSingleton
	{
		// Mengembalikan instance class ini
		public static PusatDataSingleton GetDataSingleton()
		{
			if (s_instance == null)
			{
				s_instance = new PusatDataSingleton();
			}
			return s_instance;
		}

		// Menyimpan instance dari class ini
		private static PusatDataSingleton? s_instance { get; set; }

		public List<string> DataTersimpan { get; init; }

		// Konstruktor private agar instance class hanya sekali dibuat
		private PusatDataSingleton()
		{
			DataTersimpan = new List<string>();
		}

		// Menambahkan sebuah objek string ke DataTersimpan
		public void AddSebuahData(string input)
		{
			DataTersimpan.Add(input);
		}

		// Menghapus objek dari DataTersimpan menggunakan index dari objek tersebut
		public void HapusSebuahData(int index)
		{
			DataTersimpan.RemoveAt(index);
		}

		// Menampilkan semua data dari DataTersimpan
		public void PrintSemuaData()
		{
			Console.WriteLine(" ");
			foreach (var item in DataTersimpan)
			{
				Console.WriteLine(item);
			}
		}

		// Mengembalikan instance dari list DataTersimpan
		public List<string> GetSemuaData()
		{
			return DataTersimpan;
		}



	}
}
