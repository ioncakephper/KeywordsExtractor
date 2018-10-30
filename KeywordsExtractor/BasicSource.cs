namespace KeywordsExtractor
{
    public class BasicSource
    {
        public virtual string GetTitle(string fullFilename)
        {
            return System.IO.Path.GetFileNameWithoutExtension(fullFilename).ToUpper();
        }
    }
}