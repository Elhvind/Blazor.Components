using Blazorade.Bootstrap.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Blazor.Components.Shared.Tables
{
    public class TableColumn<TItem> : BootstrapComponentBase, IDisposable where TItem : new()
    {
        public TableColumn()
        {
        }

        public TableColumn(string title, Func<TItem, string> property)
        {
            this.Title = title;
            this.Property = property;
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

            if (this.Sortable && this.Comparer == null)
                this.Comparer = Comparer<TItem>.Create((a, b) => this.Property(a).CompareTo(this.Property(b)));

            base.OnInitialized();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Table?.RemoveColumn(this);
            }
        }
    }
}
