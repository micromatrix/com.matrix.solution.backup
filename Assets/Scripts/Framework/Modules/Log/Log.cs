using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Log
{
    public static ILog ILog { get; set; }

    public static int LogLevel { get; set; }

    private const int TraceLevel = 1;
    private const int DebugLevel = 2;
    private const int InfoLevel = 3;
    private const int WarningLevel = 4;
    private const int ErrorLevel = 5;

    public static void Trace(string message)
    {
        if (LogLevel <= TraceLevel)
        {
            return;
        }
        ILog.Trace(message);
    }

    public static void Debug(string message)
    {
        if (LogLevel <= DebugLevel)
        {
            return;
        }
        ILog.Debug(message);
    }

    public static void Info(string message)
    {
        if (LogLevel <= InfoLevel)
        {
            return;
        }
        ILog.Info(message);
    }

    public static void Warning(string message)
    {
        if (LogLevel <= WarningLevel)
        {
            return;
        }
        ILog.Warning(message);
    }

    public static void Error(string message)
    {
        if (LogLevel <= ErrorLevel)
        {
            return;
        }
        ILog.Error(message);
    }

    public static void Error(Exception e)
    {
        if (LogLevel <= ErrorLevel)
        {
            return;
        }
        ILog.Error(e.ToString());
    }

    public static void Trace(string message, params object[] args)
    {
        if (LogLevel <= TraceLevel)
        {
            return;
        }
        ILog.Trace(string.Format(message, args));
    }

    public static void Debug(string message, params object[] args)
    {
        if (LogLevel <= DebugLevel)
        {
            return;
        }
        ILog.Debug(string.Format(message, args));
    }

    public static void Info(string message, params object[] args)
    {
        if (LogLevel <= InfoLevel)
        {
            return;
        }
        ILog.Info(string.Format(message, args));
    }

    public static void Warning(string message, params object[] args)
    {
        if (LogLevel <= WarningLevel)
        {
            return;
        }
        ILog.Warning(string.Format(message, args));
    }

    public static void Error(string message, params object[] args)
    {
        if (LogLevel <= ErrorLevel)
        {
            return;
        }
        ILog.Error(string.Format(message, args));
    }
}
