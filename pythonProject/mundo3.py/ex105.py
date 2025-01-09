def notas(*m, sit=False):

    """-> Função para analisar notas e situações de vários alunos.(situação opcional)
    :param m: uma ou mais nota(s) dos alunos.(aceita mais de uma)
    :param sit: (opcional) indica se deve ou não adicionar uma situação.
    :return: dicionário com várias informações sobre a situação da turma"""

    media = {}
    media['total'] = len(m)
    c = 0
    while c < len(m):
        if len(media) == 1:
            media['maior'] = m[c]
            media['menor'] = m[c]

        else:
            if m[c] > media['maior']:
                media['maior'] = m[c]

            elif m[c] < media['menor']:
                media['menor'] = m[c]

        c += 1

    media['media'] = sum(m)/len(m)
    if sit:
        if media['media'] >= 7:
            media['situação'] = 'BOA'

        elif media['media'] == 6:
            media['situação'] = 'OK'

        elif media['media'] < 6:
            media['situação'] = 'RUIM'

    return media

#progama principal
resp = notas(5.5,2.5,1.5)
print(resp)