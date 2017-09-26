using System.Collections.Generic;

namespace EPAMTask2
{
    interface ILinkedList
    {
        void AddFirst(IListItem item);
        void AddLast(IListItem item);
        void Insert(IListItem item, int index);
        bool IsEmpty();
        IListItem GetFirst();
        IEnumerable<IListItem> GetAll();
        void Clear();
        void Reverse();
    }
}
