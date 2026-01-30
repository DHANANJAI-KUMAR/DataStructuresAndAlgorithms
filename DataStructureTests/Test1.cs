using System.Diagnostics;

namespace DataStructureTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 153;
            int remainder = input;
            int cubeSum = 0;

            while (remainder > 0)
            {
                remainder = remainder % 10;
                cubeSum = cubeSum + (remainder * remainder * remainder);
                remainder = remainder / 10;
            }
            var aa =  cubeSum == input;
        
        
        var arr = new string("HELLO DHANANJAI");
            var opBuilder = new System.Text.StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                opBuilder.Append(arr[i]);
            }

        }

        public int ComputeSizeOnDisk(int clusterSize, int fileSize) 
        {
            if (clusterSize <= 0 || fileSize < 0) 
                throw new ArgumentException("Cluster size must be positive and file size cannot be negative."); 

            int clusters = 0; 
            
            //int remaining = fileSize; 
            //while (remaining > 0) 
            //{ 
            //    clusters++; 
            //    remaining = remaining - clusterSize; 
            //}

            while (clusters * clusterSize < fileSize) 
            { 
                clusters++; 
            }
            return clusters * clusterSize;
        }

        public static int ComputeSizeOnDisk1(int clusterSize, int fileSize) 
        { 
            int sizeOnDisk = 0; 

            while (sizeOnDisk < fileSize) 
            { 
                sizeOnDisk = sizeOnDisk + clusterSize; 
            } 
            return sizeOnDisk; 
        }


    }
}
