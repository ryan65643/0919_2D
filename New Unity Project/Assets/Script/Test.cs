using UnityEngine;

public class Test : MonoBehaviour
{
    public int tests;
    public int rrrr { get =>555 ; }
    public float rrrrr
    {
        set
        {
            print(value) ;
        }
    }
    private void Start()
    {
        tests = 555;
        print(tests+rrrr);
        rrrrr = 999;
    }


}
 