class MinhaLista<T>
{
    private T[] dados;
    private int contador;

    public MinhaLista()
    {
        dados = new T[4]; // capacidade inicial
        contador = 0;
    }

    public void Add(T item)
    {
        if (contador == dados.Length)
        {
            // redimensionar: dobra a capacidade
            T[] novoArray = new T[dados.Length * 2];
            for (int i = 0; i < dados.Length; i++)
            {
                novoArray[i] = dados[i];
            }
            dados = novoArray;
        }

        dados[contador] = item;
        contador++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= contador)
            throw new IndexOutOfRangeException();

        return dados[index];
    }
}
