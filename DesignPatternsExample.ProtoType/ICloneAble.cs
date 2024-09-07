namespace DesignPatternsExample.ProtoType
{
    public interface ICloneAble<out T>
    {
        T Clone();
    }
}
