frase = input('Digite uma frase: ').strip()
frase = frase.lower()
print('A letra A aparece {} vezes na frase.\nA primeira letra A apareceu na posição {}\nA última letra A apareceu na posição {}'.format(frase.count('a'),frase.find('a')+1,frase.rfind('a')+1))