using UnityEngine;

namespace BarthaSzabolcs.Tutorial_SpriteFlash
{
    public class Arrow : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private float speed;

        #endregion

        #endregion


        #region Unity Callbacks

        private void Start()
        {
            var rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.velocity = transform.right * speed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }

        #endregion
    }
}
