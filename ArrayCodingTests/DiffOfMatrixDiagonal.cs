namespace ArrayCodingTests
{
    [TestClass]
    public sealed class DiffOfMatrixDiagonal
    {
        [TestMethod]
        public void DiffOfMatrixDiagonalTest()
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int>() { 1, 2, 3 });
            arr.Add(new List<int>() { 4, 5, 6 });
            arr.Add(new List<int>() { 17, 8, 9 });
            List<int> diag1 = new List<int>();
            List<int> diag2 = new List<int>();
            int n = 3;
            int[,] matrix = new int[n, n];

            // Read matrix from input
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    matrix[i, j] = arr[i][j];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];               // Top-left to bottom-right
                secondaryDiagonal += matrix[i, n - 1 - i];     // Top-right to bottom-left
            }

            int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(difference);
        }
    }
}
