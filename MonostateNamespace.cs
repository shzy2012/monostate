namespace MonostateNamespace {
    using System;

    class Program {
        static void Main(string[] args) {
            MonoState m1 = new MonoState();
            m1.setX(2);
            MonoState m2 = new MonoState();
            var getX = m2.getX();

            //不同对象，同一行为
            Console.WriteLine("getX = {0}", getX);
        }
    }

    public class MonoState {
        private static int itsX = 0;
        public MonoState() { }


        public void setX(int x) {
            itsX = x;
            Console.WriteLine("setX:{0}", itsX);
        }

        public int getX() {
            Console.WriteLine("getX:{0}", itsX);
            return itsX;
        }
    }
}
