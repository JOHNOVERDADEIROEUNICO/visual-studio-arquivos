lista = [[],[]]

for c in range(0,7):
    n1 = int(input('Digite um {c}° número: '))
    if n1 % 2 == 0:
        lista[0].append(n1)
    elif n1 % 2 == 1:
        lista[1].append(n1)
print('-='*40)
print(f'Os valores pares digitados foram: {lista[0]}\nOs valores ímpares digitados foram: {lista[1]}')