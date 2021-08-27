using ISPLib.Domain.GeneralContracts;

namespace ISPLib.Domain.BookAgg.Contracts
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}