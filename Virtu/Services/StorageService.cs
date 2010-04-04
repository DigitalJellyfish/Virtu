﻿using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using Jellyfish.Virtu.Properties;

namespace Jellyfish.Virtu.Services
{
    public abstract class StorageService : MachineService
    {
        protected StorageService(Machine machine) : 
            base(machine)
        {
        }

        public static Stream GetResourceStream(string resourceName)
        {
            return GetResourceStream(resourceName, 0);
        }

        public static Stream GetResourceStream(string resourceName, int resourceSize)
        {
            var resourceManager = new ResourceManager("Jellyfish.Virtu.g", Assembly.GetExecutingAssembly()) { IgnoreCase = true };
            var resourceStream = (Stream)resourceManager.GetObject(resourceName);
            if (resourceStream == null)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SR.ResourceNotFound, resourceName));
            }
            if ((resourceSize > 0) && (resourceStream.Length != resourceSize))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SR.ResourceInvalid, resourceName));
            }

            return resourceStream;
        }

        public abstract void Load(string path, Action<Stream> reader);
        public abstract void Save(string path, Action<Stream> writer);
    }
}
