using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Path
{
    public static class AdressablePath
    {
        public static string ScenePath(string name)
        {
            return $"Scene/{name}";
        }

        public static string UIPath(string name)
        {
            return $"UI/{name}";
        }

        public static string ObjectPoolSOPath(string name)
        {
            return $"Pool/{name}";
        }

        public static string ObjectPoolPath(string sceneName, string name)
        {
            return $"Pool/{sceneName}/{name}.prefab";
        }
    }
}

