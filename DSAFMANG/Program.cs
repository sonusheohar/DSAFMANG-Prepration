using System;
using DSAFMANG.Professional.SortAlgorithm;
int[] arr = { 64, 25, 12, 22, 11 };

Console.WriteLine("Original Array: " + string.Join(", ", arr));

SortAlgorithm sortAlgorithm = new SortAlgorithm();
var arrayResult=sortAlgorithm.SelectionSortAlgorithm(arr);
Console.WriteLine("Sorted Array: " + string.Join(", ", arrayResult));
Console.ReadLine();