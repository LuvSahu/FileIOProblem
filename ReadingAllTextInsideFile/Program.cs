namespace FilelO
{
    class Program
    {
        public static void FileExit()
        {
            string InputFile = @"C:\Users\Luv\Documents\batch5_7\kumar.txt";
            if(File.Exists(InputFile))
            {
                Console.WriteLine("File Exits");
            }
            else
            {
                Console.WriteLine("File does not Exits");
            }
        }

        public static void ReadFile()
        {
            string InputFile = @"C:\Users\Luv\Documents\batch5_7\kumar.txt";
            using (StreamReader read = File.OpenText(InputFile))
            {
                string s = " ";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }
        }

        public static void FileCopy()
        {
            string Path = @"C:\Users\Luv\Documents\batch5_7\luv.txt";
            string CopyPath = @"F:\Joy\Test.txt";
            File.Copy(Path, CopyPath);
            Console.ReadKey();
        }

        public static void DeleteFile()
        {
            string CopyPath = @"C:\Users\Luv\Documents\batch5_7\Atotech.txt";
            File.Delete(CopyPath);
            Console.ReadKey();
        }

        public static void ReadAllText()
        {
            String path = @"C:\Users\Luv\Documents\batch5_7\kumar.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        //public static void ReadStreamReader()
        //{
        //    String path = @"C:\Users\Luv\Documents\batch5_7\kumar.txt";
        //    using (StreamReader read = File.OpenText(path))
        //    {
        //        String s = "";
        //        while ((s = read.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s);
        //        }
        //    }
        //    Console.ReadKey();//it will wait for a key press
        //}
        //public static void WriteUsingStreamWriter()
        //{
        //    string path = @"C:\Users\Luv\Documents\batch5_7\luv.txt";
        //    using (StreamWriter sr = File.AppendText(path))
        //    {
        //        sr.WriteLine("Hello world.net class");
        //        sr.Close();
        //        Console.WriteLine(File.ReadAllText(path));
        //    }
        //    Console.ReadKey();
        //}

        static void Main(String[] args)
        {
           // Program pg = new Program();
            FileExit();
            ReadFile();
            FileCopy();
            DeleteFile();
            ReadAllText();
            //WriteUsingStreamWriter();
            //ReadStreamReader();
        }
    }
}