
c = 0
s = str(input('Informe seu sexo [m/f]: ')).strip().upper()[0]

while s not in 'MmFf':

    s = str(input('Informção inválida, digite seu sexo novamente: ')).strip().upper()[0]
    if s == 'm' or s == 'f':
        c = 1

if s == 'M':

    print('Registrado. você pertence ao sexo Masculino.')

else:

    print('Registrado. você pertence ao sexo Feminino.')
