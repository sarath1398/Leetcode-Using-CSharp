using static Heap.Classes;

namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
            // Console.WriteLine(kthLargest.Add(3));   // returns 4
            // Console.WriteLine(kthLargest.Add(5));   // returns 5
            // Console.WriteLine(kthLargest.Add(10));  // returns 5
            // Console.WriteLine(kthLargest.Add(9));   // returns 8
            // Console.WriteLine(kthLargest.Add(4));   // returns 8

            // LastStoneWeightLC1046 lastStoneWeight = new LastStoneWeightLC1046();
            // Console.WriteLine(lastStoneWeight.LastStoneWeight([2,7,4,1,8,1]));

            // KClosestLC973 kClosest = new KClosestLC973();
            // int[][] points = [[1,3],[-2,2]];
            // int k = 1;
            // int[][] result = kClosest.KClosest(points,k);
            // foreach(var point in result)
            // {
            //     Console.WriteLine(point[0] + " " + point[1]);
            // }   

            // var taskScheduler = new TaskSchedulerLC621();
            // char[] tasks = ['A','A','A','B','B','B'];
            // int n = 2;
            // int result = taskScheduler.LeastInterval(tasks,n);
            // Console.WriteLine(result);

            // var twitter = new Twitter();
            // twitter.PostTweet(1,5);
            // foreach(var tweet in twitter.GetNewsFeed(1))
            // {
            //     Console.Write(tweet + " ");
            // }
            // twitter.Follow(1,2);
            // twitter.PostTweet(2,6);
            // foreach(var tweet in twitter.GetNewsFeed(1))
            // {
            //     Console.Write(tweet + " ");
            // }
            // twitter.Unfollow(1,2);
            // foreach(var tweet in twitter.GetNewsFeed(1))
            // {
            //     Console.Write(tweet + " ");
            // }

            // var reorganizeString = new ReorganizeStringLC767();
            // string s = "aab";
            // Console.WriteLine(reorganizeString.ReorganizeString(s));

            // s = "aaab";
            // Console.WriteLine(reorganizeString.ReorganizeString(s));

            var longestHappyString = new LongestHappyStringLC1405();
            Console.WriteLine(longestHappyString.LongestDiverseString(1,1,7));
            Console.WriteLine(longestHappyString.LongestDiverseString(7,1,0));
        }
    }
}
