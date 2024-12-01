namespace ClassLibrary
{
    public class ArithmaticClass
    {
        public float z_func1(int arg1,int arg2,int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
        return 6*y-(((a+3)/x)/((2-x*a)/(x*y)))+(2+3*a)/(10*x+3*a)+4*y;
        }
        public float z_func2(int arg1, int arg2, int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
            return 2*y+(2+3*a)/(10*x-3*a)+2*a+((a/y)/(3*a/x));
        }
    }
}
