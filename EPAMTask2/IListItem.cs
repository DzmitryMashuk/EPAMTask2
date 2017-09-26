namespace EPAMTask2
{
    interface IListItem
    {
        IListItem Prev { get; set; }
        IListItem Next { get; set; }
        object Value { get; }
    }
}
