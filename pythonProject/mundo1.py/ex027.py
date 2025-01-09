nome: str

nome = str(input('Digite o seu nome completo: ')).split()
print('Muito prazer em te conhecer!')
print('O seu priemeiro nome é {}'.format(nome[0]))
print('O seu último nome é {}'.format(nome[-1]))
