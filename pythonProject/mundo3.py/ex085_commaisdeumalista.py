lista = []
par = []
impar = []

for c in range(0,7):
    lista.append(int(input(f'Digite o {c+1}° valor: ')))
    if lista[c] % 2 == 0:
        par.append(lista[c])
    elif lista[c] % 2 == 1:
        impar.append(lista[c])
print('-='*40)
print(f'Os valores pares digitados foram: {par}\nOs valores ímpares digitados foram: {impar}')