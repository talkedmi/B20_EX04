using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;

        public ValueOutOfRangeException(int i_MinValue, int i_MaxValue, string i_ExceptionMessage) : base(i_ExceptionMessage)
        {
            this.m_MaxValue = i_MaxValue;
            this.m_MinValue = i_MinValue;
        }

        public ValueOutOfRangeException(int i_MinValue, int I_MaxValue, string i_ExceptionMessage, Exception i_InnerException) :
            base(i_ExceptionMessage, i_InnerException)
        {
            this.m_MaxValue = I_MaxValue;
            this.m_MinValue = i_MinValue;
        }
    }
}
