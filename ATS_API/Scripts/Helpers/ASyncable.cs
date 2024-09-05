public class ASyncable<ATS>
{
    public virtual bool Sync()
    {
        return true;
    }
    
    public virtual void PostSync()
    {
    }
}