
namespace Serene_starter;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}