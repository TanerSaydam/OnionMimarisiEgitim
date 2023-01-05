using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Infrastructure.Utilities
{
    public static class FileManager<T> where T : class
    {
        public static string FileSaveToServer(IFormFile file, string path)
        {
            var fileFormat = file.FileName.Substring(file.FileName.LastIndexOf("."));
            fileFormat = fileFormat.ToLower();

            string fileName = Guid.NewGuid().ToString() + fileFormat;
            path = $"{path}{fileName}";


            using (var stream = System.IO.File.Create(path))
            {
                file.CopyTo(stream);
            }

            return fileName;
        }

        public static T ConvertXMLToObject(string path)
        {
            System.Xml.Serialization.XmlSerializer reader =
        new System.Xml.Serialization.XmlSerializer(typeof(T));
            System.IO.StreamReader xmlFile = new System.IO.StreamReader(
                path);
            T overview = (T)reader.Deserialize(xmlFile);
            xmlFile.Close();

            return overview;
        }

        public static void RemoveFileToServer(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
