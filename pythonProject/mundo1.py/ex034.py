salario = float(input('(OBS: salários abaixo de 1.250,00R$ recebram 15% de aumento e os acima 10%) Quanto o funcionario recebe por mês? '))

if salario <= 1250.00:
    salario = salario + (salario * 0.15)
else:
    salario = salario + (salario * 0.10)
print('O funcionario receberá {:.2f}'.format(salario))