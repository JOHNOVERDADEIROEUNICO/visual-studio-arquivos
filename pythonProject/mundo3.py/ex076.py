#tupla = (print('-'*40),
 #        print('LISTAGEM DE PREÇOS'.center(40)),
 #        print('-'*40),
 #        print('Lápis','.'*20,'R$ 1.75''\n''Borracha','.'*20,'R$ 2.00\n''Caderno','.'*20,'R$ 15.90\n''Estojo','.'*20,'R$ 25.00\n''Transferidor','.'*20,'R$ 4.20\n''Compasso','.'*20,'R$ 9.99\n''Mochila','.'*20,'R$ 120.32\n''Canetas','.'*20,'R$ 22.30\n''Livro','.'*20,'R$ 34.90\n'),
 #       print('-'*40))
#Faz mais sentido kkk

listagem = ('Lápis', 1.75,
            'Borracha', 2,
            'Caderno', 15.90,
            'Estojo', 25,
            'Transferidor', 4.20,
            'Compasso', 9.99,
            'Mochila', 120.32,
            'Canetas', 22.30,
            'Livro', 34.90)

print('-'*40),
print('LISTAGEM DE PREÇOS'.center(40))
print('-'*40)

for pos in range(0, len(listagem)):
    if pos % 2 == 0:
        print(f'{listagem[pos]}','.'*30,end='')
    else:
        print(f'R${listagem[pos]:.2f}')
print('-'*40)