using Common.SceneEx;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class SoundManager : MonoBehaviour, IInit
{

    /// <summary>
    /// SoundManager 생성 함수
    /// </summary>
    public void Init()
    {
        SceneLoader.Add(LoadPriorityType.Sound, OnLoadCompleted);
    }


    /// <summary>
    /// 씬 로드 시 호출해주는 함수
    /// </summary>
    public async UniTask OnLoadCompleted(Scene scene)
    {
        

        await UniTask.CompletedTask;
    }
}

