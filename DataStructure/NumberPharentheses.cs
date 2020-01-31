using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class NumberPharentheses
    {
        public void Pharentheses()
        {
            StackLists<Object> stacklist = new StackLists<Object>();
            string str = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            char[] characterarray = str.ToCharArray();
            for (int i = 0; i < characterarray.Length; i++)
            {
                if (characterarray[i] == '(' || characterarray[i] == ')')
                {
                    stacklist.pushCharacter(characterarray[i]);
                }
            }
            stacklist.popCharacter();
            bool result = stacklist.BalancedPharentheses();
            if (result == true)
            {
                Console.WriteLine("push and pop is balanced pharenthese");
            }
            else
            {
                Console.WriteLine("push and pop is not balanced pharenthese");
            }
           Console.WriteLine(stacklist.PeekStack());
           Console.WriteLine(stacklist.IsEmpty());
            Console.WriteLine("the size of stacklist"+": " + stacklist.Size());
        }

    }
}

