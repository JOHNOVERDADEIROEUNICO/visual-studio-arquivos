def area(a,b,d):
    a = b * d
    print(f'A área de um terreno {b}x{d} é de {a}m².')

print('controle de terrenos'.center(40))
print('-'*40)

l = float(input('Largura(m): '))
c = float(input('Comprimento(m): '))

area(a=0, b= l, d= c)