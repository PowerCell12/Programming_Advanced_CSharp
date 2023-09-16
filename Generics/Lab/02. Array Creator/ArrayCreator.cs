namespace GenericArrayCreator;

public class ArrayCreator{

    public static T[] Create<T>(int Length, T item){

        T[] array = new T[Length];

        for (int i = 0; i < Length; i++){

            array[i] = item;

        }

        return array;


    }


}