def fatorial(num = 1, show=True):

    """-> Calcula o fatorial de um número.
    :param n: O numero a ser calculado.
    :param show: (opcional) Mostra ou não a aconta colocando True ou false.
    :return: O valor do fatorial de um número n."""

    f = 1
    for c in range (num, 0, -1):
        if show:
            print(c, end='')
            if c > 1:
                print(' x ', end='')
            else:
                print(' = ', end='')

        f *= c
    return f

print(help(fatorial))
print('-'*30)
print(fatorial(5))