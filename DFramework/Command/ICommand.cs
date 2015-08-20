﻿using System;

namespace DFramework
{
    /// <summary>
    /// 带返回值的命令
    /// </summary>
    public class Command<T> : Command
    {
        public T ReturnValue { get; set; }
    }
    /// <summary>
    /// 命令
    /// </summary>
    public class Command : ICommand
    {
        public Command()
        {
            this.Id = Guid.NewGuid();
            this.Status = CommandStatus.Pending;
            this.Message = string.Empty;
        }
        public Guid Id { get; set; }
        public CommandStatus Status { get; set; }
        public string Message { get; set; }
    }
    /// <summary>
    /// 命令接口
    /// </summary>
    public interface ICommand
    {
        Guid Id { get; set; }
        CommandStatus Status { get; set; }
        string Message { get; set; }
    }

    public enum CommandStatus
    {
        Pending = 0,
        Fail = 1,
        Success = 2,
        Timeout = 3
    }
}
