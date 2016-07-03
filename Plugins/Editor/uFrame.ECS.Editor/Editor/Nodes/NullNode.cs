using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor.Nodes
{
    public class NullNode : NullNodeBase {
        public override string ValueExpression
        {
            get { return "null"; }
        }
    }
    
    public partial interface INullConnectable : IDiagramNodeItem, IConnectable {
    }
}
