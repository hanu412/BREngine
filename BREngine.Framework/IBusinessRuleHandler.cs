using System;

namespace BREngine.Framework
{
    public interface IBusinessRuleHandler
    {
        void LogException(Exception exception);
        void AddMessage();
    }
}