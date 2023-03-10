﻿using System.IO;

namespace StudioAssemblyResolver.PathResolver.Implementation
{
    internal class DefaultPathSpecification : IPathSpecification
    {
        public bool IsSatisfiedBy(string path)
        {
            return Directory.Exists(Path.GetDirectoryName(path));
        }
    }
}
