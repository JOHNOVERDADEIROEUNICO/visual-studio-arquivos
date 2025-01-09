escolha = 0
tf = []
acumulador = -1
while escolha != 4:
    print('==== GERENCIADOR DE TAREFAS ====')
    print('[1] Adicionar Tarefa\n[2] Exibir Tarefa\n[3] Remover Tarefa\n[4] Sair')
    escolha = int(input('O que deseja fazer? '))
    match escolha:
        case 1:
            ad = str(input('ADICIONE A TAREFA: '))
            tf.append(ad)
            acumulador = acumulador+1
            
        case 2:
            if len(tf) ==0:
                print('Não há nada aqui ainda.')
            else:
                print(tf)

        case 3: 
            acumulador
            delete = int(input('Digite aqui: '))
            if delete >= 0 and delete <= acumulador:
                tf.pop(delete)
                print('A tarefa do indice {} foi deletado'.format(delete))
            else:
                print('Indice inválido. Nenhuma tarefa removida.')