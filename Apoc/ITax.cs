using Apoc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoc
{
    public interface ITax
    {
        IInternalParameter InternalPara { get; set; }
        IInputParameter InputPara { get; set; }
        IOutputParameter OutputPara { get; set; }
        IOutputDBA OutputDBASE { get; set; }

        void Init();
    }
}
