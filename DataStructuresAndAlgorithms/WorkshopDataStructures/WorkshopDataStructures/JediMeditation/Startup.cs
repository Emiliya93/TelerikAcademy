namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Jedi : IComparable<Jedi>
    {
        static readonly Dictionary<char, int> priorities = new Dictionary<char, int>
        {
            {'m', 1},
            {'k', 2},
            {'p', 3},
        };
        private string name;
        private int index;

        public Jedi(string name, int index)
        {
            this.name = name;
            this.index = index;
        }

        public int CompareTo(Jedi other)
        {
            if (this.name == other.name)
            {
                return 0;
            }

            var thisName = this.name[0];
            var otherName = other.name[0];
            var thisPriority = priorities[thisName] + this.name;
            var otherPriority = priorities[otherName] + other.name;

            if (thisPriority == otherPriority)
            {
                return this.index.CompareTo(other.index);
            }

            return thisPriority.CompareTo(otherPriority);
        }

        public override string ToString()
        {
            return this.name;
        }

    }

    class PriorityQueue<T>
    {
        SortedSet<T> values;
        public PriorityQueue()
        {
            this.values = new SortedSet<T>();
        }

        public void Enqueue(T value)
        {
            this.values.Add(value);
        }

        public T Dequeue()
        {
            var value = this.values.First();
            this.values.Remove(value);

            return value;
        }
    }

    public class Startup
    {
        public static void Main()
        {
            // Set input to read from console :)
//            string input = @"7
//p4 p2 p3 m1 k2 p1 k1";
//            var reader = new StringReader(input);
//            Console.SetIn(reader);

            var count = int.Parse(Console.ReadLine());

            string[] jedi = Console.ReadLine().Split(' ');

            //WithQueue(jedi);
            //WithPriorityQueue(jedi);

            // WithDictionary(jedi);

            WithLists(jedi);
        }

        private static void WithLists(string[] jedi)
        {
            var masters = new List<string>();
            var knights = new List<string>();
            var padawans = new List<string>();

            foreach (var currentJedi in jedi)
            {
                if (currentJedi[0] == 'm')
                {
                    masters.Add(currentJedi);
                }

                if (currentJedi[0] == 'k')
                {
                    knights.Add(currentJedi);
                }

                if (currentJedi[0] == 'p')
                {
                    padawans.Add(currentJedi);
                }
            }

            Console.Write(string.Join(" ", masters));
            Console.Write(" ");
            Console.Write(string.Join(" ", knights));
            Console.Write(" ");
            Console.Write(string.Join(" ", padawans));
        }
 
        private static void WithDictionary(string[] jedi)
        {
            //WithQueue(jedi);
            //WithPriorityQueue(jedi);
            // With Dictionary
            Dictionary<char, Queue<string>> dict = new Dictionary<char, Queue<string>>();

            foreach (var j in jedi)
            {
                char key = j[0];
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new Queue<string>());
                }

                dict[key].Enqueue(j);
            }

            string order = "mkp";

            foreach (char charKey in order)
            {
                if (dict.ContainsKey(charKey))
                {
                    while (dict[charKey].Count > 0)
                    {
                        var currJedi = dict[charKey].Dequeue();
                        Console.Write("{0} ", currJedi);
                    }
                }
            }
        }

        private static void WithQueue(string[] jedi)
        {
            var masters = new Queue<string>();
            var knights = new Queue<string>();
            var padawans = new Queue<string>();

            // add jedis
            foreach (string j in jedi)
            {
                switch (j[0])
                {
                    case 'm': masters.Enqueue(j); break;
                    case 'k': knights.Enqueue(j); break;
                    case 'p': padawans.Enqueue(j); break;

                    default:
                        break;
                }
            }

            // empty masters
            // empty knights
            // empty padawans
            while (masters.Count > 0)
            {
                Console.Write(masters.Dequeue() + ' ');
            }

            while (knights.Count > 0)
            {
                Console.Write(knights.Dequeue() + ' ');
            }

            while (padawans.Count > 0)
            {
                Console.Write(padawans.Dequeue() + ' ');
            }
        }

        private static void WithPriorityQueue(string[] jedi)
        {
            PriorityQueue<Jedi> queue = new PriorityQueue<Jedi>();

            for (int i = 0; i < jedi.Length; i++)
            {
                queue.Enqueue(new Jedi(jedi[i], i));
            }
        }
    }
}
