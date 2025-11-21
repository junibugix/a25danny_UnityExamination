using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        print("test");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
