matriz = [[0,0,0],[0,0,0],[0,0,0]]
i =0
p=0
s=0
while i < 3:
    for s in range(0,3):
        n1 = int(input(f'Digite um valor para [{p}, {s}] :'))
        matriz[p][s] = n1
        
    p+=1
    i+=1
print('-='*40)    
c = 0 
s = 0
while c < len(matriz):
    for s in range (0,3):
        print(f'[{matriz[c][s]:^5}]',end=' ')
    print()
    c+=1