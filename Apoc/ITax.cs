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
        IInputParameter InputPara { get; set; }

        void Init();
    }
}
