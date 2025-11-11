using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Fishing_Boat"))
    //    {
    //        SceneManager.LoadScene("S2 - Underwater");
    //    }
    //}
    public float delay = 100f;
    public string NewLevel = "S2 - Underwater";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}