using System;

public class Node<T>
{
    public T Valor;
    public Node<T> Proximo;
    public Node<T> Anterior;

    public Node(T valor)
    {
        Valor = valor;
        Proximo = null;
        Anterior = null;
    }
}

public class MinhaLinkedList<T>
{
    private Node<T> inicio;
    private Node<T> fim;
    public int Tamanho { get; private set; }

    public MinhaLinkedList()
    {
        inicio = null;
        fim = null;
        Tamanho = 0;
    }

    public void AdicionarNoFim(T valor)
    {
        Node<T> novo = new Node<T>(valor);
        if (inicio == null)
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            fim.Proximo = novo;
            novo.Anterior = fim;
            fim = novo;
        }
        Tamanho++;
    }

    public void Remover(T valor)
    {
        Node<T> atual = inicio;
        while (atual != null)
        {
            if (atual.Valor.Equals(valor))
            {
                if (atual.Anterior != null)
                    atual.Anterior.Proximo = atual.Proximo;
                else
                    inicio = atual.Proximo;

                if (atual.Proximo != null)
                    atual.Proximo.Anterior = atual.Anterior;
                else
                    fim = atual.Anterior;

                Tamanho--;
                return;
            }
            atual = atual.Proximo;
        }
    }

    public void Imprimir()
    {
        Node<T> atual = inicio;
        while (atual != null)
        {
            Console.Write(atual.Valor + " ");
            atual = atual.Proximo;
        }
        Console.WriteLine();
    }
}
