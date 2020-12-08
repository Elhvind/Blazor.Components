using Blazorade.Bootstrap.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Blazor.Components.Shared.Tables
{
    public class TableColumn<TItem> : BootstrapComponentBase where TItem : new()
    {
        public TableColumn()
        {
        }

        public TableColumn(string title, Func<TItem, string> property, IComparer<TItem> comparer)
        {
            this.Title = title;
            this.Sortable = true;
            this.Property = property;
            this.Comparer = comparer;
        }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool Sortable { get; set; }

        [Parameter]
        public IComparer<TItem> Comparer { get; set; }

        [Parameter]
        public Func<TItem, string> Property { get; set; }

        [Parameter]
        public RenderFragment<TItem> ItemTemplate { get; set; }

        [CascadingParameter]
        protected Table<TItem> Table { get; set; }

        protected override void OnInitialized()
        {
            this.Table?.AddColumn(this);

            base.OnInitialized();
        }
    }
}
