using ListenTogether.Application.Interfaces;
using ListenTogether.Domain;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenTogether.Application.Grains;

public sealed class RoomGrain : Grain, IRoomGrain
{
    private readonly IPersistentState<Room> _room;
    private readonly ILogger<RoomGrain> _logger;

    public RoomGrain([PersistentState("room", "roomStorage")] IPersistentState<Room> room,
        ILogger<RoomGrain> logger)
    {
        _room = room;
        _logger = logger;
    }

    public async Task<Room> JoinRoom(string connectionId, string userName)
    {
        _logger.LogInformation($"User {userName} is joining {_room.State.Code}, listening to");
        await _room.WriteStateAsync();
        return _room.State;
    }
}
