using Microsoft.AspNetCore.SignalR;

namespace HtmxPlayground.Features.HtmxEvents;

public class EventsHub : Hub
{
    public Task BroadcastEvent(string name, string message) =>
        Clients.All.SendAsync("broadcastMessage", name, message);
}