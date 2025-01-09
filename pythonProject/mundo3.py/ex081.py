lista = []

while True:
    lista.append(int(input('Digite um valor: ')))
    lista.sort(reverse=True)

    resp = str(input('Quer continuar? '))
    if resp != 's':
        break

print('A quantidade elementos digitados foram: ',len(lista))
print('Os valores digitados em ordem decrescente foram: ',lista)

if 5 in lista:
    print('O valor 5 se encontra na lista!')
else:
    print('O valor 5 não foi encontrado.')