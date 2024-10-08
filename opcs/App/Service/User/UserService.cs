using LanguageExt;
using opcs.App.Core;
using opcs.App.Data.Dto.General;
using opcs.App.Data.Dto.Request;
using opcs.App.Data.Dto.Response;
using opcs.App.Repository.Security.Interface;
using opcs.App.Repository.User.Interface;
using opcs.App.Service.Security.Interface;
using opcs.App.Service.User.Interface;

namespace opcs.App.Service.User;

public class UserService(IUserRepository userRepository, ISecurityService securityService, AppConfiguration appConfig): IUserService
{
}