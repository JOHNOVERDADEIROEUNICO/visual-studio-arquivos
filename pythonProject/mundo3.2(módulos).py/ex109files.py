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