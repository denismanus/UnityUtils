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
#if UNITY_EDITOR
        var path = Application.dataPath;
        foreach (var folder in folders)
        {
            var folderPath = $"{path}/{folder}";
            if (Directory.Exists(folderPath))
            {
                Debug.Log(folderPath);
                continue;
            }
            Debug.Log("Create" + folderPath);

            Directory.CreateDirectory(folderPath);
        }
        AssetDatabase.Refresh();
#endif
    }
}
