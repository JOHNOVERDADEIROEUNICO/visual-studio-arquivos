
from datetime import datetime

aposen = dict()

aposen['nome'] = str(input('Nome: '))

ano = int(input('Ano de nascimento: '))

aposen['idade'] = 2024 - ano
aposen['ctps'] = int(input('Carteira de trabalho (0 não tem): '))

if aposen['ctps'] > 0:
    aposen['contratação'] = (input('Ano de contratação: '))
    aposen['salário'] = float(input('salário: R$'))

    if 65 - aposen['idade'] >= 15: 
        aposen['aposent'] = 65

    elif 65 - aposen['idade'] < 15:
        aposen['aposent'] = aposen['idade'] + 15

print('-='*40)

for k,v in aposen.items():
    print(f' - {k} tem o valor {v}')
