namespace Core.Utilities.Abstract
{
    public interface IDataResult<out TEntityDTO> : IResult
    {
        public TEntityDTO Data { get; }
    }
}
