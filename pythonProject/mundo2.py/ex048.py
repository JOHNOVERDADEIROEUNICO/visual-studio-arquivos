#variaveis
acumulador = 0
s = 0
#para
for i in range (3,501,6):
    acumulador = acumulador+1
    s = s+i
print('A soma de todos os {} valores solicitados é {}'.format(acumulador,s))