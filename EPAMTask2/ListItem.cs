using System;

namespace EPAMTask2
{
    class ListItem : IListItem
    {
        private IListItem _prev;

        public ListItem(object obj, IListItem prev = null)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            Value = obj;
            Prev = prev;
        }

        public object Value
        {
            get;
        }

        public IListItem Next
        {
            get;
            set;
        }

        public IListItem Prev
        {
            get;
            set;
        }
    }
}
