using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Mp3 : IMedia, IRecordable
    {
        public Mp3(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }
        public string filePath;
        public string fileName;

        public string FilePath => filePath;
        public string FileName => fileName;


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
