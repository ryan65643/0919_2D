using UnityEngine;

public class Test : MonoBehaviour
{
    public int tests;
    public int testsd=1;
    public int rrrr { get => 555; }
    public float rrrrr
    {
        set
        {
            print(value);
        }
    }
    public enum fdfgdfgdfg
    {
    a,b,c,d,¤¤123¤å
    }


    public fdfgdfgdfg rasd;
    private void Start()
    {
        tests = 555;
        print(tests + rrrr);
        rrrrr = 999;
        dd();

        switch (rasd)
        {
            case fdfgdfgdfg.a:
                break;
            case fdfgdfgdfg.b:
                break;
            case fdfgdfgdfg.c:
                break;
            case fdfgdfgdfg.d:
                break;

        }

    }





    private void dd()
    {
        while (testsd < 6)
        {
            print(testsd);
            testsd++;

        }
    }
    }
 