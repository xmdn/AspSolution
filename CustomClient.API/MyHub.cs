using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace CustomClient;

public class MyHub : Hub
{
    private readonly ILogger<MyHub> _logger;
    private readonly string _id;
    public MyHub(ILogger<MyHub> logger)
    {
        _logger = logger;
        _id = Guid.NewGuid().ToString();
    }

    public string Get(string target) => $"Hello {target} {_id}";

    public async Task ReceiveStream(IAsyncEnumerable<string> messages, string param)
    {
        _logger.LogInformation($"starting to read stream: {param}");

        await foreach (var message in messages)
        {
            _logger.LogInformation($"Receiving {message} {param} {_id}");
        }

        _logger.LogInformation("finished stream");
    }
}