using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Scrollbar progress;
    private void Start()
    {
        progress = GetComponent<Scrollbar>();
        StartCoroutine(GoProgress());
    }
    IEnumerator GoProgress()
    {
        while (progress.size < 100)
        {
            yield return new WaitForSeconds(1f);
            progress.size += 0.25f;
            if (progress.size == 1)
            {
                SceneManager.LoadScene("GameScene");
                break;
            }
        }
    }
}
