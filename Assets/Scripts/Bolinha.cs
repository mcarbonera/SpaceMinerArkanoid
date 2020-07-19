using UnityEngine;

public class Bolinha : MonoBehaviour
{
    bool glued = true;

    // config
    [SerializeField] Plataforma plataforma;
    [SerializeField] AudioClip[] ballSounds;
    [SerializeField] float randomFactor = 0.2f;

    //private Rigidbody2D rb;

    // state
    Vector3 deltaXPlataforma;
    Vector2 paddleToBallVector;
    Vector3 offset = new UnityEngine.Vector3(
        0,
        0.42f,
        -2);

    //Vector3 lastVelocity;
    float velBase = 7f;

    // Cached component references
    AudioSource myAudioSource;
    Rigidbody2D myRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - plataforma.transform.position;
        deltaXPlataforma = new Vector3(0, 0, -2);

        myAudioSource = GetComponent<AudioSource>();
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //lastVelocity = rb.velocity;

        deltaXPlataforma = plataforma.transform.position - deltaXPlataforma;
        Vector3 plataformaPos = new Vector3(
            plataforma.transform.position.x,
            plataforma.transform.position.y, -2);

        if (glued) {
            lockBallToPaddle(plataformaPos);
            launchOnMouseClick();
        }
    }

    private void lockBallToPaddle(Vector3 plataformaPos)
    {
        transform.position = plataformaPos + offset;
    }

    private void launchOnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            glued = false;
            /*
            float diffX = deltaXPlataforma.x;

            Vector2 launchDirection = new Vector2(diffX, 1);
            launchDirection.Normalize();

            GetComponent<Rigidbody2D>().velocity = new Vector2(
                launchDirection.x * velBase, 
                launchDirection.y * velBase);
            */
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,velBase);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(
            Random.Range(0f, randomFactor),
            Random.Range(0f, randomFactor));
        if (!glued)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
            myRigidBody2D.velocity += velocityTweak;
        }
    }

    public void reinicializarBolinha()
    {
        glued = true;
        paddleToBallVector = transform.position - plataforma.transform.position;
        deltaXPlataforma = new Vector3(0, 0, -2);
    }
}
