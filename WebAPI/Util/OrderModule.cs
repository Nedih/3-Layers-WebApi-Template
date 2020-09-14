using Ninject.Modules;
using WebAPI.BLL.Interfaces;
using WebAPI.BLL.Services;

namespace WebAPI.Util
{
    public class OrderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
        }
    }
}