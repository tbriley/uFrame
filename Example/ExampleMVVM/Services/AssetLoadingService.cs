namespace Example {
    using Example;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using UniRx;
    using UnityEngine;
    
    
    public class AssetLoadingService : AssetLoadingServiceBase {
        
        /// <summary>
        /// This method is invoked whenever the kernel is loading
        /// Since the kernel lives throughout the entire lifecycle  of the game, this will only be invoked once.
        /// </summary>
        public override void Setup() {
            base.Setup();
            // Use the line below to subscribe to events
            // this.OnEvent<MyEvent>().Subscribe(myEventInstance => { TODO });
        }
        
        /// <sumarry>
        // This method is executed when using this.Publish(new StartAssetLoadingCommand())
        /// </sumarry>
        public override void StartAssetLoadingCommandHandler(StartAssetLoadingCommand data) {
            base.StartAssetLoadingCommandHandler(data);
            // Process the commands information. Also, you can publish new events by using the line below.
            // this.Publish(new AnotherEvent())
        }
    }
}