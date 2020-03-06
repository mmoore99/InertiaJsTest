namespace InertiaAdapter.Models
{
    public class Props
    {
        public object Controller { get; set; } = new { };
        public object Share { get; set; } = new { };
        public object With { get; set; } = new { };
        public object MergedProps => MergeProps();

        private object MergeProps()
        {
            Controller ??= new { };
            Share ??= new { };
            With ??= new { };
            var mergedProps = TypeMerger.TypeMerger.Merge(Controller, Share);
            return TypeMerger.TypeMerger.Merge(mergedProps, With);
        }
    }
}