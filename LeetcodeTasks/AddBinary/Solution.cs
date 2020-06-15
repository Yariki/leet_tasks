namespace LeetcodeTasks.AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b) 
        {
            var addBin = new AddBinary(a,b);
            return addBin.SolutionOne();
        }
    }
}