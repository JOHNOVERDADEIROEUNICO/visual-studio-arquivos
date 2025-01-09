from ex109files import dobro, metade, moeda

def linha():
    print('-'*30)


def cabeçario():
    linha()
    print('RESUMO DO VALOR'.center(30))
    linha()


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