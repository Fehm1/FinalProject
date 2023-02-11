using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;

namespace Core.Utilities.Concrete
{
    public class DataResult<TEntityDTO> : IDataResult<TEntityDTO>
    {
        
        public DataResult(TEntityDTO data, ResultStatus resultStatus)
        {
            Data = data;
            ResultStatus = resultStatus;
        }

        public DataResult(TEntityDTO data, ResultStatus resultStatus, string info) : this(data, resultStatus)
        {
            Info = info;
        }

        public DataResult(TEntityDTO data, ResultStatus resultStatus, string info, Exception exception) : this(data, resultStatus, info)
        {
            Exception = exception;
        }

        public TEntityDTO Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
