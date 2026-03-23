using System.Text;

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

        // Leetcode - 767 - Reorganize String
        // Approach : Max Heap
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public class ReorganizeStringLC767 {
            public string ReorganizeString(string s) {
                int[] counter = new int[26];
                foreach(char c in s)
                {
                    counter[c - 'a']++;
                }
                PriorityQueue<char,int> pq = new();
                StringBuilder sb = new();
                for(int i = 0; i< 26; i++)
                {
                    int count = counter[i];
                    if(count > 0)
                    {
                        pq.Enqueue((char)('a' + i),-count);
                    }
                }
                char prevChar = '#';
                int prevCount = 0;
                while(pq.Count > 0)
                {
                    pq.TryDequeue(out char task, out int count);
                    sb.Append(task);
                    count++;
                    if(prevCount > 0)
                    {
                        pq.Enqueue(prevChar, -prevCount);
                    }
                    prevChar = task;
                    prevCount = -count;
                }
                return sb.Length == s.Length ? sb.ToString() : "";
            }
        }

        // Leetcode - 1405 - Longest Happy String
        // Approach : Max Heap
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public class LongestHappyStringLC1405 {
            public string LongestDiverseString(int a, int b, int c) {
                PriorityQueue<char,int> pQueue = new();
                // add all the characters to the priority queue
                if(a > 0)
                    pQueue.Enqueue('a',-a);
                if(b > 0)
                    pQueue.Enqueue('b',-b);
                if(c > 0)
                    pQueue.Enqueue('c',-c);

                StringBuilder sb = new();
                // iterate through the priority queue
                while(pQueue.Count > 0)
                {
                    // dequeue the most frequent character
                    pQueue.TryDequeue(out char fLetter, out int fCount);
                    int sLength = sb.Length;
                    // check if the last two characters are the same as the current character
                    if(sLength >= 2 && sb[^1] == sb[^2] && sb[^1] == fLetter)
                    {
                        // check whether second most frequent character is available to dequeue
                        if(pQueue.Count == 0)
                        {
                            break;
                        }
                        // if the last two characters are the same as the current character, dequeue the second most frequent character
                        else
                        {
                            // dequeue the second most frequent character
                            pQueue.TryDequeue(out char sLetter, out int sCount);
                            sb.Append(sLetter);
                            sCount++;
                            // enqueue the second most frequent character back if count exists
                            if(sCount < 0)
                            {
                                // enqueue the second most frequent character back
                                pQueue.Enqueue(sLetter,sCount);
                            }
                            // enqueue the most frequent character back
                            pQueue.Enqueue(fLetter,fCount);
                        }
                    }
                    // if the last two characters are not the same as the current character, dequeue the most frequent character
                    else
                    {
                        // append the most frequent character
                        sb.Append(fLetter);
                        fCount++;
                        // enqueue the most frequent character back if count exists
                        if(fCount < 0)
                        {
                            pQueue.Enqueue(fLetter,fCount);
                        }
                    }
                }
                // return the result
                return sb.ToString();
            }
        }

        // Leetcode - 1834 - Single-Threaded CPU
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class SingleThreadedCPULC1834 {
            public int[] GetOrder(int[][] tasks) {
                int n = tasks.Length;
                int i = 0;
                // add index to each task
                for(; i < tasks.Length; i++)
                {
                    tasks[i] = new int[3] { tasks[i][0], tasks[i][1], i };
                }
                // sort tasks based on enqueue time
                Array.Sort(tasks,(a,b) => a[0].CompareTo(b[0]));
                // create a min heap to store tasks based on processing time
                PriorityQueue<(int pTime, int idx),(int pTime,int idx)> pq = new();
                // initialize time to the first task's enqueue time
                int time = tasks[0][0];
                int[] result = new int[n];
                int idx = 0;
                i = 0;
                // iterate through the priority queue
                while(pq.Count > 0 || i < n)
                {
                    // add all the tasks that can be processed at the current time
                    while(i < n && tasks[i][0] <= time)
                    {
                        pq.Enqueue((tasks[i][1],tasks[i][2]),(tasks[i][1],tasks[i][2]));
                        i++;
                    }
                    // if the priority queue is empty, update the time to the next task's enqueue time
                    // and continue
                    if(pq.Count == 0)
                    {
                        time = tasks[i][0];
                    }
                    // if the priority queue is not empty, dequeue the task with the smallest processing time
                    else
                    {
                        (int pTime, int indx) = pq.Dequeue();
                        result[idx++] = indx;
                        time+=pTime;
                    }
                }
                // return the result
                return result;
            }
        }

        // Leetcode - 1094 - Car Pooling
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class CarPoolingLC1094 {
            public bool CarPooling(int[][] trips, int capacity) {
                // sort tasks based on start time
                Array.Sort(trips,(a,b) => a[1].CompareTo(b[1]));

                // create a min heap to store tasks based on end time
                PriorityQueue<(int to, int capacity), int> pq = new();
                // initialize total capacity to 0
                int total = 0;

                // iterate through the trips
                foreach(var trip in trips)
                {
                    // get the capacity, start time, and end time
                    int cap = trip[0];
                    int start = trip[1];
                    int end = trip[2];
                    // remove all the trips that end before the current trip starts
                    while(pq.Count > 0 && pq.Peek().to <= start)
                    {
                        total -= pq.Dequeue().capacity;
                    }
                    // add the current trip's capacity to the total
                    total += cap;
                    // if the total capacity exceeds the total capacity, return false
                    if(total > capacity)
                    {
                        return false;
                    }
                    // enqueue the current trip's end time and capacity
                    pq.Enqueue((end,cap),end);
                }
                // return true if all the trips are processed successfully
                return true;
            }
        }

        // Leetcode - 502 - IPO
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Hard
        public class IPOLC502 {
            public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
                // create an array of indices
                int n = capital.Length;
                int[] indices = new int[n];
                // fill the indices array with 0 to n-1
                for(int i=0;i<n;i++)
                {
                    indices[i] = i;
                }
                // sort the indices based on the capital
                Array.Sort(indices,(a,b) => capital[a].CompareTo(capital[b]));

                // create a max heap to store the profits
                PriorityQueue<int,int> heap = new();
                int idx = 0;

                // iterate through the capital array
                for(int i = 0; i < k; i++)
                {
                    // add all the projects that can be started with the current capital
                    while(idx < n && capital[indices[idx]] <= w)
                    {
                        heap.Enqueue(-profits[indices[idx]],-profits[indices[idx]]);
                        idx++;
                    }
                    // if the heap is empty, break
                    if(heap.Count == 0)
                    {
                        break;
                    }
                    // add the maximum profit to the current capital
                    w += -heap.Dequeue();
                }
                // return the maximized capital
                return w;
            }
        }

        // Leetcode - 295 - Find Median from Data Stream
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Hard
        public class MedianFinderLC295 {
            // Have two heaps, one max heap and one min heap
            // Max heap stores the smaller half of the numbers
            // Min heap stores the larger half of the numbers
            // The size of the two heaps should be equal or the max heap should have one more element than the min heap
            PriorityQueue<int,int> maxHeap;
            PriorityQueue<int,int> minHeap;

            // Constructor
            public MedianFinderLC295() {
                maxHeap = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));
                minHeap = new();
            }
                
            // Add number to the heap
            public void AddNum(int num) {
                // If the number is greater than the top of the min heap, add it to the min heap
                if(minHeap.Count != 0 && num > minHeap.Peek())
                {
                    minHeap.Enqueue(num,num);
                }
                // Otherwise, add it to the max heap
                else
                {
                    maxHeap.Enqueue(num,num);
                }
            
                // Balance the heaps
                // If the min heap has more than one element than the max heap, move the top of the min heap to the max heap
                if (minHeap.Count > maxHeap.Count + 1)
                {
                    minHeap.TryDequeue(out int n, out int p);
                    maxHeap.Enqueue(n,p);
                }
                // If the max heap has more than one element than the min heap, move the top of the max heap to the min heap
                else if (maxHeap.Count > minHeap.Count + 1)
                {
                    maxHeap.TryDequeue(out int n, out int p);
                    minHeap.Enqueue(n,p);
                }
            }
            
            public double FindMedian() {
                // If the max heap has more elements than the min heap, return the top of the max heap
                if(maxHeap.Count > minHeap.Count)
                {
                    return (double)maxHeap.Peek();
                }
                // If the min heap has more elements than the max heap, return the top of the min heap
                else if(maxHeap.Count < minHeap.Count)
                {
                    return (double)minHeap.Peek();
                }
                // If the two heaps have equal number of elements, return the average of the top of the max heap and the top of the min heap
                return (double) (minHeap.Peek() + maxHeap.Peek()) / 2;
            }
        }
    }
}
