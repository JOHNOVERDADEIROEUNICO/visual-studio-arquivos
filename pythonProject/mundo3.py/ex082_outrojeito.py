lista = []
pares = []
impares = []

while True:
    lista.append(int(input('Digite um número: ')))

    resp = str(input('Quer continuar? '))
    if resp != 's':
        break

for i,v in enumerate(lista):
    if v % 2 == 0:
        pares.append(v)
    else:
        impares.append(v)

print('-='*40)

print('A lista completa: ',lista)
print('A lista de pares: ',pares)
print('A lista de ímpares: ',impares)