using System.Diagnostics;

namespace Smyers.Files
{
    public class ReadFiles
    {
        public string[] OpenListOfThings(string fileName)
        {
            string[] files = Array.Empty<string>();
            files = File.ReadAllLines(fileName);

            foreach (string file in files)
            {
                OpenFileWithDefault(file);
            }
            return files;
        }

        public void OpenFileWithDefault(string fileName)
        {
            Process fileopener = new Process();
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