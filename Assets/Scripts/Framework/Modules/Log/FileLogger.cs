using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileLogger : ILog
{
    private readonly StreamWriter stream;

    public FileLogger(string path)
    {
        var fileStream = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        this.stream = new StreamWriter(fileStream);
        this.stream.AutoFlush = true;
    }

    public void Trace(string message)
    {
        this.stream.WriteLine(message);
        this.stream.Flush();
    }

    public void Warning(string message)
    {
        this.stream.WriteLine(message);
        this.stream.Flush();
    }

    public void Info(string message)
    {
        this.stream.WriteLine(message);
        this.stream.Flush();
    }

    public void Debug(string message)
    {
        this.stream.WriteLine(message);
        this.stream.Flush();
    }

    public void Error(string message)
    {
        this.stream.WriteLine(message);
        this.stream.Flush();
    }

    public void Error(Exception e)
    {
        this.stream.WriteLine(e.ToString());
        this.stream.Flush();
    }

    public void Trace(string message, params object[] args)
    {
        this.stream.WriteLine(message, args);
        this.stream.Flush();
    }

    public void Warning(string message, params object[] args)
    {
        this.stream.WriteLine(message, args);
        this.stream.Flush();
    }

    public void Info(string message, params object[] args)
    {
        this.stream.WriteLine(message, args);
        this.stream.Flush();
    }

    public void Debug(string message, params object[] args)
    {
        this.stream.WriteLine(message, args);
        this.stream.Flush();
    }

    public void Error(string message, params object[] args)
    {
        this.stream.WriteLine(message, args);
        this.stream.Flush();
    }

}
