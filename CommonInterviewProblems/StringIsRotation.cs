namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class StringIsRotation
    {
        [TestMethod]
        public void StringIsRotationTest()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";

            s1 = "abcd";
            s2 = "cdab";

            var status = IsRotationNew(s1, s2);
            Console.WriteLine($"Is '{s2}' a rotation of '{s1}'? {status}");
        }


        private bool IsRotationNew(string s1, string s2)
        {
            /*The idea is to generate all possible rotations of the first string and check if any of these rotations match the second string. 
             * If any rotation matches, the two strings are rotations of each other, otherwise they are not.
             */
            for (int i = 0; i < s1.Length; ++i)
            {
                // If current rotation is equal to s2, return true
                if (s1 == s2)
                    return true;

                // Right rotate s1
                char last = s1[s1.Length - 1];
                s1 = last + s1.Substring(0, s1.Length - 1);
            }
            return false;
        }

        private bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length || s1.Length == 0)
                return false;

            string combined = s1 + s1;
            return combined.IndexOf(s2) > -1 ? true : false;
            //return combined.Contains(s2);
        }

    }
}
