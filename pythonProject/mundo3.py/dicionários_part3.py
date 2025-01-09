estado = dict()
brasil = list()
for c in range(0, 3):
    estado['uf'] = str(input('Unidade federativa: '))
    estado['sigla'] = str(input('Sigla do Estado: '))
    brasil.append(estado.copy())

print('='*20)
# for pra lista.
for e in brasil:
    #for para o dicionário.
    for k,v in e.items():
        print(f'O campo {k} tem valor {v}.')

print('='*20)

dicio = dict()
v1: str
dicio = {v1}

print(dicio)

v = 'apro'
dicio2 = {'si': 5, 'si2': 2 ,'si3': 3, 'si4': 1}
print(max(dicio.values()))
print(max(dicio.items()))
print('='*20)