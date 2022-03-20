var path = @"C:\Users\Marina\Documents\DIO\Files\Workspace2\globo";
LerArquivos(path);
Console.WriteLine("Digite [enter] para finalizar ... ");
Console.ReadLine();

/*var path = Path.Combine(Environment.CurrentDirectory, "globo"); */
//LerDiretorios(path);


static void LerArquivos (string path)
{
    var arquivos = Directory.GetFiles(path, "*",SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]: {fileInfo.Name}");
        Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}");    
        Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");   
        Console.WriteLine("-------------------"); 
    }
}


//static void LerDiretorios(string path )
{
    if (Directory.Exists(path))
    {
            var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in diretorios)
             {

                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"[Nome]:{dirInfo.Name}");
                Console.WriteLine($"[Raiz]:{dirInfo.Root}");
                if(dirInfo.Parent != null)
                    Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");

        Console.WriteLine("--------------------");
    }
}
else{

    Console.WriteLine($"{path} não existe");
}
}
      