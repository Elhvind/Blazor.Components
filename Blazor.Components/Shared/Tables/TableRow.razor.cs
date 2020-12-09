﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Blazor.Components.Shared.Tables
{
    /// <summary>
    /// The <c>TableRow</c> component represents a standard <c>&lt;tr&gt;</c> element.
    /// </summary>
    partial class TableRow<TItem> where TItem : new()
    {
        public TableRow()
        {
            this.Collapsed = true;
        }

        [Parameter]
        public TItem Item { get; set; }

        [Parameter]
        public bool Collapsed { get; set; }

        [Parameter]
        public RenderFragment<TItem> RowDetailsTemplate { get; set; }

        [Parameter]
        public IList<TableColumn<TItem>> Columns { get; set; }
    }
}
