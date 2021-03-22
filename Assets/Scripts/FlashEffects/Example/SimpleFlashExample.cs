using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash.Example
{
    public class SimpleFlashExample : MonoBehaviour
    {
        [SerializeField] private SimpleFlash flashEffect;
        [SerializeField] private KeyCode flashKey;

        private void Update()
        {
            if (Input.GetKeyDown(flashKey))
            {
                flashEffect.Flash();
            }
        }
    }
}