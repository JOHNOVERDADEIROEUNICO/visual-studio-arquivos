def linha():
    print('-'*30)


def cabeçario():
    linha()
    print('RESUMO DO VALOR'.center(30))
    linha()


def metade(d, i=0):
    d = d/2
    i = moeda(d)
    return i


def dobro(D, i=0):
    D = D*2
    i = moeda(D)
    return i


def dezporcento(p, i=0):
    p = p + p*0.10
    i = moeda(p)
    return i


def moeda(p = 0, m = 'R$'):
    return f'{m}{p:.2f}'.replace('.',',')


def estrutura(p=0, aumen=0, dimi=0, i=0):
    i = moeda(p)
    d = dobro(p)
    m = metade(p)
    a = aumento(p, aumen)
    r = diminuo(p, dimi)

    cabeçario()

    print(f'Preço analisado: \t{i}')
    print(f'Dobro do preço: \t{d}')
    print(f'Metade do preço: \t{m}')
    print(f'{aumen}% de aumento: \t{a}')
    print(f'{dimi}& de redução: \t{r}')

    linha()


def aumento(p=0, taxa=0, i=0):
    p = p + (taxa * p / 100)
    i = moeda(p)
    return i


def diminuo(p=0, taxa=0, i=0):
    p = p - (taxa * p / 100)
    i = moeda(p)
    return i