lista = []

while True:
    lista.append(int(input('Digite um número: ')))

    resp = str(input('Quer continuar? '))
    if resp != 's':
        break

par = lista[:]
impar = lista[:]

print('-='*40)

pos = 0
while pos < len(par):
    if par[pos] % 2 == 1:
        par.pop(pos)        
            
    pos +=1

pos = 0
while pos < len(impar):
    if impar[pos] % 2 == 0:
        impar.pop(pos)        
            
    pos +=1

print('A lista completa: ',lista)
print('A lista de pares: ',par)
print('A lista de impares: ',impar)