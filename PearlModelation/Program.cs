// See https://aka.ms/new-console-template for more information
using PearlModelation;


var pearl1 = Pearl.Factory.CreateWithRandomData();
Console.WriteLine($"Pearl 1: {pearl1}");



var necklace1 = PearlNecklace.Factory.CreateWithRandomData(35);
Console.WriteLine(necklace1);
Console.WriteLine();
Console.WriteLine($"Amount of sweetwater pearls: {necklace1.Count(TypeOfPearl.Sweetwater)}");
Console.WriteLine($"Amount of freshwater pearls: {necklace1.Count(TypeOfPearl.Freshwater)}");
Console.WriteLine($"Price of the necklace: {necklace1.Price}");

Console.WriteLine();
Console.WriteLine();
necklace1.Sort();

Console.WriteLine($"A sorted necklade\n{necklace1}");

var searchPearl = necklace1[10];

Console.WriteLine($"Looking for {searchPearl}");

necklace1.IndexOf(searchPearl);

