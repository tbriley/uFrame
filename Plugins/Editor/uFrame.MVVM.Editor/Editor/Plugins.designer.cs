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
    using uFrame.Editor;
    using uFrame.Editor.Configurations;
    using uFrame.Editor.Graphs.Data;
    using uFrame.Editor.GraphUI;
    using uFrame.Editor.GraphUI.Drawers;
    using uFrame.Editor.TypesSystem;
    using uFrame.IOC;
    
    
    public class uFrameMVVMBase : uFrame.Editor.DiagramPlugin {
        
        private uFrame.Editor.Configurations.NodeConfig<ServiceNode> _Service;
        
        private uFrame.Editor.Configurations.NodeConfig<SimpleClassNode> _SimpleClass;
        
        private uFrame.Editor.Configurations.NodeConfig<SubSystemNode> _SubSystem;
        
        private uFrame.Editor.Configurations.NodeConfig<ViewNode> _View;
        
        private uFrame.Editor.Configurations.NodeConfig<SceneTypeNode> _SceneType;
        
        private uFrame.Editor.Configurations.NodeConfig<ElementNode> _Element;
        
        private uFrame.Editor.Configurations.NodeConfig<CommandNode> _Command;
        
        private uFrame.Editor.Configurations.NodeConfig<MVVMNode> _MVVM;
        
        public uFrame.Editor.Configurations.NodeConfig<ServiceNode> Service {
            get {
                return _Service;
            }
            set {
                _Service = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<SimpleClassNode> SimpleClass {
            get {
                return _SimpleClass;
            }
            set {
                _SimpleClass = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<SubSystemNode> SubSystem {
            get {
                return _SubSystem;
            }
            set {
                _SubSystem = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<ViewNode> View {
            get {
                return _View;
            }
            set {
                _View = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<SceneTypeNode> SceneType {
            get {
                return _SceneType;
            }
            set {
                _SceneType = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<ElementNode> Element {
            get {
                return _Element;
            }
            set {
                _Element = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<CommandNode> Command {
            get {
                return _Command;
            }
            set {
                _Command = value;
            }
        }
        
        public uFrame.Editor.Configurations.NodeConfig<MVVMNode> MVVM {
            get {
                return _MVVM;
            }
            set {
                _MVVM = value;
            }
        }
        
        public virtual uFrame.Editor.TypesSystem.SelectTypeCommand GetPropertiesSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual uFrame.Editor.TypesSystem.SelectTypeCommand GetCollectionsSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual uFrame.Editor.TypesSystem.SelectTypeCommand GetCommandsSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public override void Initialize(uFrame.IOC.UFrameContainer container) {
            container.AddItem<BindingsReference>();
            container.AddTypeItem<CommandsChildItem>();
            container.AddItem<HandlersReference>();
            container.AddTypeItem<PropertiesChildItem>();
            container.AddItem<InstancesReference>();
            container.AddTypeItem<CollectionsChildItem>();
            Service = container.AddNode<ServiceNode,ServiceNodeViewModel,ServiceNodeDrawer>("Service");
            Service.Inheritable();
            Service.Color(NodeColor.LightGray);
            Service.HasSubNode<SimpleClassNode>();
            SimpleClass = container.AddNode<SimpleClassNode,SimpleClassNodeViewModel,SimpleClassNodeDrawer>("SimpleClass");
            SimpleClass.Inheritable();
            SimpleClass.Color(NodeColor.Gray);
            SubSystem = container.AddGraph<SubSystemGraph, SubSystemNode>("SubSystemGraph");
            SubSystem.Color(NodeColor.Blue);
            SubSystem.HasSubNode<ServiceNode>();
            SubSystem.HasSubNode<SimpleClassNode>();
            SubSystem.HasSubNode<ElementNode>();
            SubSystem.HasSubNode<CommandNode>();
            View = container.AddNode<ViewNode,ViewNodeViewModel,ViewNodeDrawer>("View");
            View.Inheritable();
            View.Color(NodeColor.Royalblue2);
            SceneType = container.AddNode<SceneTypeNode,SceneTypeNodeViewModel,SceneTypeNodeDrawer>("SceneType");
            SceneType.Inheritable();
            SceneType.Color(NodeColor.Orange);
            Element = container.AddNode<ElementNode,ElementNodeViewModel,ElementNodeDrawer>("Element");
            Element.Inheritable();
            Element.Color(NodeColor.Yellow);
            Element.HasSubNode<SimpleClassNode>();
            Element.HasSubNode<ViewNode>();
            Element.HasSubNode<CommandNode>();
            Command = container.AddNode<CommandNode,CommandNodeViewModel,CommandNodeDrawer>("Command");
            Command.Inheritable();
            Command.Color(NodeColor.Red);
            MVVM = container.AddGraph<MVVMGraph, MVVMNode>("MVVMGraph");
            MVVM.Color(NodeColor.DarkGray);
            MVVM.HasSubNode<SimpleClassNode>();
            MVVM.HasSubNode<SubSystemNode>();
            MVVM.HasSubNode<SceneTypeNode>();
            MVVM.HasSubNode<ServiceNode>();
            container.Connectable<ElementNode,Element>();
            container.Connectable<HandlersReference,SimpleClassNode>();
            container.Connectable<PropertiesChildItem,SceneProperties>();
        }
    }
}
