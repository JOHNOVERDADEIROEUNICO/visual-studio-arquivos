nome = str(input('Digite o seu nome completo: '))
print('analisando o seu nome ...')
mai = nome.upper()
print('Seu nome em maiúsculo fica: ',mai)
minu = nome.lower()
print('Seu nome em minúscula fica: ',minu)
tam = len(nome)
print('O tamanho do seu nome é: ',tam)
pri = nome.split()
print('O seu primeiro nome é: ',pri [0],' e ele possui: {}' .format(len(pri[0])) ,' letras.')