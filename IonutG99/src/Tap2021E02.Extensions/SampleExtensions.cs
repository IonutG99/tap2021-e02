using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tap2021E02.Extensions
{
    public static class SampleExtensions
    {
        public static bool IsValidDnaSequence(string dna)
        {
            if (dna.Length != 1000)
            {
                return false;
            }
            else
            {
                int freqA = dna.Count(f => (f == 'A'));
                int freqC=dna.Count(f => (f == 'C'));
                int freqG = dna.Count(f => (f == 'G'));
                int freqT = dna.Count(f => (f == 'T'));
                if ((freqA + freqC + freqG + freqT) != dna.Length)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
