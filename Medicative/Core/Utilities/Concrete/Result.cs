using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;

namespace Core.Utilities.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string info) : this(resultStatus)
        {
            Info = info;
        }

        public Result(ResultStatus resultStatus, string info, Exception exception) : this(resultStatus, info)
        {
            Exception = exception;
        }

        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
