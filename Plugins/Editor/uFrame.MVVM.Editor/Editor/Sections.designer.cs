// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Editor.Configurations;
    using uFrame.Editor.Core;
    using uFrame.Editor.Graphs.Data;
    
    
    public class BindingsReferenceBase : uFrame.Editor.Graphs.Data.GenericReferenceItem<IBindingsConnectable> {
        
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
    
    public partial interface IBindingsConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class HandlersReferenceBase : uFrame.Editor.Graphs.Data.GenericReferenceItem<IHandlersConnectable>, ISimpleClassConnectable {
        
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
    
    public partial interface IHandlersConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
    
    public class InstancesReferenceBase : uFrame.Editor.Graphs.Data.GenericReferenceItem<IInstancesConnectable> {
        
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
    
    public partial interface IInstancesConnectable : uFrame.Editor.Graphs.Data.IDiagramNodeItem, uFrame.Editor.Graphs.Data.IConnectable {
    }
}
