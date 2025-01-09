nome = str(input('Qual é o seu nome? '))

if nome == 'John':
    print('Que nome lindo!')
elif nome == 'Bruno' or nome == 'Ana':
    print('Seu nome é bem popular no Brasil')
else:
    print('Seu nome é bem normal.')
print('Tenhaum bom dia, {}!'.format(nome))