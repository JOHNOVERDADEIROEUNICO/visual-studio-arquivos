#variáveis.
vc: float
sl: float
ano: int
prm: float
#inputs e calculo da prestação.
mes = 12
vc = float(input('Qual o valor do imóvel? '))
sl = float(input('Quanto você ganha por mês? R$'))
ano = int(input('Em quantos se pretende pagar esse imóvel? '))
mes = mes * ano
prm = vc / mes
#resposta do programa.
print('O total de meses em que irá ser pago o imóvel será de {} e o valor mensal será de R${:.2f}'.format(mes,prm))
if prm > sl * 0.30:
    print('Infelizemnete o seu salario é muito baixo, emprestimo negado.')
else:
    print('Emprestimo aprovado!')
#ACABOU.