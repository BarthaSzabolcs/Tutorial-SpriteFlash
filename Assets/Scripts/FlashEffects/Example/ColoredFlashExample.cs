using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash.Example
{
    public class ColoredFlashExample : MonoBehaviour
    {
        [SerializeField] private ColoredFlash flashEffect;
        [SerializeField] private Color[] colors;
        [SerializeField] private KeyCode flashKey;

        private void Update()
        {
            if (Input.GetKeyDown(flashKey))
            {
                Color randomColor = colors[Random.Range(0, colors.Length)];
                flashEffect.Flash(randomColor);
            }
        }
    }
}