﻿using Botticelli.Client.Analytics;
using Botticelli.Framework.Commands.Processors;
using Botticelli.Framework.Commands.Validators;
using Botticelli.Shared.ValueObjects;
using SendMessageRequest = Botticelli.Shared.API.Client.Requests.SendMessageRequest;

namespace WeatherQuality.Telegram.Commands.Processors;

public class StopCommandProcessor : CommandProcessor<StopCommand>
{
    public StopCommandProcessor(ILogger<StopCommandProcessor> logger,
        ICommandValidator<StopCommand> validator,
        MetricsProcessor metricsProcessor)
        : base(logger, validator, metricsProcessor)
    {
    }

    protected override async Task InnerProcessContact(Message message, string argsString, CancellationToken token)
    {
    }

    protected override async Task InnerProcessPoll(Message message, string argsString, CancellationToken token)
    {
    }

    protected override async Task InnerProcessLocation(Message message, string argsString, CancellationToken token)
    {
    }


    protected override async Task InnerProcess(Message message, string args, CancellationToken token)
    {
        var farewellMessageRequest = new SendMessageRequest(Guid.NewGuid().ToString())
        {
            Message = new Message
            {
                Uid = Guid.NewGuid().ToString(),
                ChatIds = message.ChatIds,
                Body = "Bot stopped..."
            }
        };

        await _bot.SendMessageAsync(farewellMessageRequest, token);
    }
}