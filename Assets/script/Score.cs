using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    // �X�R�A��\������
    public Text scoreText;

    // �X�R�A
    private int score;

    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    private void Initialize()
    {
        // �X�R�A��0�ɖ߂�
        score = 0;
    }

    // �|�C���g�̒ǉ�
    public void AddPoint(int point)
    {
        score = score + point;
    }

}