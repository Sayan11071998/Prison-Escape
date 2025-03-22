using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    private void Awake()
    {
        ScenePersist[] scenePersists = FindObjectsByType<ScenePersist>(FindObjectsSortMode.None);
        int numScenePersists = scenePersists.Length;

        if (numScenePersists > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }

    public void ResetScenePersist() => Destroy(gameObject);
}