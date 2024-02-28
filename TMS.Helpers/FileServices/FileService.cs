using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace TMS.Helpers.FileServices
{
    public class FileService : IFileService
    {
        IWebHostEnvironment _environment;
        public FileService(IWebHostEnvironment environment)
        {
            _environment= environment;
        }
        public bool DeleteImage(string ImageFileName)
        {
            try
            {
                if (!string.IsNullOrEmpty(ImageFileName))
                {
                    string path = Path.Combine(_environment.WebRootPath, "Upload", ImageFileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist at path: " + path);
                    }
                }  
            }
            catch (Exception ex)
            {
                // Log the exception instead of just printing the message
                Console.WriteLine("An error occurred: " + ex.ToString());
            }
            return false;
        }



        public Tuple<int, string> SaveImage(IFormFile ImageFile)
        {
            try
            {
                //mack path 
                var publicpath = _environment.WebRootPath;
                var path = Path.Combine(publicpath, "Uplode");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                // Check the allow File  extenstions
                var extension = Path.GetExtension(ImageFile.FileName);
                var allowedExtensions= new string[] { ".jpg", ".png", ".jpeg" };
                if(!allowedExtensions.Contains(extension)) 
                {
                    string message = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    return new Tuple<int, string>(0, message);
                }
                // mack unick String 
                string uniqueString = Guid.NewGuid().ToString();
                var newFileName = uniqueString + extension;
                var fileWithPath = Path.Combine(path, newFileName);
                var stream = new FileStream(fileWithPath,FileMode.Create);
                ImageFile.CopyTo(stream);
                stream.Close();
                return new Tuple<int, string>(1, newFileName);
                
            }
            catch (Exception ex)
            {
                return new Tuple<int, string>(0, "Error has occured");
            }
            
        }
    }
}
