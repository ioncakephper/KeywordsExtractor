using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeywordsExtractor
{
    public class KeywordsProject
    {
        public SourceHub Sources
        {
            get; set;
        }

        public KeywordHub Keywords
        {
            get; set;
        }

        public KeywordsExtractor Extractor
        {
            get; set;
        }
        public bool HasChanged { get;  set; }

        public KeywordsProject()
        {
            Sources = new SourceHub();
            Keywords = new KeywordHub();
            Extractor = new KeywordsExtractor();
            HasChanged = false;
        }

        public void AddSources(string[] fileNames)
        {
            foreach (var fileName in fileNames)
            {
                Sources.Items.Add(new Source(fileName));
            }
        }
    }
}