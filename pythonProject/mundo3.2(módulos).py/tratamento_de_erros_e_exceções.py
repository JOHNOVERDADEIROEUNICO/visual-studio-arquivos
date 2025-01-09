
a = int(input('Numerador: '))
b = int(input('Denominador: '))
#Se colocarmos 0 como denominador o python nos apresenta o erro ZeroDivisionError, agora como bular isso? como evitarmos que o usuario faça caca e estrague o nosso belo código? (ou pelo menos tentar) vamos a parte 2
r = a/b

print(f'O resultado é {r}')