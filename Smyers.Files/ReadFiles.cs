using System.Diagnostics;

namespace Smyers.Files
{
    public class ReadFiles
    {
        public string[] OpenListOfThings(string fileName)
        {
            var files = File.ReadAllLines(fileName);

            foreach (string file in files)
            {
                OpenFileWithDefault(file);
            }
            return files;
        }

        public void OpenFileWithDefault(string fileName)
        {
            Process fileopener = new();
            try
            {
                fileopener.StartInfo.FileName = fileName;
                fileopener.Start();
                fileopener.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}