double[] regnVejVærdier = new double[5];
int valg = 0;

do
{
    Console.WriteLine("Regnvejrstatistik");
    Console.Write("1- Indtast Data\n2- Vis alle værdier\n3- Gennemsnittet\n4- Max Værdi\n5- Min Værdi\nDit valg: ");
	try
	{
		valg = Convert.ToInt32(Console.ReadLine());
	}
	catch (Exception)
	{
		Console.WriteLine("ERROR - Prøv igen..\nTryk noget for at forsæt.");
		Console.ReadKey();
		Console.Clear();
		continue;
	}
	switch (valg)
	{
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		default:
			break;
	}

} while (true);