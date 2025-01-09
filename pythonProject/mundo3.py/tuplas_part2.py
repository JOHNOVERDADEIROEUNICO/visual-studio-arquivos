lanche = 'Hamburguer','Suco','Pizza','Pudim'
print(sorted(lanche))
#ordena em ordem alfabetica a tupla, para fazer essa mudança o python transforma a tupla em lista, perceba os colchetes ao ínvez do parênteses, veremos listas mais pra frente.
a = (2,5,4)
b = (5,8,1,2)
c = a + b
print('='*10)
print(c)
#é possível juntar duas tuplas dentro de uma mesma.
print('='*10)
print(c.count(5))
#quantas vezes aparece 5 na lista.
print('='*10)
print(c.index(8))
#a posição de 8, ele analisa a primeira ocorrencia a partir da posição que você comanda ele começar a analisar.
print('='*10)

pessoa = ('John', 39, 'M', 82.60)
#da pra colocar mais de um primitivo.
#você não consegue deletar um elemento de uma tupla, afinal você a estaria modificando, porém, você pode apaga_la por completo usando del.