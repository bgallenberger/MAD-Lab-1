using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MAD_Lab_1
{
    class FileOutput
    {
        private StreamWriter output = null;
        private String fileName;

        public FileOutput(String fileName)
        {
            this.fileName = fileName;
            try
            {
                output = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(String line)
        {
            try
            {
                output.Write(line + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void FileClose()
        {
            if (output != null) {
                try
                {
                    output.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
