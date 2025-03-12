using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class MemoryCalculator
    {
        private int memory;

        public void MemorySave(int value) => memory = value;
        public int MemoryRecall() => memory;
        public void MemoryClear() => memory = 0;
        public void MemoryPlus(int value) => memory += value;
    }
}
