using ConsoleApp4;

st d = new st();

studentifo studentifo = new studentifo();

Console.WriteLine("Please Enter Mark1");
studentifo.marks1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Mark2");
studentifo.marks2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Mark2");
studentifo.marks3 = Convert.ToInt32(Console.ReadLine());
d.add(studentifo);
d.display();