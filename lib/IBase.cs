using System;

namespace lib
{
    public interface IBase
    {
        Int32 Id { get; set; }
        bool Removed { get; set; }
        void Print();
    }
}