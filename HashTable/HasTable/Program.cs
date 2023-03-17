using System.Collections;

Hashtable ht1 = new Hashtable();
Hashtable ht2 = new Hashtable(3);
Hashtable ht3 = new Hashtable(ht2);

ht3.Add("h", "Hieu");
ht3.Add("N", "Nguet");
ht3.Add("K", "Khanh");


foreach (DictionaryEntry item in ht3)
{
    Console.WriteLine(item.Key + "\t" + item.Value);
}
Console.WriteLine(ht3["N"]);
ht3["D"] = "Duy";
foreach (DictionaryEntry item in ht3)
{
    Console.WriteLine(item.Key + "\t" + item.Value);
};

SortedList sl1 = new SortedList();
SortedList sl2 = new SortedList(3);
SortedList sl3 = new SortedList(sl2);

