using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash
{
    public class SimpleDummy : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private GameObject[] arrows;
        [SerializeField] private SimpleFlash flashEffect;

        #endregion
        #region Private Fields

        private int hitCount;

        #endregion

        #endregion


        #region Unity Callbacks

        private void Start()
        {
            foreach (var arrow in arrows)
            {
                arrow.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (hitCount < arrows.Length)
            {
                flashEffect.Flash();
                
                arrows[hitCount].SetActive(true);
                hitCount++;
            }
        }

        #endregion
    }
}