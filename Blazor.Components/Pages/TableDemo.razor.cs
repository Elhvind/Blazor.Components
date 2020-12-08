using Blazor.Data;
using System;
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
                    StringProp = "String 1",
                    IntProp = 1,
                    DateTimeProp = DateTime.Now.AddDays(-1)
                },
                new TestObject
                {
                    StringProp = "String 2",
                    IntProp = 2,
                    DateTimeProp = DateTime.Now.AddDays(-2)
                },
                new TestObject
                {
                    StringProp = "String 3",
                    IntProp = 3,
                    DateTimeProp = DateTime.Now.AddDays(-3)
                }
            };

            base.OnInitialized();
        }
    }
}
