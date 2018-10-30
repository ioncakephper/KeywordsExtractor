using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordsExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Corpus = new KeywordsProject();
        }

        public KeywordsProject Corpus
        {
            get; set;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = changeDetector1.CancelFormClosing(sender);
        }

        private void ChangeDetector1_Change(object sender, ChangeDetectorControlLibrary.ChangeOccurredEventArgs e)
        {
            e.ChangedOccurred = Corpus.HasChanged;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var d = new AboutBox1())
            {
                d.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateSourceListView();
        }

        private ListViewItem[] GetSourceListViewItems(SourceHub sources)
        {
            var items = new List<ListViewItem>();
            if (sources != null)
            {
                sources.Items.ForEach(s =>
                {
                    items.Add(GetSingleSourceListViewItem(s));
                });
            }
            return items.ToArray();
        }

        private ListViewItem GetSingleSourceListViewItem(Source s)
        {
            var item = new ListViewItem(s.Topic);
            item.SubItems.AddRange(new string[] { s.Filename, s.Folder });

            item.Tag = s;
            return item;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSources();
        }

        private void AddSources()
        {
            string[] fileNames = GetSourceFilename();
            if (fileNames.Length > 0)
            {
                Corpus.AddSources(fileNames);
                PopulateSourceListView(Corpus);
            }
            Corpus.HasChanged = fileNames.Length > 0;
        }

        private void PopulateSourceListView(KeywordsProject corpus)
        {
            if (corpus != null)
            {
                var items = GetSourceListViewItems(corpus.Sources);
                listView1.Items.Clear();
                if (items != null)
                {
                    listView1.Items.AddRange(items);
                }
            }
        }

        public void PopulateSourceListView()
        {
            PopulateSourceListView((KeywordsProject)Tag);
        }

        private string[] GetSourceFilename()
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                return openFileDialog1.FileNames;
            }
            return new string[] { };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddSources();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedSources();
        }

        private void RemoveSelectedSources()
        {
            foreach (int index in listView1.SelectedIndices)
            {
                Source item = (Source)listView1.Items[index].Tag;
                Corpus.Sources.Items.Remove(item);
                Corpus.HasChanged = true;
            }

            PopulateSourceListView(Corpus);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RemoveSelectedSources();
        }
    }
}
