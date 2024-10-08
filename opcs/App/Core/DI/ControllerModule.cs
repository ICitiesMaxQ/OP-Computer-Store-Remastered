using Autofac;
using opcs.App.Controller.Security;
using opcs.App.Controller.Supply;
using opcs.App.Controller.User;

namespace opcs.App.Core.DI;

public class ControllerModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<SupplierController>().PropertiesAutowired();
        builder.RegisterType<RoleController>().PropertiesAutowired();
        builder.RegisterType<UserController>().PropertiesAutowired();
        builder.RegisterType<AuthenticationController>().PropertiesAutowired();
    }
}