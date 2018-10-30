using Microsoft.VisualStudio.TestTools.UnitTesting;
using KeywordsExtractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsExtractor.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void PopulateSourceListViewTest()
        {
            Form1 f = new Form1();
            f.PopulateSourceListView();
            Assert.AreEqual(0, 0);
        }

        [TestMethod()]
        public void PopulateSourceListViewWithTagFilled()
        {
            Form1 f = new Form1();
            var kp = new KeywordsProject();
            kp.Sources.Items.Add(new Source() { Topic = "Topic1", Filename = "topic1.html" });
            f.Tag = kp;

            Assert.AreEqual(0, 0);
        }
    }
}