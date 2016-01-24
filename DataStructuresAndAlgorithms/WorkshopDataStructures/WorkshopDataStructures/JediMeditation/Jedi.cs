//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace JediMeditation
//{
//    public class Jedi : IComparable<Jedi>
//    {
//        static readonly Dictionary<char, int> priorities = new Dictionary<char,int>
//        {
//            {'m', 1},
//            {'k', 2},
//            {'p', 3},
//        };
//        private string name;
//        private int index;

//        public Jedi(string name, int index)
//        {
//            this.name = name;
//            this.index = index;
//        }

//        public int CompareTo(Jedi other)
//        {
//            if (this.name == other.name)
//            {
//                return 0;
//            }

//            var thisName = this.name[0];
//            var otherName = other.name[0];
//            var thisPriority = priorities[thisName] + this.name;
//            var otherPriority = priorities[otherName] + other.name;

//            if (thisPriority == otherPriority)
//            {
//                return this.index.CompareTo(other.index);
//            }

//            return thisPriority.CompareTo(otherPriority);
//        }

//        public override string ToString()
//        {
//            return this.name;
//        }

//    }
//}
