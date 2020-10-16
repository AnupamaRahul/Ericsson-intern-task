using System;

namespace ArrayApplication
{
    class Vector<T> where T : class
    {

        int msize = 10;
        T[] array;
        int nelem;
        public Vector()
        {

            array = new T[msize];
            nelem = 0;
        }
        public bool addElement(T elem)
        {
            if (nelem < msize)
            {
                array[nelem++] = elem;
                return true;
            }
            else return false;

        }
        public int getNumElements() { return nelem; }
        public int getCapacity() { return msize; }

        public bool msearch(T key)
        {
            for (int i = 0; i < nelem; i++)
                if (array[i].Equals(key))
                    return true;
            return false;

        }


    }
    class VectorMain
    {
        static void Main(string[] args)
        {

            Vector<object> vector = new Vector<object>();
            vector.addElement(5);
            vector.addElement(6);
            vector.addElement(8);
            System.Console.WriteLine(vector.msearch(6));
            System.Console.WriteLine(vector.msearch(9));
        }
    }
}