using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]//отображает данные в инспекторе
    public Rigidbody rb;//ссылка на компонент
    public float _fowardForcer = 700f;
    public float _sidewaysForce = 80f;
    public float _JumpForce=100f;
    public Transform player;
    private float _timeMark;
    [SerializeField]
    private float _cooldown = 0.5f;

    private void Start()
    {
        _timeMark = Time.time;
    }
    //public Vector3 offset;

    // Start is called before the first frame update
    /*void Start()//запуск функций в этом блоке только один раз во время запуска игры
    {
        Debug.Log("Hello, World!");//записывает сообщение в консоль unity
       // rb.useGravity = false;//отключаем гравитацию(можно включить)
        rb.AddForce(0,200,500);//добавляем силу
    }*/

    // Update is called once per frame
    /*void Update()//запуск функций каждый раз, когда компьютер рисует новое изображение
    {
        rb.AddForce(0, 0, 2000*Time.deltaTime);//Время завершения в секундах с момента последнего кадра.
                                              // Это свойство предоставляет время между текущим и предыдущим кадром.
        //Debug.Log(Time.deltaTime);
        //возникает проблема в скорости на быстрых и медленных компах, ибо скорость смены кадров разная
    }*/
    void FixedUpdate()//для правильной работы физики, вызывается фиксированное количество раз в секунду
    {
        Debug.Log("Time time " + Time.time + " _timeMark " + _timeMark);
        // rb.AddForce(0, 0, 2000 * Time.deltaTime);
        rb.AddForce(0, 0, _fowardForcer * Time.deltaTime);
        if ((Input.GetKey("d")) || (Input.GetKey(KeyCode.RightArrow))) //возвращет правду пока пользователь нажимает d
        {
            rb.AddForce(_sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//Добавляет мгновенное изменение скорости к жесткому телу, игнорируя его массу.
        }
        if ((Input.GetKey("a"))|| (Input.GetKey(KeyCode.LeftArrow)))//возвращет правду пока пользователь нажимает d
        {
            rb.AddForce(-_sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space))//срабатывает на начало нажатия на клавишу
        {
            if(Time.time - _timeMark >= _cooldown)
            {
                rb.AddForce(transform.up * Time.deltaTime * _JumpForce, ForceMode.Impulse);
                _timeMark = Time.time;
            }
            // player.transform.position += player.transform.up *JumpForce* Time.deltaTime;
            
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<WorldGenerator>().InstantiateBlock();
    }
}
    //Fixed Timestep интервал, не зависящий от частоты кадров, который определяет,
    //когда выполняются физические вычисления и события FixedUpdate ().

