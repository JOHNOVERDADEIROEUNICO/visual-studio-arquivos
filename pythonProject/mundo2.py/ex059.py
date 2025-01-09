from time import sleep

c = 0
r = 0

n1 = int(input('Primeiro Número: '))
n2 = int(input('Segundo Número: '))

while c != 5:
    print('''    [1] Somar
    [2] Mulriplicar
    [3] Maior
    [4] Novos Números
    [5] Sair Do Programa ''')
    c = int(input('Qual a sua opção? '))

    match c:
        case 1:
            r = n1 + n2
            print('A soma deu {}'.format(r)) 

        case 2:
            r = n1 * n2
            print('O produto deu {}'.format(r))

        case 3:
            if n1 > n2:
                r = n1
            else:
                r = n2
            print('O maior é {}'.format(r)) 

        case 4:
            print('Ok, reiniciando, Digita direito...')
            sleep(3)
            n1 = int(input('Primeiro Número: '))
            n2 = int(input('Segundo Número: '))

        case 5:
            c = 5
            sleep(3)
        case _:
            print('Número inválido. Tente novamente.') 
    print('-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=') 
print('Finalizado.')  