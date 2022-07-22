﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace kiosk_solution.Hubs
{
    public class SystemEventHub : Hub
    {
        public static string KIOSK_CONNECTION_CHANNEL = "KIOSK_CONNECTION_CHANNEL";
        public static string SYSTEM_BOT = "SYSTEM_BOT";

        public async Task JoinRoom(KioskConnection kioskConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, kioskConnection.RoomId);
            await Clients
                .Group(kioskConnection.RoomId)
                .SendAsync(KIOSK_CONNECTION_CHANNEL, SYSTEM_BOT,
                    $"{kioskConnection.KioskId} has joined {kioskConnection.RoomId}");
        }
    }
}