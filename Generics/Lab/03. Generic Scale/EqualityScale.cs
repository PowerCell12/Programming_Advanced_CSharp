namespace GenericScale;


public class EqualityScale<T> where T: IEquatable<T>{

    private T Left;
    private T Right;

    public EqualityScale(T left,  T right)
    {
        this.Left = left;
        this.Right =right;
    }

    public bool AreEqual(){


        return this.Left.Equals(this.Right);

    }



}