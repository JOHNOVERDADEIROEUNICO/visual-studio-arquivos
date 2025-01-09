def leiaint(num):

    while True:
        n = str(input(num))

        if num.isnumeric():
            num = int(num)

            return num
            break

        else:
            print('\033[31m ERRO! Digite um número inteiro válido.\033[m')
            num = str(input('Digite um número: '))

            if num.isnumeric():
                num = int(num)

                return num
                break

n = leiaint('Digite um número: ')
print(f'Você acabou de digitar o número {n}')