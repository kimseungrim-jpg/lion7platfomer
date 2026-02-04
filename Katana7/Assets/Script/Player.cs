using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    public float jumpUp = 1f;
    public Vector3 direction;

    Animator animator;
    Rigidbody2D rd;
    SpriteRenderer sp;

    void Start()
    {
        animator = GetComponent<Animator>(); //애니메이터 컴포넌트 가져오기
        rd = GetComponent<Rigidbody2D>(); //리지드바디2D
        sp = GetComponent<SpriteRenderer>();
        direction = Vector2.zero;
    }

    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal");

        if (direction.x < 0)
        {
            sp.flipX = true;            
        }
        else if(direction.x > 0)
        {
            sp.flipX= false;
        }
        else if (direction.x == 0)
        {

        }

        transform.Translate(direction.x * speed * Time.deltaTime, direction.y, 0);
    }

    void Update()
    {
        KeyInput();
    }
}
