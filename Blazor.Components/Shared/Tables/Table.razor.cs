using Microsoft.AspNetCore.Components;

namespace Blazor.Components.Shared.Tables
{
    public partial class Table
    {
        public Table()
        {
            this.Size = TableSize.Normal;
            this.Bordered = false;
            this.Borderless = false;
            this.Striped = false;
            this.Hoverable = false;
            this.Responsive = false;
        }

        [Parameter]
        public RenderFragment TableHeaderTemplate { get; set; }

        [Parameter]
        public RenderFragment TableBodyTemplate { get; set; }

        [Parameter]
        public RenderFragment TableFooterTemplate { get; set; }

        /// <summary>
        /// The size of the table. Defaults to <see cref="TableSize.Normal"/>.
        /// </summary>
        [Parameter]
        public TableSize Size { get; set; }

        /// <summary>
        /// Add <c>.table-bordered</c> for borders on all sides of the table and cells.
        /// </summary>
        [Parameter]
        public bool Bordered { get; set; }

        /// <summary>
        /// Add <c>.table-borderless</c> for a table without borders.
        /// </summary>
        [Parameter]
        public bool Borderless { get; set; }

        /// <summary>
        /// Use <c>.table-striped</c> to add zebra-striping to any table row within the <c>&lt;tbody&gt;</c>.
        /// </summary>
        [Parameter]
        public bool Striped { get; set; }

        /// <summary>
        /// Add <c>.table-hover</c> to enable a hover state on table rows within a <c>&lt;tbody&gt;</c>.
        /// </summary>
        [Parameter]
        public bool Hoverable { get; set; }

        /// <summary>
        /// Across every breakpoint, use <c>.table-responsive</c> for horizontally scrolling tables.
        /// </summary>
        [Parameter]
        public bool Responsive { get; set; }

        protected override void OnParametersSet()
        {
            this.AddClasses("table");

            if (this.Size == TableSize.Small)
                this.AddClasses("table-sm");

            if (this.Bordered)
                this.AddClasses("table-bordered");

            if (this.Borderless)
                this.AddClasses("table-borderless");

            if (this.Striped)
                this.AddClasses("table-striped");

            if (this.Hoverable)
                this.AddClasses("table-hover");

            if (this.Responsive)
                this.AddClasses("table-responsive");

            base.OnParametersSet();
        }
    }

    /// <summary>
    /// Defines different sizes for <see cref="Table"/> components.
    /// </summary>
    public enum TableSize
    {
        Normal,
        Small
    }
}
