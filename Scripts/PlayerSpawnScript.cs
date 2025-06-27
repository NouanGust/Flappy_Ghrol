using UnityEngine;

public class PlayerSpawnScript : MonoBehaviour {
    private void Start() {
        Instantiate(GameManager.instance.currentCharacter.prefab, transform.position, Quaternion.identity);
    }
}
