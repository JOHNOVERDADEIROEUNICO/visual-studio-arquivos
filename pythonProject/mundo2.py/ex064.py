
c = n2 = acumulator = 0

while c != 999:
    n1 = int(input('Digite um número [999 para parar]: '))
    if n1 != 999:
        acumulator += 1
        n2 += n1
    c = n1
print(f'Você digitou {acumulator} números e a soma entre eles foi {n2}')
    

