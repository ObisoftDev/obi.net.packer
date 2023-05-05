using System.IO;

namespace net.obi.packer
{
   public delegate void OnProgress(string foldername,string filename,long current,long total);
}