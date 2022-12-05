double[] regnVejVærdier = new double[5];
int valg;

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
			for (int i = 0; i < regnVejVærdier.Length; i++)
			{
				Console.Write("Indtast Værdier (mm): ");
				try
				{
					regnVejVærdier[i] = Convert.ToDouble(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Forkert indtast.");
					MellemrumForsæt();
				}
			}
			break;
		case 2:
			Console.WriteLine(UdskrivVærdier(regnVejVærdier));
			break;
		case 3:
			Console.WriteLine(Queryable.Average(regnVejVærdier.AsQueryable()));
			break;
		case 4:
			Console.WriteLine(UdskrivMaxVærdi(regnVejVærdier));
			break;
		case 5:
			Console.WriteLine(UdskrivMinVærdi(regnVejVærdier));
			break;
		default:
			Console.WriteLine("Prøv igen.)");
			break;
	}
	MellemrumForsæt();
} while (true);

#region Methods
static string UdskrivMaxVærdi(double[] array)
{
	Console.Clear();
	if (array.Length > 0)
		return String.Format($"Max værdi: {array.Max():F2} mm");
	else
		return String.Format("Prøve med indtast nogle værdier på [ 1.Indtast Data ]");
}

static string UdskrivMinVærdi(double[] array)
{
	Console.Clear();
	if (array.Length > 0)
		return String.Format($"Minimum værdi: {array.Max():F2} mm");
	else
		return String.Format("Prøve med indtast nogle værdier på [ 1.Indtast Data ]");
}

static string UdskrivVærdier(double[] array)
{
	Console.Clear();
	if (array.Length > 0)
		for (int i = 0; i < array.Length; i++)
			return String.Format($"Måleværdi {i + 1} = {array[1]} mm");
	else
		return String.Format("Prøve med indtast nogle værdier på [ 1.Indtast Data ]");
	return string.Empty;
}
#endregion

#region UserExperienceMethod
static void MellemrumForsæt()
{
    Console.Write("\nTryk på mellemrum for at forsæt.");
    Console.ReadKey();
    Console.Clear();
}
#endregion