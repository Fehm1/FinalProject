using Core.Utilities.Complex_types;

namespace Core.Utilities.Abstract
{
    public interface IResult 
    {
        public ResultStatus ResultStatus { get; }
        public string Info { get; }
        public Exception Exception { get; }
    }
}
