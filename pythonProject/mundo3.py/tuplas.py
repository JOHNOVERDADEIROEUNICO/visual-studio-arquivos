#tuplas sao imutaveis
#lanche = ('Hamburguer','Suco','Pizza','Pudim')
lanche = 'Hamburguer','Suco','Pizza','Pudim'
print('='*10)
print(lanche)
print('='*10)
print(lanche[1])
print('='*10)
print(lanche[-1])
print('='*10)
print(lanche[1:3])
print('='*10)
print(lanche[2:])
print('='*10)
print(lanche[:2])
print('='*10)
print(lanche[-3:])
print('='*10)

for comida in lanche:
    print(f'Eu vou come {comida}')
print('Comi pra caramba!')
print('='*10)
print(len(lanche))

print('='*10)
for cont in range(0, len(lanche)):
    print(f'Eu vou comer {lanche[cont]}')
print('Comi pra caramba!')
#funciona da mesma forma do for acima porém usando range.
print('='*10)
for pos, comida in enumerate(lanche):
    print(f'Eu vou comer {comida} na posição {pos}')
print('Comi pra caramba!')
#um tipo diferente de for que enumera as posições da nossa tupla.