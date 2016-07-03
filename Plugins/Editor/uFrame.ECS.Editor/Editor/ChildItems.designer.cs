// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

//namespace Invert.uFrame.ECS

using uFrame.Editor.Graphs.Data;

namespace uFrame.ECS.Editor
{

    public class OutputsChildItemBase : GenericTypedChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IOutputsConnectable : IDiagramNodeItem, IConnectable {
    }
    
    public class InputsChildItemBase : GenericTypedChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IInputsConnectable : IDiagramNodeItem, IConnectable {
    }
    
    public class VariablesChildItemBase : GenericTypedChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IVariablesConnectable : IDiagramNodeItem, IConnectable {
    }
    
    public class PropertiesChildItemBase : GenericTypedChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IPropertiesConnectable : IDiagramNodeItem, IConnectable {
    }
    
    public class CollectionsChildItemBase : GenericTypedChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface ICollectionsConnectable : IDiagramNodeItem, IConnectable {
    }
    
    public class BranchesChildItemBase : GenericNodeChildItem {
        
        public override bool AllowMultipleInputs {
            get {
                return true;
            }
        }
        
        public override bool AllowMultipleOutputs {
            get {
                return true;
            }
        }
    }
    
    public partial interface IBranchesConnectable : IDiagramNodeItem, IConnectable {
    }
}
