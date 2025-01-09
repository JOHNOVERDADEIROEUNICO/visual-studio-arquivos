def teste(b):
    #Tire a hastag para que (a) no print lá embaixo passe a valer o mesmo que aqui dentro do def.
    #global a
    a = 8 
    b += 4
    c = 2

    print(f'A dentro vale {a}')
    print(f'B dentro vale {b}')
    print(f'C dentro vale {c}')

a = 5

#teste(a)

print(f'A fora vale {a}')

def somar(d=0,f=0,g=0):
    s = d+ f + g
    #Para que s1 receba a soma de 2+2+2 tire a hastag do return.
    #return s

s1 = somar(2,2,2)
print(s1)