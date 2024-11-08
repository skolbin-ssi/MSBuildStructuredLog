﻿namespace Microsoft.Build.Logging.StructuredLogger
{
    public class AddItem : NamedNode, IHasLineNumber
    {
        public AddItem()
        {
            DisableChildrenCache = true;
        }

        public override string TypeName => nameof(AddItem);

        public int? LineNumber { get; set; }
    }

    public class TaskParameterItem : AddItem
    {
        public string ParameterName { get; set; }
    }
}
