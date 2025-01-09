from time import sleep

lista = []
boletim = []
media = []

while True:
    nome = str(input('Nome: '))
    lista.append(nome)
    nota1 = float(input('Nota 1: '))
    lista.append(nota1)
    nota2 = float(input('Nota 2: '))
    lista.append(nota2)

    boletim.append(lista[:])
    lista.clear()

    resp = str(input('Quer continuar? '))
    if resp != 's':
        break
print('-='*40)

pos = 0
while pos < len(boletim):
    s = boletim[pos][1] + boletim[pos][2]
    s = s/2

    media.append(s)
    s = 0
    pos += 1

print('No. NOME','MÉDIA'.rjust(10))
print('-'*25)

pos = 0
while pos < len(boletim):
    print(f'{pos}',f'{boletim[pos][0]}'.rjust(3),f'{media[pos]}'.rjust(12))
    pos += 1
print('-'*30)

while pos != 999:
    pos = int(input('Mostrar notas de qual aluno (999 interrompe)? '))
    if pos != 999:
        print(f'Notas de {boletim[pos][0]} são: {boletim[pos][1]}, {boletim[pos][2]}')
print('FINALIZANDO...')
sleep(3)
print('<'*3,' VOLTE SEMPRE ','>'*3)