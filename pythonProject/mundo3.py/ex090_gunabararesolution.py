media = dict()

media['nome'] = str(input('Nome: '))
media['média'] = float(input(f'Média de {media['nome']}: '))

if media['média'] >= 6:
    media['situação'] = 'Aprovado'
else:
    media['situação'] = 'Reprovado'

print('-='*40)

for k,v in media.items():
    print(f' - {k} é igual a {v}')