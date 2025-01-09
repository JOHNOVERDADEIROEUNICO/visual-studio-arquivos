
import random

contj = contvjg = contvcpu = 0

print('=-' * 30)
print('Vamos jogar par ou ímpar')
print('=-' * 30)
print('(MELHOR DE 3)')

while True:
    if contj == 3:
        break
    elif contvjg == 2:
        break
    elif contvcpu == 2:
        break

    cpu = random.randint(1,10)
    jg = int(input('Diga um valor: '))
    pi = str(input('Par ou ímpar [p/i]? ')).strip().upper()[0]
    s = cpu + jg
    print('-' * 30)

    if s % 2 == 0:
        print(f'Você jogou {jg} e o computador {cpu}. Total de {s} deu par.')
        if pi == 'P':
            print('Você venceu essa rodada!')
            contvjg += 1
        else:
            print('Você perdeu essa rodada, SEU MERDA!')
            contvcpu += 1
        print('-' * 30)

    else:
        print(f'Você jogou {jg} e o computador {cpu}. Total de {s} deu ímpar.')
        if pi == 'I':
            print('Você venceu essa rodada!')
            contvjg += 1
        else:
            print('Você perdeu, SEU MERDA!')
            contvcpu += 1
        print('-' * 30)
    contj += 1

print('=-' * 30)
if contvjg > contvcpu:
    print('VENCEU ESSA POR PURA SORTE!')
else:
    print('GAME OVER! HAHAHAHA EU SOU O MELHOR!')
