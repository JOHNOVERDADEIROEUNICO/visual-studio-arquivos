n1= int (input('um valor: '))
n2= int (input('Outro valor: '))
print('A soma vale {}, o prduto é {}, e a divisão é {:.3f}'.format(n1+n2,n1*n2,n1/n2))
print('ou pra nao ficar tao grande assim')
s= n1+n2
m= n1*n2
d= n1/n2
print('A soma vale {}, o produto é {}, e a divisão é {}'.format(s,m,d))
print('A soma vale {}, \n o produto é {}, \n e a divisão é {}'.format(s,m,d))
print('A soma vale {}, o produto é {}, e a divisão é {}'.format(s,m,d), end='>>>')
print('A soma vale {}, o produto é {}, e a divisão é {}'.format(s,m,d))