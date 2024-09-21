namespace Strategy_;

public class Map
{
    private char[,] map;
    public int Width { get; }
    public int Height { get; }

    public Map()
    {
        Width = 6;
        Height = 6;

        map = new char[Height, Width];  // строки, колонки
    }

    public void Print()
    {
        for (int row = 0; row < Height; row++)
        {
            for (int col = 0; col < Width; col++)
                Console.Write(map[row, col] + " ");
            Console.WriteLine();
        }
    }

    public char this[int row, int col]
    {
        get => map[row, col];
        set => map[row, col] = value;
    }


}
