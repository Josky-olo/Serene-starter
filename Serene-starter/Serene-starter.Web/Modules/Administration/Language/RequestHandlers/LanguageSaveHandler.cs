using MyRequest = Serenity.Services.SaveRequest<Serene_starter.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_starter.Administration.LanguageRow;


namespace Serene_starter.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}