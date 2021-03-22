using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash
{ 
    public class ColoredDummy : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private ColoredFlash flashEffect;

        [SerializeField] private GameObject[] arrows;
        [SerializeField] private Color[] flashColors;

        [SerializeField] private KeyCode healKey;
        [SerializeField] private Color healColor;

        #endregion
        #region Private Fields

        private int hitCount;

        #endregion

        #endregion


        #region Unity Callbacks

        private void Start()
        {
            HideArrows();
        }

        private void Update()
        {
            if (Input.GetKeyDown(healKey))
            {
                flashEffect.Flash(healColor);
                HideArrows();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (hitCount < arrows.Length)
            {
                arrows[hitCount].SetActive(true);
                flashEffect.Flash(flashColors[hitCount]);

                hitCount++;
            }
        }

        private void HideArrows()
        {
            hitCount = 0;

            foreach (var arrow in arrows)
            {
                arrow.SetActive(false);
            }
        }

        #endregion
    }
}