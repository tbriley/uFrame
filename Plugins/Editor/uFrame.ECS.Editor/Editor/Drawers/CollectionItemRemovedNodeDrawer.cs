using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor.GraphUI.Drawers;

namespace uFrame.ECS.Editor.Drawers
{
    public class CollectionItemRemovedNodeDrawer : GenericNodeDrawer<CollectionItemRemovedNode,CollectionItemRemovedNodeViewModel> {
        
        public CollectionItemRemovedNodeDrawer(CollectionItemRemovedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
