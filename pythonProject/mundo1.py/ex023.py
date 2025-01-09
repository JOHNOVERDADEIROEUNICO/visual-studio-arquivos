n = int(input('informe um numero: '))
print('Analisando o numero ',n)
u = n // 1 % 10
d = n // 10 % 10
c = n // 100 % 10
m = n // 1000 % 10
print('Unidade:',u)
print('Dezena:',d)
print('centena:',c)
print('milhar:',m)
#Era pra ser uma manipulaçao de texto, porém para este exercicio dar certo em manipulação de texto seria necessario condicional que ainda nao foi apresentado no curso entao esta é a resolução com otipo primitivo inteiro.