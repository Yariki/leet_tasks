namespace LeetcodeTasks
{
    public class BaseTest
    {
        protected bool CheckArrayEquality(int[] expected, int[] result)
        {
            if (expected.Length != result.Length)
                return false;


            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != result[i])
                    return false;
            }

            return true;
        }
    }
}