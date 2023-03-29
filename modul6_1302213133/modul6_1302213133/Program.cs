// See https://aka.ms/new-console-template for more information
using modul6_1302213133;
using System.Runtime.Intrinsics.X86;


SayaTubeUser user = new SayaTubeUser("Faris");

SayaTubeVideo video1 = new SayaTubeVideo("John Wick: Chapter 1");
SayaTubeVideo video2 = new SayaTubeVideo("John Wick: Chapter 2");
SayaTubeVideo video3 = new SayaTubeVideo("John Wick: Chapter 3");
SayaTubeVideo video4 = new SayaTubeVideo("John Wick: Chapter 4");
SayaTubeVideo video5 = new SayaTubeVideo("Suzume to Tomari");
SayaTubeVideo video6 = new SayaTubeVideo("Ted Lasso: Season 1");
SayaTubeVideo video7 = new SayaTubeVideo("Ted Lasso: Season 2");
SayaTubeVideo video8 = new SayaTubeVideo("Ted Lasso: Season 3");
SayaTubeVideo video9 = new SayaTubeVideo("Jigokuraku");
SayaTubeVideo video10 = new SayaTubeVideo("Koe no Katachi");

Console.WriteLine("Review Film " + video1.title + " Oleh: " + user.username);
user.AddVideo(video1);
Console.WriteLine("Menambahkan film: ");
video1.printVideoDetails();

Console.WriteLine("Review Film " + video2.title + " Oleh: " + user.username);
user.AddVideo(video2);
Console.WriteLine("Menambahkan film: ");
video1.printVideoDetails();

Console.WriteLine("Review Film " + video3.title + " Oleh: " + user.username);
user.AddVideo(video3);
Console.WriteLine("Menambahkan film: ");
video3.printVideoDetails();

Console.WriteLine("Review Film " + video4.title + " Oleh: " + user.username);
user.AddVideo(video4);
Console.WriteLine("Menambahkan film: ");
video4.printVideoDetails();

Console.WriteLine("Review Film " + video5.title + " Oleh: " + user.username);
user.AddVideo(video5);
Console.WriteLine("Menambahkan film: ");
video5.printVideoDetails();

Console.WriteLine("Review Film " + video6.title + " Oleh: " + user.username);
user.AddVideo(video6);
Console.WriteLine("Menambahkan film: ");
video6.printVideoDetails();

Console.WriteLine("Review Film " + video7.title + " Oleh: " + user.username);
user.AddVideo(video7);
Console.WriteLine("Menambahkan film: ");
video7.printVideoDetails();

Console.WriteLine("Review Film " + video8.title + " Oleh: " + user.username);
user.AddVideo(video8);
Console.WriteLine("Menambahkan film: ");
video8.printVideoDetails();

Console.WriteLine("Review Film " + video9.title + " Oleh: " + user.username);
user.AddVideo(video9);
Console.WriteLine("Menambahkan film: ");
video9.printVideoDetails();

Console.WriteLine("Review Film " + video10.title + " Oleh: " + user.username);
user.AddVideo(video10);
Console.WriteLine("Menambahkan film: ");
video10.printVideoDetails();