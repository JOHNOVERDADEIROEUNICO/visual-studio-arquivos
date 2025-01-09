lista = []

for c in range(0,5):
    lista.append(int(input(f'Digite um valor para a posição {c}: ')))
print('=-='*40)

print('você digitou os valores ',lista)
print(f'O maior valor digitado foi {max(lista)} na(s) posição(ões) ',end='')

for c, v in enumerate (lista):
    if v == max(lista):
        print(c,end='.. ')

print(f'\nO menor valor digitado foi {min(lista)} na(s) posição(ões) ',end='')

for c, v in enumerate (lista):
    if v == min(lista):
        print(c,end='.. ')