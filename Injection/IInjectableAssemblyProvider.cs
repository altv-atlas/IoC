﻿using System.Reflection;

namespace AltV.Atlas.IoC.Injection;

/// <summary>
///     Interface for defining a class that retrieves assemblies.
/// </summary>
public interface IInjectableAssemblyProvider
{
    /// <summary>
    ///     Gets the assemblies.
    /// </summary>
    /// <returns>An array of Assemblies.</returns>
    Assembly[] GetAssemblies();
}