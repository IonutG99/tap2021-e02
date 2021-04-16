using System;
using System.Collections.Generic;
using System.Text;
using Tap2021E02.Extensions;

namespace Tap2021E02.SampleEntities
{
    public class Sample:ISample
    {
       public Sample( Guid id, string dnaseq,DateTime data)
        {
            Id = id;
            DnaSequence = dnaseq;
            AnalysisTime = data;
        }

        public Guid Id { get; private set; }

        public string DnaSequence { get; protected set; }

        public DateTime AnalysisTime { get; private set; }
    }
}
