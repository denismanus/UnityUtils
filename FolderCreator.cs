using System.IO;
using UnityEditor;
using UnityEngine;

public class FolderCreator: MonoBehaviour
{
    private static readonly string[] folders = {
    "Animations",
    "Materials",
    "Prefabs",
    "Scripts",
    "Textures"
    };

    [MenuItem("Utils/Editor/Generate Default Folders")]
    public static void CreateDefaultFolders()
    {
        var path = Application.dataPath;
        foreach (var folder in folders)
        {
            var folderPath = @"{path}/{folder}";
            if (Directory.Exists(folderPath))
                continue;

            Directory.CreateDirectory(folderPath);
        }
    }
}
