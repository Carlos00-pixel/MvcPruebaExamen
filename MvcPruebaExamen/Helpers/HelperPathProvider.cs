namespace MvcPruebaExamen.Helpers
{
    public enum Folders { Images = 0 }

    public class HelperPathProvider
    {
        private IWebHostEnvironment hostEnvironment;

        public HelperPathProvider(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";
            if (folder == Folders.Images)
            {
                carpeta = "images";
            }

            string rootPath = hostEnvironment.WebRootPath;
            string path = Path.Combine(rootPath, carpeta, fileName);
            return path;
        }
    }
}
