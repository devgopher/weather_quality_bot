﻿using Botticelli.Framework.Commands;

namespace WeatherQuality.Telegram.Commands;

public class CleanScheduleCommand : ICommand
{
    public Guid Id { get; }
}