﻿using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using uFrame.MVVM.StateMachines;
using uFrame.Editor.Compiling.CodeGen;
using uFrame.Editor.Configurations;
using uFrame.MVVM.ViewModels;
using System.Collections.Generic;
using uFrame.Editor.Graphs.Data;

namespace uFrame.MVVM.Templates
{
    [TemplateClass(TemplateLocation.DesignerFile)]
    public partial class StateTemplate : State, IClassTemplate<StateNode>, ITemplateCustomFilename
    {
        public TemplateContext<StateNode> Ctx { get; set; }

        public string Filename
        {
            get
            {
                if (Ctx.Data.Name == null)
                {
                    throw new Exception(Ctx.Data.Name + " Graph name is empty");
                }
                return Path2.Combine("StateMachine.designer", Ctx.Data.Container().Name + "StateMachine.designer.cs");
            }
        }

        // Replace by ITemplateCustomFilename's Filename
        public string OutputPath { get { return ""; } }

        public bool CanGenerate { get { return true; } }


        public void TemplateSetup()
        {

        }
    }

    [RequiresNamespace("uFrame.MVVM.StateMachines")]
    public partial class StateTemplate
    {
        [ForEach("StateTransitions"), GenerateProperty("{0}"), WithField]
        public StateTransition TransitionProperty { get; set; }

        [GenerateProperty]
        public override string Name
        {
            get
            {
                Ctx._("return \"{0}\"", Ctx.Data.Name);
                return null;
            }
        }

        //[GenerateMethod(TemplateLocation.DesignerFile, AutoFill = AutoFillType.NameOnly, NameFormat = "{0}Transition")]
        [ForEach("StateTransitions"), GenerateMethod(CallBase = false), WithNameFormat("{0}Transition")]
        public void TransitionMethod()
        {
            Ctx._("this.Transition(this.{0})", Ctx.Item.Name);
        }
    }
}

