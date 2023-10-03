//список (list)

//Обычный список

using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add(3);
arrayList.Add("Privjet");
arrayList.Add(3.14);

//Обобщённый список

List<string> sities = new() { "Moscow", "Voronezh", "VodooDoll" };
sities.Add("Bryansk");
sities.AddRange(new string[] { "Sevastopol", "Dubai" });
sities.RemoveAt(1);
sities.Sort();
sities.Reverse();
Console.WriteLine(string.Join(", ", sities));