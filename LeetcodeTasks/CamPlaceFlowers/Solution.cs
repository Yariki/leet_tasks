namespace LeetcodeTasks.CamPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n) 
        {
            var sol = new CanPlaceFlowers(flowerbed,n);
            return sol.CanFlowersBePlaced();
        }
    }
}