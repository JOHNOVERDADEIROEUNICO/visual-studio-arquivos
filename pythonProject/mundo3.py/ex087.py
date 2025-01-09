matriz = [[0,0,0],[0,0,0],[0,0,0]]
s1 = s2 = mai = 0

for l in range (0,3):
    for c in range(0,3):
        matriz[l][c] = int(input(f'Digite um número para [{l},{c}]: '))

print('-='*40)

for l in range (0,3):
    for c in range(0,3):
        print(f'[{matriz[l][c]:^5}]',end='')
    print()

for l in range (0,3):
    for c in range(0,3):
        if matriz[l][c] % 2 == 0:
            s1 += matriz[l][c]

for l in range (0,3):
    for c in range(2,3):
        s2 += matriz[l][c]

for l in range (1,2):
    for c in range(0,3):
        if mai == 0:
            mai = matriz[l][c]
            
        elif matriz[l][c] > mai:
            mai = matriz[l][c]

print('-='*40)

print(f'A soma dos valores pares é {s1}.\nA soma dos valores da terceira coluna é {s2}.\nO maior valor da segunda linha é {mai}.')

    
