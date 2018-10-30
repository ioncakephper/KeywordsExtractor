using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeywordsExtractor
{
    public class KeywordHub
    {
        public List<Keyword> Items { get; set; }

        public KeywordHub()
        {
            Items = new List<Keyword>();
        }
    }
}