expr = str(input('Digite a sua expressão: '))
pilha = []
for simb in expr:
    if simb == '(':
        pilha.append('(')

    elif simb == ')':
        if len(pilha) > 0:
            pilha.pop()
        else:
            pilha.append(')')
            break
if len(pilha) == 0:
    print('Essa é uma experessão válida!')
else:
    print('Essa é uma expressão inválida')