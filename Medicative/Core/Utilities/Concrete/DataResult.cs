using Core.Utilities.Abstract;
using Core.Utilities.Complex_types;

namespace Core.Utilities.Concrete
{
    public class DataResult<TEntityDTO> : IDataResult<TEntityDTO>
    {
        
        public DataResult(ResultStatus resultStatus, TEntityDTO data)
        {
            Data = data;
            ResultStatus = resultStatus;
        }

        public DataResult(ResultStatus resultStatus, TEntityDTO data, string info) : this(resultStatus, data)
        {
            Info = info;
        }

        public DataResult(ResultStatus resultStatus, TEntityDTO data, string info, Exception exception) : this(resultStatus, data, info)
        {
            Exception = exception;
        }

        public TEntityDTO Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
