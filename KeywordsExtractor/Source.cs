using System;
using System.Runtime.Serialization;

namespace KeywordsExtractor
{
    public class Source : BasicSource
    {
        public Source()
        {
            Filename = string.Empty;
            Topic = string.Empty;
            Folder = string.Empty;
            FullFileName = string.Empty;
        }

        public Source(string fileName) : this()
        {
            FullFileName = fileName;
            Filename = System.IO.Path.GetFileName(fileName);
            Folder = System.IO.Path.GetDirectoryName(fileName);
            Topic = GetTitle(FullFileName);
        }

        public string Topic { get;  set; }
        public string FullFileName { get; private set; }
        public string Filename { get; set; }
        public string Folder { get; set; }
    }
}