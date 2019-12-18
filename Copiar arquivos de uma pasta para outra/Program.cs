using System;

namespace Copiar_arquivos_de_uma_pasta_para_outra
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName, destFile;
            string sourcePath = @"C:\Users\elias\Documents\images";
            string targetPath =  @"C:\pastaCriada";

       
            System.IO.Directory.CreateDirectory(targetPath);
        
       
        if (System.IO.Directory.Exists(sourcePath))
        {
            string[] files = System.IO.Directory.GetFiles(sourcePath);
                       
            foreach (string s in files)
            {                
                fileName = System.IO.Path.GetFileName(s);
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(s, destFile, true);
            }
        }
        else
        {
            Console.WriteLine("Diretório não existe!");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        }
    }
}
