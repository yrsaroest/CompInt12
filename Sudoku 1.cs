using System;
using System.IO;

FileStream s = new FileStream("Sudoku_puzzels_5.txt", FileMode.Open);
StreamReader r = new StreamReader(s);
String sudoku = r.ReadToEnd();

Console.WriteLine(sudoku);

//File uploaden, String parsen naar int array
//Met for(each)loop de getallen op de juiste positie zetten
//Consol.Write to check



