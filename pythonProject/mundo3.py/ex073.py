times = ('botafogo', 'palmeiras', 'flamengo', 'internacional', 'fortaleza', 
         'são paulo', 'corinthains', 'bahia', 'cruzeiro', 'vasco da gama', 
         'vitoria', 'gremio', 'juventude', 'atletico mineiro', 'fluminense', 
         'atletico-pr', 'bragantino', 'criciúma', 'atletico-go', 'cuiabá')
print('Times Brasileiros'.center(40))
print('=-='*15, f'\n{times}\n','=-='*15, f'\nOs cinco primeiros: {times[:5]}\n','=-='*15,f'\nOs 4 últimos colocados: {times[16:]}\n','=-='*15,f'\nO Vasco se encontra na posição: {times.index('vasco da gama')+1}°\n','=-='*15,f'\nTimes em ordem alfabetica: {sorted(times)}')
