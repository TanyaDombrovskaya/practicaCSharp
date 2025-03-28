using GRMNS;

class Task1
{
    static void Main()
    {
        GameResourceManager resourceManager = GameResourceManager.Instance;

        resourceManager.LoadResource("Texture");
        resourceManager.LoadResource("Sound");
        resourceManager.LoadResource("Model");

        resourceManager.LoadResource("Texture");

        object texture = resourceManager.GetResource("Texture");
        object sound = resourceManager.GetResource("Sound");

        Console.WriteLine($"Получен ресурс: {texture}");
        Console.WriteLine($"Получен ресурс: {sound}");

        object unknownResource = resourceManager.GetResource("Unknown");
        Console.WriteLine(unknownResource == null
            ? "Ресурс 'Unknown' не найден."
            : $"Получен ресурс: {unknownResource}");
    }
}


