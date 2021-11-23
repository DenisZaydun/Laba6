using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Wav : IMedia, IRecordable
    {
        private string filePath;
        private string fileName;

        public string FilePath => filePath;
        public string FileName => fileName;

        public Wav(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
