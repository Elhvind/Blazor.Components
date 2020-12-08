using Blazor.Data;
using System.Collections.Generic;

namespace Blazor.Components.Pages
{
    public partial class TableDemo
    {
        public TableDemo()
        {
            this.Data = new List<TestObject>();
        }

        protected List<TestObject> Data { get; set; }

        protected override void OnInitialized()
        {
            this.Data = new List<TestObject>
            {
                new TestObject
                {
                    StringProp="String 1"
                },
                new TestObject
                {
                    StringProp="String 2"
                },
                new TestObject
                {
                    StringProp="String 3"
                }
            };

            base.OnInitialized();
        }
    }
}
