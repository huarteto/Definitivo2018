using Microsoft.Azure.Mobile.Server;

namespace _2018SATD.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}