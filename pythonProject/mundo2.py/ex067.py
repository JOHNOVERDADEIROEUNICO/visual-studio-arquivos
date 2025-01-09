cont = 1
n = int(input('Digite um número para saber sua tabuada (e um número negativo para encerrar o programa): '))

while True:
    print('-' * 40)

    while cont < 11:
        print(f'{n} x {cont} = {n*cont}')
        cont += 1

    print('-' * 40)
    cont = 0
    n = int(input('Quer ver a tabuada de qual outro valor? '))

    if n <0 :
        break 

print('-' * 40)
print('Programa tabuada encerrado, volte sempre!')