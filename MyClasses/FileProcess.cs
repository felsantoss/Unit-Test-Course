using System;
using System.IO;

namespace MyClasses
{
    public class FileProcess
    {
        public bool FileExists(string filename)
        {
            if (string.IsNullOrEmpty(filename)) // valida se o arquivo é nulo ou vazio
            {
                throw new ArgumentNullException("filename");
            }

            return File.Exists(filename);
        }
    }
}
