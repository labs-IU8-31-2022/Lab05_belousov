namespace Lab05_belousov;

public class MyMatrix
{
    private double[,] Data;
    private uint _Rows;
    private uint _Colomns;
    private int _Range_of_numbers;
    public uint Rows { get => _Rows; set { _Rows = value; } }
    public uint Colomns { get => _Colomns; set { _Colomns = value; } }
    
    public MyMatrix(uint n, uint m, int range)
    {
        _Rows = n;
        _Colomns = m;
        _Range_of_numbers = range;
        Random random_number = new Random();
        Data = new double[_Rows, _Colomns];
        for (uint i = 0; i < _Rows; ++i)
        {
            for (uint j = 0; j < _Colomns; ++j)
            {
                Data[i, j] = random_number.Next() % _Range_of_numbers;
            }
        }
    }
    
    public MyMatrix Fill()
    {
        Random random_number = new Random();
        for (uint i = 0; i < _Rows; ++i)
        {
            for (uint j = 0; j < _Colomns; ++j)
            {
                Data[i, j] = random_number.Next() % _Range_of_numbers;
            }
        }

        return this;
    }

    public MyMatrix ChangeSize(uint new_rows, uint new_colomns)
    {
        if (new_rows == _Rows && new_colomns == _Colomns)
        {
            return this;
        }

        uint current_rows = (new_rows < _Rows) ? new_rows : _Rows;
        uint current_colomns = (new_colomns < _Colomns) ? new_colomns : _Colomns;
        MyMatrix new_matrix = new MyMatrix(new_rows, new_colomns, _Range_of_numbers);
        double[,] new_data = new double[new_rows, new_colomns];
        for (uint i = 0; i < current_rows; ++i)
        {
            for (uint j = 0; j < current_colomns; ++j)
            {
                new_matrix.Data[i, j] = Data[i, j];
            }
        }
        
        if (new_rows >= _Rows && new_colomns >= _Colomns)
        {
            for (uint i = 0; i < new_rows; ++i)
            {
                Random random_number = new Random();
                if (i < _Rows)
                {
                    for (uint j = _Colomns; j < new_colomns; ++j)
                    {
                        new_matrix.Data[i, j] = random_number.Next() % _Range_of_numbers;
                    }
                }
                else
                {
                    for (uint j = 0; j < new_colomns; ++j)
                    {
                        new_matrix.Data[i, j] = random_number.Next() % _Range_of_numbers;
                    }
                }
            }
        } else if (new_rows < _Rows && new_colomns > _Colomns)
        {
            Random random_number = new Random();
            for (uint i = _Colomns - 1; i < new_colomns; ++i)
            {
                new_matrix.Data[current_rows - 1, i] = random_number.Next() % _Range_of_numbers;
            }
        }
        else
        {
            Random random_number = new Random();
            for (uint i = _Rows - 1; i < current_rows; ++i)
            {
                new_data[i, current_colomns - 1] = random_number.Next() % _Range_of_numbers;
            }
        }
        return new_matrix;
    }

    public void Show()
    {
        for (uint i = 0; i < _Rows; ++i)
        {
            for (uint j = 0; j < _Colomns; ++j)
            {
                Console.Write($"{Data[i, j]} ");
            }
            Console.WriteLine("");
        }
    }

    public void ShowPartialy(uint rows, uint colomns)
    {
        for (uint i = 0; i < rows; ++i)
        {
            for (uint j = 0; j < colomns; ++j)
            {
                Console.Write($"{Data[i, j]} ");
            }
            Console.WriteLine("");
        }
    }
    
    public double this[int row, int colomn]
    {
        get => Data[row, colomn];
        set
        {
            Data[row, colomn] = value;
        }
    }
}