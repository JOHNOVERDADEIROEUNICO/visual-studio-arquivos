from math import sqrt

a: float
b: float
c: float

a = float(input('DIGITE O PRIMEIRO CATETO: '))
b = float(input('DIGITE O SEGUNDO CATETO: '))
c = sqrt(a**2+b**2)
print('A HIPOTENUSA DE ',a,' E ',b,' EQUIVALE A: {:.2f}'.format(c))