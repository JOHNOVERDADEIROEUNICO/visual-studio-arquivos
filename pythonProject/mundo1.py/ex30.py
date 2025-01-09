parimpar: int

parimpar = int(input('Digite um número para saber se ele é par ou ímpar: '))
if parimpar % 2 == 0:
    print('O número {} é par!'.format(parimpar))
else:
    print('O número {} é ímpar!'.format(parimpar))
