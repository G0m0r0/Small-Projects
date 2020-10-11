using System;
using System.Collections;
using System.IO;
using System.Net;

namespace VideoTobytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Programming\Video\Softuni\C# Advance\Advanced.mp4";
            FileStream fs = null;
            BinaryReader br = null;

            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            while (true)
            {
                int chunkSize = 1024; // assumed as 1kb you can extend as per your requirement

                //Here is your byte array
                byte[] buffer = br.ReadBytes(chunkSize);//reading the bytes

                if (buffer.Length == 0)
                {
                    break;
                }
                BitArray bitsBuffer = new BitArray(buffer);                

                DisplayBitArray(bitsBuffer);
            }          
            
        }

        static void DisplayBitArray(BitArray bitArray)
        {
            for (int i = 0; i < bitArray.Count; i++)
            {
                bool bit = bitArray.Get(i);
                Console.Write(bit ? 1 : 0);
            }
        }
    }
}
