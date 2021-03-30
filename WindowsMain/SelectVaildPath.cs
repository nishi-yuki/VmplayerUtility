using File = System.IO.File;

namespace WindowsMain
{
    class SelectVaildPath
    {
        public readonly string Path;
        public readonly bool Found = false;
        public SelectVaildPath(string[] paths)
        {
            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    this.Path = path;
                    this.Found = true;
                    return;
                }
            }
        }
    }
}
