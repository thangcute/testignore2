using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Helpers
{
    public class FileHelper
    {
        public static async Task<List<string>> save(List<IFormFile> media, string directoryPath)
        {
            List<string> rtn = new List<string>();
            try
            {
                foreach (IFormFile file in media)
                {
                    if (file.Length > 0)
                    {
                        string extension = Path.GetExtension(file.FileName);
                        string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString(), extension);

                        string filePath = Path.Combine(directoryPath, fileName);
                        using (var stream = File.Create(filePath))
                        {
                            await file.CopyToAsync(stream);
                            rtn.Add("/Medias/Posts/" + fileName);
                        }
                        //using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        //{
                        //    await file.CopyToAsync(fileStream);
                        //    rtn.Add("/Medias/Posts/" + fileName);
                        //}
                    }
                }
            }
            catch(Exception ex)
            {
                rtn = new List<string>();
            }
            return rtn;
        }
    }
}
