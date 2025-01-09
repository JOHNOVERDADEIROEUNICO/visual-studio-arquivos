#variaveis
l1 = float(input('Digite o primeiro lado do triângulo: '))
l2 = float(input('Digite o segundo lado do triângulo: '))
l3 = float(input('Digite o terceiro lado do triângulo: '))
#condiçoes/resposta
if l1 == l2 and l2 == l3:   
    print('Este é um triângulo equilátero.')
else:
    print('Este não é um triângulo equilátero.')

if l1 != l2 and l2 != l3:   
    print('Este é um triângulo escaleno.')
else:
    print('Este não é um triângulo escaleno.')

if l1 == l2 and l2 != l3 or l1 == l3 and l3 != l2 or l3 == l2 and l2 != l1:
    print('Este é um triângulo isósceles.')
else:
    print('Este não é um triângulo isósceles')

if l1 < l2+l3 and l2 < l1+l3 and l3 < l2+l1:
    print('Este é um verdadeiro triângulo.')
else:
    print('Este é um falso triângulo.')
#ACABOU.