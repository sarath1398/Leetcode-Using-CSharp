namespace Heap
{
    internal class Classes
    {
        // Leetcode : 703 - Kth Largest Element in a Stream
        // Approach : Min Heap
        // Time Complexity : O(n log k)
        // Space Complexity : O(k)
        // Type: Easy
        public class KthLargest
        {
            // Min Heap to store the k largest elements
            private PriorityQueue<int, int> heap = new();
            // Size of the heap
            private readonly int k = 0;

            public KthLargest(int k, int[] nums)
            {
                // Initialize the heap size
                this.k = k;
                // Add the initial elements to the heap
                foreach (int num in nums)
                {
                    heap.Enqueue(num, num);
                    // If the heap size exceeds k, remove the smallest element
                    if (heap.Count > k)
                    {
                        heap.Dequeue();
                    }
                }
            }

            public int Add(int val)
            {
                // Add the new element to the heap
                heap.Enqueue(val, val);
                // If the heap size exceeds k, remove the smallest element
                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
                // Return the smallest element in the heap
                return heap.Peek();
            }
        }

        // Leetcode - 1046 - Last Stone Weight
        // Approach : Max Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Easy
        public class LastStoneWeightLC1046 {
            public int LastStoneWeight(int[] stones) {
                PriorityQueue<int,int> queue = new();

                // Add all stones into heap. Used negative values
                // since max heap relies on negative values
                foreach(var stone in stones)
                {
                    queue.Enqueue(-stone,-stone);
                }

                while(queue.Count >= 0)
                {
                    int x = -1,y = -1;
                    // max element
                    if(queue.Count > 0)
                    {
                        y = -queue.Dequeue();
                    }
                    // second max element
                    if(queue.Count > 0)
                    {
                        x = -queue.Dequeue();
                    }
                    // if no elements exist in queue
                    if(x == -1 && y == -1)
                    {
                        return 0;
                    }
                    // if only one element exists
                    else if(x == -1)
                    {
                        return y;
                    }
                    // if x is lesser than y, then it's implied that stone x will break
                    /// and stone y-x will be added
                    else if(x < y)
                    {
                        queue.Enqueue(x - y, x - y); // since -(y-x) = (x-y)
                    }
                    // Note : Haven't handled x == y case since the x and y values 
                    // are dequeued already and x > y doesn't happen
                }

                // return added as a formality. The while loop handles all scenarios
                return -1;
            }
        }

        // Leetcode - 973 - K Closest Points to Origin
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class KClosestLC973 {
            public int[][] KClosest(int[][] points, int k) {
                PriorityQueue<(int x, int y),double> queue = new();
                // add all points into the queue
                foreach(var point in points)
                {
                    int x = point[0];
                    int y = point[1];
                    // calculate distance from origin
                    double distance = (double)Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
                    queue.Enqueue((x,y),distance);
                }
                // create result array
                int[][] result = new int[k][];
                // dequeue the k closest points
                for(int i = 0; i < k; i++)
                {
                    (int x, int y) = queue.Dequeue();
                    result[i] = new int[] {x,y};
                }
                return result;
            }
        }


        // Leetcode - 215 - Find the Kth Largest Element in an Array
        // Approach : Max Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class FindKthLargestLC215 {
            public int FindKthLargest(int[] nums, int k) {
                PriorityQueue<int,int> queue = new();
                // create a max heap
                foreach(int n in nums)
                {
                    queue.Enqueue(-n,-n);
                }
                // pop the top k-1 elements
                for(int i = 0; i < k - 1;i++)
                {
                    queue.Dequeue();
                }
                // return the kth element in the queue
                int val = -queue.Peek();
                return val;
            }
        }

        // Leetcode - 621 - Task Scheduler
        // Approach : Max Heap
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public class TaskSchedulerLC621 {
            public int LeastInterval(char[] tasks, int n) {
                int[] counter = new int[26];
                foreach(var task in tasks)
                {
                    counter[task-'A']++;
                }
                PriorityQueue<int,int> pQueue = new();
                for(int i=0; i<26;i++)
                {
                    int count = counter[i];
                    if(count > 0)
                    {
                        pQueue.Enqueue(count,-count);
                    }
                }
                Queue<(int count, int time)> queue = new();
                int total = 0;
                while(pQueue.Count > 0 || queue.Count > 0)
                {
                    if(queue.Count > 0 && total >= queue.Peek().time)
                    {
                        var (count , _) = queue.Dequeue();
                        pQueue.Enqueue(count, -count);
                    }
                    if(pQueue.Count > 0)
                    {
                        int ele = pQueue.Dequeue() - 1;
                        if(ele > 0)
                        {
                            queue.Enqueue((ele, total + n + 1));
                        }
                    }
                    total++;
                }
                return total;
            }
        }

        // Leetcode - 355 - Design Twitter
        // Approach : Max Heap
        // Time Complexity : O(U * k log k) where U is number of users and k = 10
        // Space Complexity : O(U + T) where T is number of tweets
        // Type: Medium
        public class Twitter {

            // global counter to keep track of time
            int gblCount;
            // map to store user and their followers
            Dictionary<int,HashSet<int>> userMap;
            // map to store user and their tweets
            Dictionary<int,List<(int count, int tweet)>> tweetMap;
            
            public Twitter() {
                gblCount = 0;
                userMap = [];
                tweetMap = [];
            }
            
            // post tweet
            public void PostTweet(int userId, int tweetId) {
                // check if user exists and add if not
                if(!tweetMap.ContainsKey(userId))
                {
                    tweetMap.Add(userId,new());
                }
                var userTweets = tweetMap[userId];
                // add tweet with global counter
                userTweets.Add((++gblCount,tweetId));
            }
            
            // get news feed
            public List<int> GetNewsFeed(int userId) {
                PriorityQueue<int,int> pQueue = new();
                // check if user exists and add if not
                if(!userMap.ContainsKey(userId))
                {
                    userMap.Add(userId,new());
                }
                // add user to their own followers
                if(!userMap[userId].Contains(userId))
                {
                    userMap[userId].Add(userId);
                }
                var followers = userMap[userId];
                // iterate through all followers
                foreach(var follower in followers)
                {
                    // check if follower has tweets
                    if(tweetMap.ContainsKey(follower) && tweetMap[follower].Count > 0)
                    {
                        int tc = tweetMap[follower].Count;
                        // add the 10 most recent tweets of each follower to the priority queue
                        for(int i = 0; i < Math.Min(tc,10); i++)
                        {
                            // iterate from the end to get latest tweets
                            (int cnt, int twt) = tweetMap[follower][tc - i - 1];
                            pQueue.Enqueue(twt,cnt);
                            // keep only top 10 tweets
                            if(pQueue.Count > 10)
                            {
                                pQueue.Dequeue();
                            }
                        }
                    }
                }
                List<int> result = new();
                // dequeue the top 10 tweets
                while(pQueue.Count > 0)
                {
                    // dequeue the tweet
                    pQueue.TryDequeue(out int tweet, out int count);
                    // insert at the beginning to maintain order
                    result.Insert(0,tweet);
                }
                return result;
            }
            
            // follow
            public void Follow(int followerId, int followeeId) {
                // check if user exists and add if not
                if (!userMap.ContainsKey(followerId)) {
                    userMap[followerId] = new HashSet<int>();
                }
                // add followee to followers
                userMap[followerId].Add(followeeId);
            }
            
            // unfollow
            public void Unfollow(int followerId, int followeeId) {
                // check if user exists and remove if not
                if (userMap.ContainsKey(followerId)) {
                    userMap[followerId].Remove(followeeId);
                }
            }
        }

    }
}
