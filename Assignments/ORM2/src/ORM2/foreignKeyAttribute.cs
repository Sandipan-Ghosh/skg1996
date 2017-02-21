using System;

namespace ORM2
{
    internal class foreignKeyAttribute : Attribute
    {
        private string v;

        public foreignKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}