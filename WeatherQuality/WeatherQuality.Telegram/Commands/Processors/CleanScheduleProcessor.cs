﻿using Botticelli.Client.Analytics;
using Botticelli.Framework.Commands.Processors;
using Botticelli.Framework.Commands.Validators;
using Botticelli.Shared.API.Client.Requests;
using Botticelli.Shared.ValueObjects;
using Hangfire;
using Hangfire.Storage;
using WeatherQuality.Telegram.Commands.ReplyOptions;

namespace WeatherQuality.Telegram.Commands.Processors;

public class CleanScheduleProcessor : CommandProcessor<CleanScheduleCommand>
 {
    public CleanScheduleProcessor(ILogger<CleanScheduleProcessor> logger, ICommandValidator<CleanScheduleCommand> validator, MetricsProcessor metricsProcessor) : base(logger, validator, metricsProcessor) 
    {}

    protected override Task InnerProcessContact(Message message, string args, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    protected override Task InnerProcessPoll(Message message, string args, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    protected override Task InnerProcessLocation(Message message, string args, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    protected override async Task InnerProcess(Message message, string args, CancellationToken token)
    {
      
        foreach (var chatId in message.ChatIds)
        {
            var jobs = JobStorage.Current.GetConnection().GetRecurringJobs().Where(j => j.Id.StartsWith($"SendAqiJob_{chatId}"));

            foreach (var job in jobs) 
                RecurringJob.RemoveIfExists(job.Id);
        }
        
        var scheduleCleanedMessageRequest = new SendMessageRequest(Guid.NewGuid().ToString())
        {
            Message = new Message
            {
                Uid = Guid.NewGuid().ToString(),
                ChatIds = message.ChatIds,
                Body = "Schedule cleaned..."
            }
        };

        await Bot.SendMessageAsync(scheduleCleanedMessageRequest, Replies.GeneralReplyOptions, token);
        
    }
}