// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using uFrame.ECS.Editor.ChildItems;
using uFrame.ECS.Editor.Drawers;
using uFrame.ECS.Editor.Graphs;
using uFrame.ECS.Editor.Nodes;
using uFrame.ECS.Editor.Sections;
using uFrame.ECS.Editor.Slots;
using uFrame.ECS.Editor.ViewModels;
using uFrame.Editor;
using uFrame.Editor.Configurations;
using uFrame.Editor.Graphs.Data;
using uFrame.Editor.GraphUI;
using uFrame.Editor.GraphUI.Drawers;
using uFrame.Editor.TypesSystem;
using uFrame.IOC;

namespace uFrame.ECS.Editor
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class uFrameECSBase : DiagramPlugin {
        
        private NodeConfig<CustomActionNode> _CustomAction;
        
        private NodeConfig<DataNode> _Data;
        
        private NodeConfig<LibraryNode> _Library;
        
        private NodeConfig<NullNode> _Null;
        
        private NodeConfig<StringLiteralNode> _StringLiteral;
        
        private NodeConfig<PropertyNode> _Property;
        
        private NodeConfig<StringNode> _String;
        
        private NodeConfig<ActionGroupNode> _ActionGroup;
        
        private NodeConfig<StopTimerNode> _StopTimer;
        
        private NodeConfig<FunctionNode> _Function;
        
        private NodeConfig<BoolNode> _Bool;
        
        private NodeConfig<ModuleNode> _Module;
        
        private NodeConfig<AnyFalseNode> _AnyFalse;
        
        private NodeConfig<CodeActionNode> _CodeAction;
        
        private NodeConfig<BoolExpressionNode> _BoolExpression;
        
        private NodeConfig<FloatNode> _Float;
        
        private NodeConfig<UserMethodNode> _UserMethod;
        
        private NodeConfig<LoopCollectionNode> _LoopCollection;
        
        private NodeConfig<ComponentCreatedNode> _ComponentCreated;
        
        private NodeConfig<SetVariableNode> _SetVariable;
        
        private NodeConfig<AnyTrueNode> _AnyTrue;
        
        private NodeConfig<CollectionItemRemovedNode> _CollectionItemRemoved;
        
        private NodeConfig<CollectionModifiedHandlerNode> _CollectionModifiedHandler;
        
        private NodeConfig<ObjectNode> _Object;
        
        private NodeConfig<PropertyChangedNode> _PropertyChanged;
        
        private NodeConfig<VariableNode> _Variable;
        
        private NodeConfig<GroupNode> _Group;
        
        private NodeConfig<DescriptorNode> _Descriptor;
        
        private NodeConfig<Vector3Node> _Vector3;
        
        private NodeConfig<EventNode> _Event;
        
        private NodeConfig<LiteralNode> _Literal;
        
        private NodeConfig<ComponentNode> _Component;
        
        private NodeConfig<AllFalseNode> _AllFalse;
        
        private NodeConfig<IntNode> _Int;
        
        private NodeConfig<CollectionItemAddedNode> _CollectionItemAdded;
        
        private NodeConfig<ComponentDestroyedNode> _ComponentDestroyed;
        
        private NodeConfig<Vector2Node> _Vector2;
        
        private NodeConfig<SequenceContainerNode> _SequenceContainer;
        
        private NodeConfig<AllTrueNode> _AllTrue;
        
        private NodeConfig<StartTimerNode> _StartTimer;
        
        private NodeConfig<ConditionNode> _Condition;
        
        private NodeConfig<ActionNode> _Action;
        
        private NodeConfig<HandlerNode> _Handler;
        
        private NodeConfig<SystemNode> _System;
        
        private NodeConfig<EntityNode> _Entity;
        
        private NodeConfig<ColorNode> _Color;
        
        private NodeConfig<EnumValueNode> _EnumValue;
        
        private NodeConfig<SequenceItemNode> _SequenceItem;
        
        public NodeConfig<CustomActionNode> CustomAction {
            get {
                return _CustomAction;
            }
            set {
                _CustomAction = value;
            }
        }
        
        public NodeConfig<DataNode> Data {
            get {
                return _Data;
            }
            set {
                _Data = value;
            }
        }
        
        public NodeConfig<LibraryNode> Library {
            get {
                return _Library;
            }
            set {
                _Library = value;
            }
        }
        
        public NodeConfig<NullNode> Null {
            get {
                return _Null;
            }
            set {
                _Null = value;
            }
        }
        
        public NodeConfig<StringLiteralNode> StringLiteral {
            get {
                return _StringLiteral;
            }
            set {
                _StringLiteral = value;
            }
        }
        
        public NodeConfig<PropertyNode> Property {
            get {
                return _Property;
            }
            set {
                _Property = value;
            }
        }
        
        public NodeConfig<StringNode> String {
            get {
                return _String;
            }
            set {
                _String = value;
            }
        }
        
        public NodeConfig<ActionGroupNode> ActionGroup {
            get {
                return _ActionGroup;
            }
            set {
                _ActionGroup = value;
            }
        }
        
        public NodeConfig<StopTimerNode> StopTimer {
            get {
                return _StopTimer;
            }
            set {
                _StopTimer = value;
            }
        }
        
        public NodeConfig<FunctionNode> Function {
            get {
                return _Function;
            }
            set {
                _Function = value;
            }
        }
        
        public NodeConfig<BoolNode> Bool {
            get {
                return _Bool;
            }
            set {
                _Bool = value;
            }
        }
        
        public NodeConfig<ModuleNode> Module {
            get {
                return _Module;
            }
            set {
                _Module = value;
            }
        }
        
        public NodeConfig<AnyFalseNode> AnyFalse {
            get {
                return _AnyFalse;
            }
            set {
                _AnyFalse = value;
            }
        }
        
        public NodeConfig<CodeActionNode> CodeAction {
            get {
                return _CodeAction;
            }
            set {
                _CodeAction = value;
            }
        }
        
        public NodeConfig<BoolExpressionNode> BoolExpression {
            get {
                return _BoolExpression;
            }
            set {
                _BoolExpression = value;
            }
        }
        
        public NodeConfig<FloatNode> Float {
            get {
                return _Float;
            }
            set {
                _Float = value;
            }
        }
        
        public NodeConfig<UserMethodNode> UserMethod {
            get {
                return _UserMethod;
            }
            set {
                _UserMethod = value;
            }
        }
        
        public NodeConfig<LoopCollectionNode> LoopCollection {
            get {
                return _LoopCollection;
            }
            set {
                _LoopCollection = value;
            }
        }
        
        public NodeConfig<ComponentCreatedNode> ComponentCreated {
            get {
                return _ComponentCreated;
            }
            set {
                _ComponentCreated = value;
            }
        }
        
        public NodeConfig<SetVariableNode> SetVariable {
            get {
                return _SetVariable;
            }
            set {
                _SetVariable = value;
            }
        }
        
        public NodeConfig<AnyTrueNode> AnyTrue {
            get {
                return _AnyTrue;
            }
            set {
                _AnyTrue = value;
            }
        }
        
        public NodeConfig<CollectionItemRemovedNode> CollectionItemRemoved {
            get {
                return _CollectionItemRemoved;
            }
            set {
                _CollectionItemRemoved = value;
            }
        }
        
        public NodeConfig<CollectionModifiedHandlerNode> CollectionModifiedHandler {
            get {
                return _CollectionModifiedHandler;
            }
            set {
                _CollectionModifiedHandler = value;
            }
        }
        
        public NodeConfig<ObjectNode> Object {
            get {
                return _Object;
            }
            set {
                _Object = value;
            }
        }
        
        public NodeConfig<PropertyChangedNode> PropertyChanged {
            get {
                return _PropertyChanged;
            }
            set {
                _PropertyChanged = value;
            }
        }
        
        public NodeConfig<VariableNode> Variable {
            get {
                return _Variable;
            }
            set {
                _Variable = value;
            }
        }
        
        public NodeConfig<GroupNode> Group {
            get {
                return _Group;
            }
            set {
                _Group = value;
            }
        }
        
        public NodeConfig<DescriptorNode> Descriptor {
            get {
                return _Descriptor;
            }
            set {
                _Descriptor = value;
            }
        }
        
        public NodeConfig<Vector3Node> Vector3 {
            get {
                return _Vector3;
            }
            set {
                _Vector3 = value;
            }
        }
        
        public NodeConfig<EventNode> Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public NodeConfig<LiteralNode> Literal {
            get {
                return _Literal;
            }
            set {
                _Literal = value;
            }
        }
        
        public NodeConfig<ComponentNode> Component {
            get {
                return _Component;
            }
            set {
                _Component = value;
            }
        }
        
        public NodeConfig<AllFalseNode> AllFalse {
            get {
                return _AllFalse;
            }
            set {
                _AllFalse = value;
            }
        }
        
        public NodeConfig<IntNode> Int {
            get {
                return _Int;
            }
            set {
                _Int = value;
            }
        }
        
        public NodeConfig<CollectionItemAddedNode> CollectionItemAdded {
            get {
                return _CollectionItemAdded;
            }
            set {
                _CollectionItemAdded = value;
            }
        }
        
        public NodeConfig<ComponentDestroyedNode> ComponentDestroyed {
            get {
                return _ComponentDestroyed;
            }
            set {
                _ComponentDestroyed = value;
            }
        }
        
        public NodeConfig<Vector2Node> Vector2 {
            get {
                return _Vector2;
            }
            set {
                _Vector2 = value;
            }
        }
        
        public NodeConfig<SequenceContainerNode> SequenceContainer {
            get {
                return _SequenceContainer;
            }
            set {
                _SequenceContainer = value;
            }
        }
        
        public NodeConfig<AllTrueNode> AllTrue {
            get {
                return _AllTrue;
            }
            set {
                _AllTrue = value;
            }
        }
        
        public NodeConfig<StartTimerNode> StartTimer {
            get {
                return _StartTimer;
            }
            set {
                _StartTimer = value;
            }
        }
        
        public NodeConfig<ConditionNode> Condition {
            get {
                return _Condition;
            }
            set {
                _Condition = value;
            }
        }
        
        public NodeConfig<ActionNode> Action {
            get {
                return _Action;
            }
            set {
                _Action = value;
            }
        }
        
        public NodeConfig<HandlerNode> Handler {
            get {
                return _Handler;
            }
            set {
                _Handler = value;
            }
        }
        
        public NodeConfig<SystemNode> System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public NodeConfig<EntityNode> Entity {
            get {
                return _Entity;
            }
            set {
                _Entity = value;
            }
        }
        
        public NodeConfig<ColorNode> Color {
            get {
                return _Color;
            }
            set {
                _Color = value;
            }
        }
        
        public NodeConfig<EnumValueNode> EnumValue {
            get {
                return _EnumValue;
            }
            set {
                _EnumValue = value;
            }
        }
        
        public NodeConfig<SequenceItemNode> SequenceItem {
            get {
                return _SequenceItem;
            }
            set {
                _SequenceItem = value;
            }
        }
        
        public virtual SelectTypeCommand GetOutputsSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual SelectTypeCommand GetInputsSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual SelectTypeCommand GetPropertiesSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual SelectTypeCommand GetCollectionsSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public virtual SelectTypeCommand GetVariablesSelectionCommand() {
            return new SelectTypeCommand() { IncludePrimitives = true, AllowNone = false };
        }
        
        public override void Initialize(UFrameContainer container) {
            container.AddItem<RequireReference>();
            container.AddTypeItem<OutputsChildItem>();
            container.AddTypeItem<InputsChildItem>();
            container.AddTypeItem<VariablesChildItem>();
            container.AddTypeItem<PropertiesChildItem>();
            container.AddTypeItem<CollectionsChildItem>();
            container.AddItem<BranchesChildItem>();
            CustomAction = container.AddNode<CustomActionNode,CustomActionNodeViewModel,CustomActionNodeDrawer>("CustomAction");
            CustomAction.Color(NodeColor.Gray);
            Data = container.AddGraph<DataGraph, DataNode>("DataGraph");
            Data.Color(NodeColor.Yellow);
            Data.HasSubNode<GroupNode>();
            Data.HasSubNode<EventNode>();
            Data.HasSubNode<ComponentNode>();
            Library = container.AddGraph<LibraryGraph, LibraryNode>("LibraryGraph");
            Library.Color(NodeColor.Yellow);
            Library.HasSubNode<GroupNode>();
            Library.HasSubNode<EventNode>();
            Library.HasSubNode<CustomActionNode>();
            Library.HasSubNode<ComponentNode>();
            Null = container.AddNode<NullNode,NullNodeViewModel,NullNodeDrawer>("Null");
            Null.Color(NodeColor.Purple);
            StringLiteral = container.AddNode<StringLiteralNode,StringLiteralNodeViewModel,StringLiteralNodeDrawer>("StringLiteral");
            StringLiteral.Color(NodeColor.Gray);
            Property = container.AddNode<PropertyNode,PropertyNodeViewModel,PropertyNodeDrawer>("Property");
            Property.Color(NodeColor.Blue);
            String = container.AddNode<StringNode,StringNodeViewModel,StringNodeDrawer>("String");
            String.Color(NodeColor.Purple);
            ActionGroup = container.AddNode<ActionGroupNode,ActionGroupNodeViewModel,ActionGroupNodeDrawer>("ActionGroup");
            ActionGroup.Color(NodeColor.Red);
            StopTimer = container.AddNode<StopTimerNode,StopTimerNodeViewModel,StopTimerNodeDrawer>("StopTimer");
            StopTimer.Color(NodeColor.Gray);
            Function = container.AddNode<FunctionNode,FunctionNodeViewModel,FunctionNodeDrawer>("Function");
            Function.Color(NodeColor.Lightgoldenrod4);
            Bool = container.AddNode<BoolNode,BoolNodeViewModel,BoolNodeDrawer>("Bool");
            Bool.Color(NodeColor.Purple);
            Module = container.AddGraph<ModuleGraph, ModuleNode>("ModuleGraph");
            Module.Color(NodeColor.Black);
            Module.HasSubNode<EventNode>();
            Module.HasSubNode<ComponentNode>();
            Module.HasSubNode<CustomActionNode>();
            Module.HasSubNode<SystemNode>();
            Module.HasSubNode<GroupNode>();
            AnyFalse = container.AddNode<AnyFalseNode,AnyFalseNodeViewModel,AnyFalseNodeDrawer>("AnyFalse");
            AnyFalse.Color(NodeColor.Orange);
            CodeAction = container.AddNode<CodeActionNode,CodeActionNodeViewModel,CodeActionNodeDrawer>("CodeAction");
            CodeAction.Color(NodeColor.Green);
            BoolExpression = container.AddNode<BoolExpressionNode,BoolExpressionNodeViewModel,BoolExpressionNodeDrawer>("BoolExpression");
            BoolExpression.Color(NodeColor.Gray);
            Float = container.AddNode<FloatNode,FloatNodeViewModel,FloatNodeDrawer>("Float");
            Float.Color(NodeColor.Purple);
            UserMethod = container.AddNode<UserMethodNode,UserMethodNodeViewModel,UserMethodNodeDrawer>("UserMethod");
            UserMethod.Color(NodeColor.Blue);
            LoopCollection = container.AddNode<LoopCollectionNode,LoopCollectionNodeViewModel,LoopCollectionNodeDrawer>("LoopCollection");
            LoopCollection.Color(NodeColor.LightGray);
            ComponentCreated = container.AddNode<ComponentCreatedNode,ComponentCreatedNodeViewModel,ComponentCreatedNodeDrawer>("ComponentCreated");
            ComponentCreated.Color(NodeColor.Indianred4);
            SetVariable = container.AddNode<SetVariableNode,SetVariableNodeViewModel,SetVariableNodeDrawer>("SetVariable");
            SetVariable.Color(NodeColor.Gray);
            AnyTrue = container.AddNode<AnyTrueNode,AnyTrueNodeViewModel,AnyTrueNodeDrawer>("AnyTrue");
            AnyTrue.Color(NodeColor.Orange);
            CollectionItemRemoved = container.AddNode<CollectionItemRemovedNode,CollectionItemRemovedNodeViewModel,CollectionItemRemovedNodeDrawer>("CollectionItemRemoved");
            CollectionItemRemoved.Color(NodeColor.Indianred4);
            CollectionModifiedHandler = container.AddNode<CollectionModifiedHandlerNode,CollectionModifiedHandlerNodeViewModel,CollectionModifiedHandlerNodeDrawer>("CollectionModifiedHandler");
            CollectionModifiedHandler.Color(NodeColor.Red);
            Object = container.AddNode<ObjectNode,ObjectNodeViewModel,ObjectNodeDrawer>("Object");
            Object.Color(NodeColor.Purple);
            PropertyChanged = container.AddNode<PropertyChangedNode,PropertyChangedNodeViewModel,PropertyChangedNodeDrawer>("PropertyChanged");
            PropertyChanged.Color(NodeColor.Indianred4);
            Variable = container.AddNode<VariableNode,VariableNodeViewModel,VariableNodeDrawer>("Variable");
            Variable.Color(NodeColor.Gray);
            Group = container.AddNode<GroupNode,GroupNodeViewModel,GroupNodeDrawer>("Group");
            Group.Color(NodeColor.SgiLightBlue);
            Group.HasSubNode<AnyFalseNode>();
            Group.HasSubNode<Vector3Node>();
            Group.HasSubNode<Vector2Node>();
            Group.HasSubNode<ConditionNode>();
            Group.HasSubNode<AnyTrueNode>();
            Group.HasSubNode<AllFalseNode>();
            Group.HasSubNode<BoolExpressionNode>();
            Group.HasSubNode<PropertyNode>();
            Group.HasSubNode<AllTrueNode>();
            Group.HasSubNode<FloatNode>();
            Group.HasSubNode<StringNode>();
            Group.HasSubNode<IntNode>();
            Group.HasSubNode<BoolNode>();
            Descriptor = container.AddNode<DescriptorNode,DescriptorNodeViewModel,DescriptorNodeDrawer>("Descriptor");
            Descriptor.Color(NodeColor.Stateblue2);
            Vector3 = container.AddNode<Vector3Node,Vector3NodeViewModel,Vector3NodeDrawer>("Vector3");
            Vector3.Color(NodeColor.Purple);
            Event = container.AddNode<EventNode,EventNodeViewModel,EventNodeDrawer>("Event");
            Event.Inheritable();
            Event.Color(NodeColor.Gold3);
            Literal = container.AddNode<LiteralNode,LiteralNodeViewModel,LiteralNodeDrawer>("Literal");
            Literal.Color(NodeColor.Purple);
            Component = container.AddNode<ComponentNode,ComponentNodeViewModel,ComponentNodeDrawer>("Component");
            Component.Inheritable();
            Component.Color(NodeColor.Darkolivegreen4);
            AllFalse = container.AddNode<AllFalseNode,AllFalseNodeViewModel,AllFalseNodeDrawer>("AllFalse");
            AllFalse.Color(NodeColor.Orange);
            Int = container.AddNode<IntNode,IntNodeViewModel,IntNodeDrawer>("Int");
            Int.Color(NodeColor.Purple);
            CollectionItemAdded = container.AddNode<CollectionItemAddedNode,CollectionItemAddedNodeViewModel,CollectionItemAddedNodeDrawer>("CollectionItemAdded");
            CollectionItemAdded.Color(NodeColor.Indianred4);
            ComponentDestroyed = container.AddNode<ComponentDestroyedNode,ComponentDestroyedNodeViewModel,ComponentDestroyedNodeDrawer>("ComponentDestroyed");
            ComponentDestroyed.Color(NodeColor.Indianred4);
            Vector2 = container.AddNode<Vector2Node,Vector2NodeViewModel,Vector2NodeDrawer>("Vector2");
            Vector2.Color(NodeColor.Purple);
            SequenceContainer = container.AddNode<SequenceContainerNode,SequenceContainerNodeViewModel,SequenceContainerNodeDrawer>("SequenceContainer");
            SequenceContainer.Color(NodeColor.Red);
            AllTrue = container.AddNode<AllTrueNode,AllTrueNodeViewModel,AllTrueNodeDrawer>("AllTrue");
            AllTrue.Color(NodeColor.Orange);
            StartTimer = container.AddNode<StartTimerNode,StartTimerNodeViewModel,StartTimerNodeDrawer>("StartTimer");
            StartTimer.Color(NodeColor.Gray);
            Condition = container.AddNode<ConditionNode,ConditionNodeViewModel,ConditionNodeDrawer>("Condition");
            Condition.Color(NodeColor.Orange);
            Action = container.AddNode<ActionNode,ActionNodeViewModel,ActionNodeDrawer>("Action");
            Action.Color(NodeColor.Green);
            Handler = container.AddGraph<HandlerGraph, HandlerNode>("HandlerGraph");
            Handler.Color(NodeColor.Palevioletred4);
            Handler.HasSubNode<SetVariableNode>();
            Handler.HasSubNode<ActionGroupNode>();
            Handler.HasSubNode<ActionNode>();
            Handler.HasSubNode<ComponentNode>();
            Handler.HasSubNode<ObjectNode>();
            Handler.HasSubNode<LoopCollectionNode>();
            Handler.HasSubNode<IntNode>();
            Handler.HasSubNode<PropertyNode>();
            Handler.HasSubNode<EnumValueNode>();
            Handler.HasSubNode<Vector2Node>();
            Handler.HasSubNode<FloatNode>();
            Handler.HasSubNode<NullNode>();
            Handler.HasSubNode<BoolNode>();
            Handler.HasSubNode<SequenceItemNode>();
            Handler.HasSubNode<Vector3Node>();
            Handler.HasSubNode<StringNode>();
            System = container.AddGraph<SystemGraph, SystemNode>("SystemGraph");
            System.Color(NodeColor.Blue);
            System.HasSubNode<CollectionItemAddedNode>();
            System.HasSubNode<ComponentNode>();
            System.HasSubNode<PropertyChangedNode>();
            System.HasSubNode<ComponentCreatedNode>();
            System.HasSubNode<CustomActionNode>();
            System.HasSubNode<HandlerNode>();
            System.HasSubNode<DescriptorNode>();
            System.HasSubNode<EventNode>();
            System.HasSubNode<GroupNode>();
            System.HasSubNode<ComponentDestroyedNode>();
            System.HasSubNode<CollectionItemRemovedNode>();
            Entity = container.AddNode<EntityNode,EntityNodeViewModel,EntityNodeDrawer>("Entity");
            Entity.Color(NodeColor.Gray);
            Color = container.AddNode<ColorNode,ColorNodeViewModel,ColorNodeDrawer>("Color");
            Color.Color(NodeColor.Purple);
            EnumValue = container.AddNode<EnumValueNode,EnumValueNodeViewModel,EnumValueNodeDrawer>("EnumValue");
            EnumValue.Color(NodeColor.Purple);
            SequenceItem = container.AddNode<SequenceItemNode,SequenceItemNodeViewModel,SequenceItemNodeDrawer>("SequenceItem");
            SequenceItem.Color(NodeColor.Green);
            container.Connectable<BoolExpressionNode,Expressions>();
            container.Connectable<BoolExpressionNode,GroupNode>();
            container.Connectable<ComponentNode,RequireReference>();
            container.Connectable<ActionNode,ActionNode>();
            container.Connectable<HandlerNode,SequenceItemNode>();
            container.Connectable<SequenceItemNode,SequenceItemNode>();
        }
    }
}
