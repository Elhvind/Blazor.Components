using Blazorade.Bootstrap.Components;
using Microsoft.AspNetCore.Components;
using MST.VanDa.DataUd.Common.Model;
using System;
using System.Collections.Generic;

namespace Blazor.Components.Shared.Tables
{
    public class TableColumn : BootstrapComponentBase
    {
        public TableColumn()
        {
        }

        public TableColumn(string title, Func<Measurement, string> property, IComparer<Measurement> comparer)
        {
            this.Title = title;
            this.Sortable = true;
            this.Property = property;
            this.Comparer = comparer;
        }

        public string Title { get; set; }

        public bool Sortable { get; set; }

        public IComparer<Measurement> Comparer { get; set; }

        public Func<Measurement, string> Property { get; set; }

        [Parameter]
        public RenderFragment<Measurement> ItemTemplate { get; set; }
    }
}
