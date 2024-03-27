using Microsoft.AspNetCore.SignalR;
using SignalRQRReservation.DataAccessLayer.Concrete;

namespace SignalRQRReservationApi.Hubs
{
    public class SignalRHub : Hub
    {
        SignalRQRReservationContext context = new SignalRQRReservationContext();

        public async Task SendCategoryCount ()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
