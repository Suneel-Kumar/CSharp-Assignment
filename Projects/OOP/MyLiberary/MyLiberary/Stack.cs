using System;

namespace MyLiberary
{
    public class Stack
    {
        private int[] Array = new int[5];
        private int Top = -1;

        public void Push(int BahirWaleValue)
        {       
                //Top++;
                Array[++Top] = BahirWaleValue;   
        }

        public int Pop()
        {
            if (Top > -1)
            {
                int temp = Array[Top--];
                //Top--;
                return temp;
            }
            else
            {
                return 0;
            }
        }

        public int Peak()
        {
            return Array[Top];
        }
    }
}
