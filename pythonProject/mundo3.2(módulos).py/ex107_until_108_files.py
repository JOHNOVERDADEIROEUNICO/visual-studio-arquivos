def metade(d):
    d = d/2
    return d

def dobro(D):
    D = D*2
    return D

def dezporcento(p):
    p = p + p*0.10
    return p

def moeda(p = 0, m = 'R$'):
    return f'{m}{p:.2f}'.replace('.',',')