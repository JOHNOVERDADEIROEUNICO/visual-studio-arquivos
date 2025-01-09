


def tse(ida):

    from datetime import datetime

    ida = datetime.now().year - ida

    if 16 == ida < 18 or ida > 65:
        return f'Com {ida} anos seu voto é opcional.'
    elif ida < 16:
        return f'Com {ida} anos você não vota.'
    elif ida >= 18 and ida < 66:
        return f'Com {ida} anos seu voto é obrigatório.'

idade = int(input('Em que ano você nasceu? '))

print(tse(idade))