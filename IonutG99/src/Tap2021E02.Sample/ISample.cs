using System;
using System.Collections.Generic;
using System.Text;

namespace Tap2021E02.Sample
{
    public interface ISample
    {
        public Guid Id { get; }

        string DnaSequence { get; }

        DateTime AnalysisTime { get; }
    }
}
