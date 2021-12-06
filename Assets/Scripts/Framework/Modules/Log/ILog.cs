using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILog
{
    void Trace(string message);

    void Warning(string message);

    void Info(string message);

    void Debug(string message);

    void Error(string message);

    void Error(Exception e);

    void Trace(string message, params object[] args);

    void Warning(string message, params object[] args);

    void Info(string message, params object[] args);

    void Debug(string message, params object[] args);

    void Error(string message, params object[] args);
}
