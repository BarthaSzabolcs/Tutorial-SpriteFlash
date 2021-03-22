using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash
{
    public class Archer : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private Transform[] targets;

        [SerializeField] private GameObject arrow;
        [SerializeField] private Transform spawnPosition;

        #endregion
        #region Private Fields

        private int targetIndex;

        #endregion

        #endregion

        public void ShootArrow()
        {
            var instance = Instantiate(arrow, spawnPosition.position, Quaternion.identity);
            instance.transform.right = (targets[targetIndex].position - instance.transform.position).normalized;

            targetIndex++;
            if (targetIndex == targets.Length)
            {
                var animator = GetComponent<Animator>();
                animator.SetBool("Draw", false);
                //targetIndex = 0;
            }
        }
    }
}