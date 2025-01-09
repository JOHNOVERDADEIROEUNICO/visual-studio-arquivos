#inicio
print('===========================')
print('    10 TERMOS DE UMA PA    ')
print('===========================')
#variaveis/inputs
t1 = int(input('Primeiro Termo: '))
r = int(input('Razão: '))
decimo = t1 + (9) * r
#for/para/resposta
for i in range(t1,decimo+r,r):  
    print(i,end=' -> ')
print('ACABOU.')
#ACABOU.