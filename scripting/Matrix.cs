using System.Collections.Generic;
using Godot;

class Matrix {

    Vector2I matrixSize = new Vector2I(10,10);
    Cell[,] matrix;

    public void test() 
    {
        matrix = new Cell[matrixSize.Y, matrixSize.X];
        // AddCell(new Vector2I(5,5), new Cell());
        // AddCell(new Vector2I(-1,9), new Cell());
        // AddCell(new Vector2I(10,10), new Cell());
        // AddCell(new Vector2I(15,9), new Cell());
        // AddCell(new Vector2I(5,5), new Cell());
        for (int i = 0; i < matrixSize.Y; i++) 
        {
            for (int j = 0; j < matrixSize.X; j++) 
            {
                if (matrix[i,j] != null) {
                    GD.Print(i + ", " + j);
                }
            }
        }
    }

    public void AddCell(Vector2I position, Cell cell) {
        if (position.X >= matrixSize.X || position.Y >= matrixSize.Y || position.X < 0) {
            ExtendMatrix(position);
        }
        var x = position.X < 0 ? 0 : position.X;
        cell.position = new Vector2I(x, position.Y);
        matrix[position.Y, x] = cell;
    }

    private void ExtendMatrix(Vector2I position) {
        bool extendRight = position.X >= matrixSize.X;
        bool extendDown = position.Y >= matrixSize.Y;
        bool extendLeft = position.X < 0;

        var newRowCount = extendDown ? position.Y + 1 : matrixSize.Y;
        var newColumnsCount = extendRight ? position.X + 1 : matrixSize.X;
        newColumnsCount = extendLeft ? matrixSize.X - position.X : newColumnsCount;

        var newMatrix = new Cell[newRowCount, newColumnsCount];

        for (int i = 0; i < newRowCount; i++)
        {
            for (int j = 0; j < newColumnsCount; j++) 
            {
               var oldMatrixX = extendLeft ? j + position.X : j;
               if (oldMatrixX >= 0 && oldMatrixX < matrixSize.X && i < matrixSize.Y)
               {
                newMatrix[i,j] = matrix[i, oldMatrixX];
               }
               else 
               {
                newMatrix[i,j] = null;
               }
            }
        }

        matrix = newMatrix;
        matrixSize = new Vector2I(newColumnsCount, newRowCount);
    }
}