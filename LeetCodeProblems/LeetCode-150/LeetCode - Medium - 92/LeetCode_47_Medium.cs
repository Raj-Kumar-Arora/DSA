namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_47_Medium
    {
        public static void RandomizedSet()
        {
            RandomizedSet randomizedSet = new RandomizedSet();

            ////Case - 1
            //var t1 = randomizedSet.Insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
            //var t2 = randomizedSet.Remove(2); // Returns false as 2 does not exist in the set.
            //var t3 = randomizedSet.Insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
            //var t4 = randomizedSet.GetRandom(); // getRandom() should return either 1 or 2 randomly.
            //var t5 = randomizedSet.Remove(1); // Removes 1 from the set, returns true. Set now contains [2].
            //var t6 = randomizedSet.Insert(2); // 2 was already in the set, so return false.
            //var t7 = randomizedSet.GetRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
            //var actualOutput = t1 + " " + t2 + " " + t3 + " " + t4 + " " + t5 + " " + t6 + " " + t7 + " ";

            ////Case - 2
            var t1 = randomizedSet.Insert(1);
            var t2 = randomizedSet.Insert(10);
            var t3 = randomizedSet.Insert(20);
            var t4 = randomizedSet.Insert(30);
            var t5 = randomizedSet.GetRandom();

            var actualOutput = t1 + " " + t2 + " " + t3 + " " + t4 + " " + t5;// + " " + t6 + " " + t7 + " ";

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8



            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }
    }

    //value not matching for case 2 GET 
    public class RandomizedSet
    {
        private List<int> list = new();


        public bool Insert(int val)
        {
            //bool isValExists = list.Any(t => t == val);
           // bool isValExists = list.Exists(t => t == val);
           bool isValExists = list.Contains(val);
            if (isValExists)
                return false;
            //else  
            list.Add(val);
           // list.Sort(); //Added for case-2 but did not worked
            return true;
        }

        public bool Remove(int val)
        {
            bool isValExists = list.Any(t => t == val);
            if (isValExists)
            {
                list.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            if (list.Count > 0)
            //   return list.First();   //results with this not mathing leetcode at submission
            {
                Random rnd = new();
                return list.ElementAt(rnd.Next(list.Count));
            }
            return 0;
        }
    }

    public class RandomizedSet_LeetCode_2_2k()
    {
        HashSet<int> set = new();
        Random rnd = new();

        public bool Insert(int n) => set.Add(n);

        public bool Remove(int n) => set.Remove(n);

        public int GetRandom() => set.ElementAt(rnd.Next(set.Count));
    }
}
