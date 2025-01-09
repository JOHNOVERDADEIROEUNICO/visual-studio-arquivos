nf: int
nh: int
smh: float
sm: float

nf = int(input("Digite o numero de funcionario da empresa: "))
nh = int(input("Digite o numero de horas trabalhadas durante o mês: "))
smh = 6.42
sm = smh*nh
print('Os ',nf,' funcionarios devem receber um total de: R$',sm)
print('E a empresa ira desembolsar um total de salario de: R$ {:.2f} '.format(sm*nf))
r = sm+(sm*0.15)
print('Para os funcionarios que receberam um bonus de 15 eles receberão: R$ {:.2f} '
      .format(r))