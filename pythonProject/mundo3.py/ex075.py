
tp = 0
n1 = (int(input('Digite um número: ')),
      int(input('Digite mais um número: ')),
      int(input('Digite um outro número: ')),
      int(input('Digite um último número: ')))

print(f'O numero 9 apareceu {n1.count(9)} vezes.')
if 3 in n1:
    print(f'O primeiro 3 apareceu na posição {n1.index(3)+1}° ')
else:
    print('O valor 3 não foi encontrado.')
print('Os números pares foram: ', end=' ')
for c in range (len(n1)):
    if n1[c] % 2 == 0:
        print(n1[c], end=' ')
        tp = 1
if tp == 0:
    print('Não houve valores pares digitados')   