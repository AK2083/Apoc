using Apoc.Model;
using Dozer;

namespace Apoc
{
    [WorkflowValidity("01.01.2011")]
    public class Tax11 : ITax
    {
        public IInputParameter InputPara { get; set; }

        private readonly IInternalParameter _internalPara;
        private readonly IOutputParameter _outputPara;
        private readonly IOutputDBA _outputDBASE;

        public Tax11(IInputParameter inputPara) => InputPara = inputPara;

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
