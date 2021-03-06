﻿using System;
using System.Collections.Generic;

using System.Text;
using System.IO;

namespace Examine.LuceneEngine
{
    public static class FileSystemExtensions
    {

        /// <summary>
        /// Deletes all files in the folder and returns the number deleted.
        /// </summary>
        /// <param name="di"></param>
        /// <returns></returns>
        public static int ClearFiles(this DirectoryInfo di)
        {
            int count = 0;
            di.Refresh();
            if (di.Exists)
            {
                foreach (var x in di.GetFiles())
                {
                    x.Delete();
                    count++;
                }                
            }
            return count;
        }

    }
}
