namespace Learn_OOP_Console
{
    public class OOP_10_ref_out
    {
        public void Main()
        {
            MyClass my=new MyClass();
            int a = 4;
            int b = 6;
            int sum = my.Sum(ref a, ref b);

            int x;
            my.My(out x);
        }
    }

    class MyClass
    {
        public int Sum(ref int a,ref int b)
        {
            a = 12;
            b = 13;
            return a + b;
        }

        public void My(out int x)
        {
            x = 20;
        }
    }
}