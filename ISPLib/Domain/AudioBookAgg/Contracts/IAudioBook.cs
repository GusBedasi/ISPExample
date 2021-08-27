using ISPLib.Domain.GeneralContracts;

namespace ISPLib.Domain.AudioBookAgg.Contracts
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}