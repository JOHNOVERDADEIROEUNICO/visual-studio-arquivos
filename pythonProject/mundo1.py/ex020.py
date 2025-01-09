import random

deseja: str

n1 = str(input('DIGITE UM NOME: '))
n2 = str(input('DIGITE UM NOME: '))
n3 = str(input('DIGITE UM NOME: '))
n4 = str(input('DIGITE UM NOME: '))

print('O nome sorteado foi: ')
num = random.randint(1,4)
match num:
    case 1:
        print('Foi sorteado ',n1)
    case 2:
        print('Foi sorteado ',n2)
    case 3:
        print('Foi sorteado ',n3)
    case 4:
        print('Foi sorteado ',n4)

numeros = [n1,n2,n3,n4]

random.shuffle(numeros)

print("A ordem de apresentação será: ")
print(numeros)

