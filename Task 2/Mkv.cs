using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Mkv : IMedia, IPlayable
    {
        public string filePath;
        public string fileName;
        
        public string FilePath => filePath;
        public string FileName => fileName;

        public Mkv(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
