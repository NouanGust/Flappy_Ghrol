using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwapper : MonoBehaviour {
    public void ChangeScene(string sceneName) {
        SceneManager.LoadSceneAsync(sceneName);
    }

}
