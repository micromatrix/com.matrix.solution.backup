using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IOC
{
    private static IOCContainer _container;

    static IOC()
    {
        _container = new IOCContainer();
    }

    public static T Resolve<T>(string name)
    {
        return _container.Resolve<T>(name);
    }

    public static T Resolve<T>()
    {
        return _container.Resolve<T>();
    }
    public static void Register<T>(string name, Func<T> func)
    {
        _container.Register(name, func);
    }

    public static void Unregister<T>(string name, Func<T> func)
    {
        _container.Unregister(name, func);
    }

    public static void Register<T>(string name, T instance)
    {
        _container.Register(name, instance);
    }

    public static void Unregister<T>(string name, T instance)
    {
        _container.Unregister(name, instance);
    }

    public static void Register<T>(Func<T> func)
    {
        _container.Register(func);
    }

    public static void Unregister<T>(Func<T> func)
    {
        _container.Unregister(func);
    }

    public static void Register<T>(T instance)
    {
        _container.Register(instance);
    }

    public static void Unregister<T>(T instance)
    {
        _container.Unregister(instance);
    }

    public static void Unregister<T>()
    {
        _container.Unregister<T>();
    }

    public static void RegisterFallback<T>(Func<T> func)
    {
        _container.RegisterFallback(func);
    }

    public static void UnregisterFallback<T>(Func<T> func)
    {
        _container.UnregisterFallback(func);
    }

    public static void RegisterFallback<T>(T instance)
    {
        _container.RegisterFallback(instance);
    }

    public static void UnregisterFallback<T>(T instance)
    {
        _container.UnregisterFallback(instance);
    }

    public static void UnregisterFallback<T>()
    {
        _container.UnregisterFallback<T>();
    }

    public static void ClearAll()
    {
        _container.Clear();
    }
}
