namespace BackEnd.Models.Common;

public interface ICopyable<TValue>
{
    TValue Copy();
}