import modulos_ligação

num = int(input('Digite um valor: '))
fat = modulos_ligação.fatorial(num)

print(f'O fatorial de {num} é {fat}')
print(f'O dobro de {num} é {modulos_ligação.dobro(num)}')
print(f'O triplo de {num} é {modulos_ligação.triplo(num)}')