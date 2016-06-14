namespace BREngine.Framework
{
    public abstract class BaseValidationRule
    {



    }

    public abstract class BaseValidationRule<T> : BaseValidationRule where T : class,new()
    {
        public abstract void ValidateRule(T entity);
    }
}