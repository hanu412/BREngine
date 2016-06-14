using BREngine.Common;
using System;
using System.Collections.Generic;


namespace BREngine.Framework
{
    public class CommonRule<T> : BusinessRule<T> where T : class, new()
    {
       
        /// <summary>
        /// Gets or Sets the RuleNumber
        /// </summary>
        public string RuleId;

        /// <summary>
        /// Gets or Sets the message to be logged into Db
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets the Item Number
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// Gets or Sets the Key Identifer
        /// </summary>
        public string KeyIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets the Validation Condition
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets the Log Level
        /// </summary>
        public LogLevel LogLevel { get; set; }


        private static Queue<BusinessRule<T>> _rules;
        

        internal static Queue<BusinessRule<T>> Rules
        {
            get
            {
                return _rules;
            }

            set
            {
                _rules = value;
            }

        }

        public CommonRule()
        {
            if (Rules == null)
            {
                Rules = new Queue<BusinessRule<T>>();
            }

            Init();
        }
        public override void SetNextRule(BusinessRule<T> next)
        {

            Rules.Enqueue(next);
        }


        public override void ValidateRule(T entity)
        {
            base.ValidateRule(entity);
        }
        

        public override void Initialize()
        {
         
        }

        public override void AddMessage()
        {
            
        }

      

        private void Init()
        {
            Initialize();

        }
        public override void LogException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
