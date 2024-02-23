
   string rootfolder = @"C:\Users\eliza\Downloads\server-Resource-Pack - Copy";
   string[] files = Directory.GetFiles(rootfolder, "*.*", SearchOption.AllDirectories);
   foreach (string file in files)
   {    try
     {    string contents = File.ReadAllText(file);
       contents = contents.Replace(@"minecraft:grass", @"minecraft:short_grass");

       // Make files writable
       File.SetAttributes(file, FileAttributes.Normal);

       File.WriteAllText(file, contents);
     }
     catch (Exception ex)
     {    Console.WriteLine(ex.Message);
     }
   }