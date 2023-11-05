using Apoc.Model;

namespace Apoc
{
    /// <summary>
    /// Null Object
    /// </summary>
    public sealed class NullTax : ITax
    {
        private static readonly ITax nullTax = new NullTax();
        public static ITax Instance { get { return nullTax; } }

        public IInputParameter InputPara { get; set; }

        public NullTax() {}

        public void Init() {}
    }
}
