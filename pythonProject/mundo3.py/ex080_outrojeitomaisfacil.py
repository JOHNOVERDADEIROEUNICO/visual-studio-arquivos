from time import sleep

lista = []

for c in range (0,5):
    n = int(input('Digite um valor: '))

    if c == 0 or n > max(lista):
        lista.append(n)
        print('Valor adicionado ao final da lista..')
        sleep(2)
    else:
        pos = 0
        while pos < len(lista):
            if n <= lista[pos]:
                lista.insert(pos,n)
                print(f'Valor adicionado na posição {pos} da lista..')
                sleep(2)
                break
            pos +=1
       
print('Os valores digitados em ordem foram: ',lista)