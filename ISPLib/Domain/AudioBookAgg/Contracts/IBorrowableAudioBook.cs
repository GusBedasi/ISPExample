using ISPLib.Domain.GeneralContracts;

namespace ISPLib.Domain.AudioBookAgg.Contracts
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}