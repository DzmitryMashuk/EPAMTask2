using System.Collections;
using System.Collections.Generic;

namespace EPAMTask2
{
    class LinkedList : ILinkedList, IEnumerable
    {
        private IListItem _head;
        private IListItem _tail;
        private int _count;

        public void AddFirst(IListItem item)
        {
            IListItem temp = _head;

            _head = item;

            _head.Next = temp;

            if (_count == 0)
            {
                _tail = _head;
            }
            else
            {
                temp.Prev = _head;
            }

            _count++;
        }
        public void AddLast(IListItem item)
        {
            if (_count == 0)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
                item.Prev = _tail;
            }

            _tail = item;
            _count++;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        public IEnumerable<IListItem> GetAll()
        {
            IListItem current = _head.Next;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }
        public IListItem GetFirst()
        {
            return _head;
        }
        public void Insert(IListItem item, int index)
        {
            IListItem _currentItem = _head;

            if (index > _count)
            {
                AddLast(item);
            }
            else
            {
                for (int i = 1; i < index; i++)
                {
                    _currentItem = _currentItem.Next;
                }

                if (_currentItem == _head)
                {
                    AddFirst(item);
                }
                else
                {
                    _currentItem.Prev.Next = item;
                    item.Next = _currentItem;
                    _count++;
                }
            }
        }
        
        //    if (index > _count)
        //    {
        //        AddLast(item);
        //        return;
        //    }

        //    IListItem _currentItem = _head;
            
        //    for (int i = 0; i < index; i++)
        //        _currentItem = _currentItem.Next;

        //    item.Prev = _currentItem.Prev;
        //    _tail.Next = item;
        //    item.Next = _currentItem;
        //    _currentItem.Prev = item;
        //    _count++;
        //}
        public bool IsEmpty()
        {
            return _count == 0 ? true : false;
        }
        public void Reverse()
        {
            if (_head == null)
            {
                return;
            }

            IListItem _next = null;
            IListItem _prev = null;
            IListItem _current = _head;

            while (_current.Next != null)
            {
                _next = _current.Next;
                _current.Next = _prev;
                _prev = _current;
                _current = _next;
            }

            _current.Next = _prev;
            _head = _current;
        }
    }
}
