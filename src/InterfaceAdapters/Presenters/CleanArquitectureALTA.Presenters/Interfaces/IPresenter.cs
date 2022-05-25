namespace Alta.Presenters.Interfaces
{
    public interface IPresenter<out FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
