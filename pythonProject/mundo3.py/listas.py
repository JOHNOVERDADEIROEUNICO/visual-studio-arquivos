num = [2,5,9,1]
num [2] = 3
num.append(7)
num.sort(reverse=True)
num.insert(2,0)
num.pop(2)

if 4 in num:
    num.remove(4)
else:
    print('Não achei o 4')

print(num)
print(f'Essa lista tem {len(num)} elementos.')
print('='*40)
valores = []
valores.append(5)
valores.append(9)
valores.append(4)

for c, v in enumerate (valores):
    print(f'Na posição {c} encontrei o valor {v}')
print('Cheguei ao final da lista.')
print('='*40)

valores2 = list()
for cont in range(0,5):
    valores2.append(int(input('Digigte um valor: ')))

for c,v in enumerate(valores2):
    print(f'Na posição {c} encontrei o valor {v}')

a = [2,3,4,7]
b = a
b[2] = 8
print(f'Lista de a: {a}')
print(f'Lista de b: {b}')
print('='*40)
    
a = [2,3,4,7]
b = a[:]
b[2] = 8
print(f'Lista de a: {a}')
print(f'Lista de b: {b}')
print('='*40)
