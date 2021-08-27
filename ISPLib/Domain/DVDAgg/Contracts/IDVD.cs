using System.Collections.Generic;
using ISPLib.Domain.GeneralContracts;

namespace ISPLib.Domain.DVDAgg.Contracts
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}