pessoas = {'nome': 'John', 'sexo': 'm', 'idade': 19}
print(pessoas)
print(pessoas['nome'])
print(f'{pessoas['nome']} tem {pessoas['idade']} anos.')
print(pessoas.keys())
print(pessoas.values())
print(pessoas.items())
pessoas ['peso'] = 85.78

print('='*20)

for k in pessoas.keys():
    print(k)

print('='*20)

for k, v in pessoas.items():
    print(f'{k} = {v}')

