﻿using System.Collections.Generic;
using Rws.StudioAssemblyResolver.PathResolver;

namespace Rws.StudioAssemblyResolver
{
    public class AssemblyResolver
    {
        public static string StudioPath { get; internal set; }

        public static StudioAssemblyResolver WithPathResolver(IEnumerable<IPathResolver> resolvers)
        {
            var assemblyResolver = new StudioAssemblyResolver(resolvers);
            return assemblyResolver;
        }

        public static void Resolve()
        {
            var assemblyResolver = new StudioAssemblyResolver();
            assemblyResolver.Resolve();
        }
    }
}
