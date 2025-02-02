//Nome dos cursos:

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";
//Credito de horas do curso:

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
//Notas A e B:

int gradeA = 4;
int gradeB = 3;
//Notas de cade curso:

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;
//Multiplicação das horas pelas notas

int c1 = course1Credit * course1Grade;
int c2 = course2Credit * course2Grade;
int c3 = course3Credit * course3Grade;
int c4 = course4Credit * course4Grade;
int c5 = course5Credit * course5Grade;
//Somatorio dos resultados e somatorio das horas de cada curso:

int csum = c1 + c2 + c3 + c4 + c5;
int totch = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
//Calculo do GPA do(a) aluno(a):

decimal gpa =  (decimal)csum / totch;
//Saída dos dados:

Console.WriteLine($"Student:\t{studentName}\n");
Console.WriteLine($"Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t\t{course5Credit}\n");
Console.WriteLine($"Final GPA\t\t{Math.Round(gpa, 2)}");