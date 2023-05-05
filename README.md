# obi.net.packer
Libreria C# para empaquetar archivos, carpetas , sin compresion 

# importar dll en tu proyecto

# Codigo de ejemplo
```
using net.obi.packer;
namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string folder = @"folder to pack path";
            string packfile = "pack.obi";
            PacketFolder.Pack(folder,"pack.obi");
            using (PackFolder folder = PackFolder.From(packfile))
            {
              //TODO code
              // Ejemplo de extraccion
              PackFolder.ExtractFolder(folder,@"path to extract");
              // folder.Files es una lista de los archivos de ese folder
              // folder.Folders es una lista de folders q contiene cada uno sus respectivos archivos 
            }
        }
    }
}
```
