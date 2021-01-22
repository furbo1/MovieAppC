using System;
using System.Collections.Generic;
using System.Text;

namespace ExOne 
{
    class Group 
    {
        private List<GroupAges> group;

        public Group() 
        {
            group = new List<GroupAges>();
        }

        public GroupAges[] GetAges()
        {
            return group.ToArray();
        }

        internal void AddAge(int age)
        {
            group.Add(new GroupAges(age));
        }
    }
}