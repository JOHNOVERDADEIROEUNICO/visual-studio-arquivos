
from random import randint

maior = 0
menor = 0
valors = (randint(1,10),randint(1,10),randint(1,10),randint(1,10),
          randint(1,10))
print('Os valores sorteados foram: ', end='')
for c in valors:
    print(f'{c}', end=' ')
    
print('\nO maior valor sorteado foi: ',max(valors))
print('O menor valor sorteado foi: ',min(valors))