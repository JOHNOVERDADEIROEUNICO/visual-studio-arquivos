largura: float
altura:  float

largura = float(input('Largura da parede: '))
altura = float(input('Altura da parede: '))
print('Sua parede de ', largura, 'x', altura, ' tem a área de ', area, 'm²')
area = largura*altura
print('A quantidade de tinta necessária para pintar esta parede é de: ', area/2, 'L')
