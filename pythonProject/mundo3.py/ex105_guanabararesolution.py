def notas(*n, sit=False):
    media = dict()
    media['total'] = len(n)
    media['maior'] = max(n)
    media['menor'] = min(n)
    media['média'] = sum(n)/len(n)

    if sit:
        if media['média'] >= 7:
            media['situação'] = 'BOA'

        elif media['média'] == 6:
            media['situação'] = 'OK'

        elif media['média'] < 6:
            media['situação'] = 'RUIM'

    return media

resp = notas(5.5,2.5,1.5, sit=True)
print(resp)