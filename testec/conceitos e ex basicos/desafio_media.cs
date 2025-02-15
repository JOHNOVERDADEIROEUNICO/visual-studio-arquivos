double divisor = 5;

string[] names = ["John", "Paul", "George", "Ringo"];

int[] n1 = [100, 100, 100, 100, 100];
int[] n2 = [80, 87, 90, 100, 100];
int[] n3 = [80, 75, 90, 65, 67];
int[] n4 = [80, 75, 90, 65, 67];

int[] examScores = [n1.Sum(), n2.Sum(), n3.Sum(), n4.Sum()];
double[] extraCredit = [(examScores[0]*0.1)/divisor, (examScores[1]*0.1)/divisor, (examScores[2]*0.1)/divisor, (examScores[3]*0.1)/divisor];

double[] media = new double[5];
string[] situacao = new string[5];

for (int i =0; i < 4; i++)
{
   if (i == 0)
   {
      media[i] = (n1[0] + n1[1] + n1[2] + n1[3] + n1[4]) / divisor;
   }
   else if (i == 1)
   {
      media[i] = (n2[0] + n2[1] + n2[2] + n2[3] + n2[4]) / divisor;
   }
   else if (i == 2)
   {
      media[i] = (n3[0] + n3[1] + n3[2] + n3[3] + n3[4]) / divisor;
   }
   else
   {
      media[i] = (n4[0] + n4[1] + n4[2] + n4[3] + n4[4]) / divisor;
   }
}

for (int i = 0; i < 4; i++)
{
   if (media[i] + extraCredit[i] <= 100)
   {
      media[i] += extraCredit[i];
   }
}

for (int i = 0; i < 4; i++)
{
   if (media[i] >= 97)
   {
      situacao[i] = "A+";
   }
   else if (media[i] >= 90 && media[i] < 97)
   {
      situacao[i] = "A-";
   }
   else if (media[i] >= 87 && media[i] < 90)
   {
      situacao[i] = "B+";
   }
   else if (media[i] >= 80 && media[i] < 87)
   {
      situacao[i] = "B-";
   }
   else if (media[i] >= 77 && media[i] < 80)
   {
      situacao[i] = "C+";
   }
   else if (media[i] >= 70 && media[i] < 77)
   {
      situacao[i] = "C-";
   }
   else if (media[i] >= 67 && media[i] < 70)
   {
      situacao[i] = "D+";
   }
   else if (media[i] >= 60 && media[i] < 67)
   {
      situacao[i] = "D-";
   }
   else
   {
      situacao[i] = "F";
   }
}


Console.WriteLine($"Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
for (int i = 0; i < 4; i++)
{
   Console.WriteLine($"{names[i]}\t\t{examScores[i]}\t\t{Math.Round(media[i], 2)}\t{situacao[i]}\t{examScores[i]}({Math.Round(extraCredit[i], 2)} pts)\n");
}

Console.WriteLine("Press any key to exit.");
Console.ReadLine();