
from time import sleep

confirmador = 0
lista = []
while True:
    confirmador = int(input('Digite um valor: '))
    if confirmador in lista:
        print('Valor duplicado! não vou adicionar...')
        sleep(2)
    else:
        lista.append(confirmador)
        print('Valor adicionado...')
        sleep(2)
    soun = str(input('Quer continuar [s/n]? '))
    if soun != 's':
        break
print('='*40)
lista.sort()
print('Você digitou os valores: ',lista)

    