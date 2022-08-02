namespace _220802DelegateReivew
{
    public class TestClass
    {
        public delegate void DelFunctionTest();
        public delegate int DelAdd(int a, int b);
        int num = 1;
        double num2 = 11.1;

        public TestClass()
        {
            DelFunctionTest mydelegate;
            mydelegate = FunctionTest;
            mydelegate();

            DelAdd delAdd = Add;
            delAdd(1 ,2);

        }

        public void FunctionTest()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
