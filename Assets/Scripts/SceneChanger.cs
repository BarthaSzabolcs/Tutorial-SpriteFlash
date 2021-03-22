using UnityEngine;
using UnityEngine.SceneManagement;

namespace BarthaSzabolcs.Tutorial_SpriteFlash
{
    public class SceneChanger : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private KeyCode previous;
        [SerializeField] private KeyCode next;
        [SerializeField] private KeyCode repeat;

        #endregion

        #endregion


        #region Unity Callbacks

        void Update()
        {
            if (Input.GetKeyDown(previous))
            {
                var currentIndex = SceneManager.GetActiveScene().buildIndex;

                if (0 < currentIndex)
                {
                    SceneManager.LoadScene(currentIndex - 1);
                }
            }
            else if (Input.GetKeyDown(next))
            {
                var currentIndex = SceneManager.GetActiveScene().buildIndex;

                if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
                {
                    SceneManager.LoadScene(currentIndex + 1);
                }
            }
            else if (Input.GetKeyDown(repeat))
            {
                var currentIndex = SceneManager.GetActiveScene().buildIndex;

                SceneManager.LoadScene(currentIndex);
            }
        }

        #endregion
    }
}