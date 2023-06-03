declare var KTToggle:any;
declare var KTUtil:any;
declare var KTApp:any;
declare var KTSwapper:any;
declare var KTDrawer:any;
declare var KTSticky:any;
declare var KTScrolltop:any;
declare var KTPasswordMeter:any;
declare var KTDialer:any;
declare var KTImageInput:any;
declare var KTLayoutExplore:any;
declare var KTLayoutAside:any;
declare var KTMenu:any;
declare var KTImageInput:any;

export class MetronicJs{
  isJsLoaded = false;

  isChatJsLoaded = false;
  constructor(){}

  init(){
    if(!this.isJsLoaded){
      this.isJsLoaded = true;

      KTToggle.init();
      KTUtil.init();
      KTSwapper.init();
      KTDrawer.init();
      KTSticky.init();
      KTScrolltop.init();
      KTPasswordMeter.init();
      KTDialer.init();
      KTImageInput.init();
      KTLayoutExplore.init();
      KTLayoutAside.init();
      KTMenu.init();
      KTApp.init();
      KTImageInput.init();
    }
  }
}
