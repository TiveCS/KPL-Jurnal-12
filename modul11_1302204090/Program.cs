using modul11_1302204090;

PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

data1.AddSebuahData("Ahmad Fathan Hanif");
data1.AddSebuahData("Mohammad Lutfi");
data1.AddSebuahData("Muhamad Iqbal Faturohman");
data1.AddSebuahData("Juanda Sinurat");
data1.AddSebuahData("Bayu Evri Saputra");
data1.AddSebuahData("Defrizal Cahyono Putro");
data1.AddSebuahData("Rifky Lovanto");

data2.PrintSemuaData();
data2.HapusSebuahData(data2.GetSemuaData().Count() - 1);

data1.PrintSemuaData();

Console.WriteLine("\nData 1: " + data1.GetSemuaData().Count());
Console.WriteLine("Data 2: " + data2.GetSemuaData().Count());






