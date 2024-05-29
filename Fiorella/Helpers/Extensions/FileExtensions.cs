using System;
using System.IO;

namespace Fiorella.Extensions
{
	public static class FileExtensions
	{
		public static bool CheckFileType(this IFormFile file,string pattern)
		{
			return file.ContentType.Contains(pattern);
		}

		public static bool CheckFileSize(this IFormFile file, int size)
		{
			return file.Length / 1024 < size;
		}

		public static async Task SaveFileToLocalAsync(this IFormFile file,string path)
		{
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }

		public static void DeleteFileFromLocal(this string path)
		{
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

		public static string GenerateFilePath(this IWebHostEnvironment _env,string folder,string fileName)
		{
			return Path.Combine(_env.WebRootPath, folder, fileName);
        }
	}
}

