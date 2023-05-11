using UnityEngine;

//PlayerController�� �÷��̾� ĳ���ͷμ� Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour {
    public AudioClip deathClip; // ��� �� ����� ����� Ŭ��
    public float jumpForce = 700f; // ����

    private int jumpCount = 0; // ���� ���� Ƚ��
    private bool isGrounded = false; // �ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isDead = false; //��� ����

    private Rigidbody2D playerRigidbody; // ����� ������ٵ� ������Ʈ
    private Animator animator; //����� �ִϸ����� ������Ʈ
    private AudioSource playerAudio; //����� ����� �ҽ� ������Ʈ

    private void Start(){
        // ���� ������Ʈ�κ��� ����� ������ƮƲ�� ������ ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    private void Update() {
        if (isDead)
        {
            //��� �� ó���� �� �̻� �������� �ʰ� ����
            return;
        }
        // ���콺 ���� ��ư�� �������� && �ִ� ���� Ƚ��(2)�� �������� �ʾҴٸ�
        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            // ���� Ƚ�� ����
            jumpCount++;
            // ���� ������ �ӵ��� ���������� ����(0,0)�� ����
            playerRigidbody.velocity = Vector2.zero;
            // ������ٵ� �������� �� �ֱ�
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            // ����� �ҽ� ���
            playerAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0) && playerRigidbody.velocity.y > 0)
        {
            // ���콺 ���ʿ��� ���� ���� ���� && �ӵ��� y ���� ������(���� ��� ��)
            // ���� �ӵ��� �������� ����
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;
        }

        // �ִϸ������� Grounded �Ķ���͸� isGrounded ������ ����
        animator.SetBool("Grounded", isGrounded)
    }                                
    private void Die { 
    
