media = dict()

n = str(input('Nome: '))
m = float(input(f'Média de {n}: '))
if m >= 6:
    s = 'Aprovado'
else:
    s = 'Reprovado'

media['nome'] = n
media['média'] = m
media['situação'] = s

print('-='*40)

for k,v in media.items():
    print(f'- {k} é igual a {v}')



