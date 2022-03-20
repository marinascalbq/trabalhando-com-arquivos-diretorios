CriarDiretóriosGlobo();
CriarArquivos();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul","Argentina", "argentina.txt");


CopiarArquivos(origem,destino);



static void CopiarArquivos(string pathOrigem, string pathDestino)
{
    File.Copy(pathOrigem, pathDestino);
}

//MoverArquivos(origem, destino);
static void MoverArquivos(string pathOrigem, string pathDestino){

    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe!");
        return;
    }

    if (File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino!"); 
        return;
    }


    File.Move(pathOrigem, pathDestino);
}


static void CriarArquivos()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2018");
    }
    
}


static void CriarDiretóriosGlobo()
{
//Criando pasta de todo o globo
var path = Path.Combine(Environment.CurrentDirectory, "globo");

if (! Directory.Exists(path))
{
var dirGlobo = Directory.CreateDirectory(path);
//criando os continentes
var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

dirAmNorte.CreateSubdirectory("USA");
dirAmNorte.CreateSubdirectory("México");
dirAmNorte.CreateSubdirectory("Canadá");

dirAmCentral.CreateSubdirectory("Costa Rica");
dirAmCentral.CreateSubdirectory("Panamá");

dirAmSul.CreateSubdirectory("Brasil");
dirAmSul.CreateSubdirectory("Argentina");
dirAmSul.CreateSubdirectory("Paraguai");
}
}