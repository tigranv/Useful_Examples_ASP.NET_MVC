# ASP.NET Page Class  <img src="https://cloud.githubusercontent.com/assets/24522089/24391421/08a39e1e-13a0-11e7-85af-51c0f5f76a6a.png" align="right" width="200px" height="180px" /> 

### ASP.NET Page Life-Cycle

When an ASP.NET page runs, the page goes through a life cycle in which it performs a series of processing steps. These include initialization, instantiating controls, restoring and maintaining state, running event handler code, and rendering.

> **General Page Life-Cycle Stages**

Some parts of the life cycle occur only when a page is processed as a postback. For postbacks, the page life cycle is the same during a partial-page postback (as when you use an UpdatePanel control) as it is during a full-page postback

|Stage|Description|
|-----------------------|--------------------------------------------------|
|Page request|The page request occurs before the page life cycle begins. When the page is requested by a user, ASP.NET determines whether the page needs to be parsed and compiled (therefore beginning the life of a page), or whether a cached version of the page can be sent in response without running the page.|
|Start|In the start stage, page properties such as Request and Response are set. At this stage, the page also determines whether the request is a postback or a new request and sets the **IsPostBack** property. The page also sets the UICulture property.|
|Initialization|During page initialization, controls on the page are available and each control's UniqueID property is set. A master page and themes are also applied to the page if applicable. If the current request is a postback, the postback data has not yet been loaded and control property values have not been restored to the values from view state.|
|Load|During load, if the current request is a postback, control properties are loaded with information recovered from view state and control state.|
|Postback event handling|If the request is a postback, control event handlers are called. After that, the Validate method of all validator controls is called, which sets the IsValid property of individual validator controls and of the page.|
|Rendering|Before rendering, view state is saved for the page and all controls. During the rendering stage, the page calls the Render method for each control, providing a text writer that writes its output to the OutputStream object of the page's Response property.|
|Unload| The Unload event is raised after the page has been fully rendered, sent to the client, and is ready to be discarded. At this point, page properties such as Response and Request are unloaded and cleanup is performed.|
-----------------------------------------------------------------------------------------

> **Life-Cycle Events**

Within each stage of the life cycle of a page, the page raises events that you can handle to run your own code. For control events, you bind the event handler to the event, either declaratively using attributes such as onclick, or in code.
Pages also support automatic event wire-up, meaning that ASP.NET looks for methods with particular names and automatically runs those methods when certain events are raised. If the **AutoEventWireup** attribute of the Page directive is set to true, page events are automatically bound to methods that use the naming convention of Page_event, such as Page_Load and Page_Init.
The following table lists the page life-cycle events that you will use most frequently.

|Page Event|Typical Use|
|-----------------|--------------------|
|PreInit| Raised after the start stage is complete and before the initialization stage begins. Use this event for the following: **1** Check the IsPostBack property to determine whether this is the first time the page is being processed. The IsCallback and IsCrossPagePostBack properties have also been set at this time. **2** Create or re-create dynamic controls. **3** Set a master page dynamically. **4** Set the Theme property dynamically. **5** Read or set profile property values.|
|Init|Raised after all controls have been initialized and any skin settings have been applied. The Init event of individual controls occurs before the Init event of the page. Use this event to read or initialize control properties.|
|InitComplete|Raised at the end of the page's initialization stage. Only one operation takes place between the Init and InitComplete events: tracking of view state changes is turned on. View state tracking enables controls to persist any values that are programmatically added to the ViewState collection. Until view state tracking is turned on, any values added to view state are lost across postbacks. Controls typically turn on view state tracking immediately after they raise their Init event. Use this event to make changes to view state that you want to make sure are persisted after the next postback.|
|PreLoad|Raised after the page loads view state for itself and all controls, and after it processes postback data that is included with the Request instance.|
|Load|The Page object calls the OnLoad method on the Page object, and then recursively does the same for each child control until the page and all controls are loaded. The Load event of individual controls occurs after the Load event of the page. Use the OnLoad event method to set properties in controls and to establish database connections.|
|LoadComplete|Raised at the end of the event-handling stage. Use this event for tasks that require that all other controls on the page be loaded.|
|PreRender|Raised after the Page object has created all controls that are required in order to render the page, including child controls of composite controls. (To do this, the Page object calls EnsureChildControls for each control and for the page.)
The Page object raises the PreRender event on the Page object, and then recursively does the same for each child control. The PreRender event of individual controls occurs after the PreRender event of the page. Use the event to make final changes to the contents of the page or its controls before the rendering stage begins.|
|PreRenderComplete|Raised after each data bound control whose DataSourceID property is set calls its DataBind method. For more information, see Data Binding Events for Data-Bound Controls later in this topic.|
|SaveStateComplete|Raised after view state and control state have been saved for the page and for all controls. Any changes to the page or controls at this point affect rendering, but the changes will not be retrieved on the next postback.|
|Render|This is not an event; instead, at this stage of processing, the Page object calls this method on each control. All ASP.NET Web server controls have a Render method that writes out the control's markup to send to the browser.
If you create a custom control, you typically override this method to output the control's markup. However, if your custom control incorporates only standard ASP.NET Web server controls and no custom markup, you do not need to override the Render method. For more information, see Developing Custom ASP.NET Server Controls.
A user control (an .ascx file) automatically incorporates rendering, so you do not need to explicitly render the control in code.|
|Unload|Raised for each control and then for the page.
In controls, use this event to do final cleanup for specific controls, such as closing control-specific database connections.
For the page itself, use this event to do final cleanup work, such as closing open files and database connections, or finishing up logging or other request-specific tasks.|


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
