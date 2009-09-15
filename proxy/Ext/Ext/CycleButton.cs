using System;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A specialized SplitButton that contains a menu of {@link Ext.menu.CheckItem} elements.  The button automatically
	///     cycles through each menu item on click, raising the button's {@link #change} event (or calling the button's
	///     {@link #changeHandler} function, if supplied) for the active menu item. Clicking on the arrow section of the
	///     button displays the dropdown menu just like a normal SplitButton.  Example usage:
	///     <pre><code>
	///     var btn = new Ext.CycleButton({
	///     showText: true,
	///     prependText: 'View as ',
	///     items: [{
	///     text:'text only',
	///     iconCls:'view-text',
	///     checked:true
	///     },{
	///     text:'HTML',
	///     iconCls:'view-html'
	///     }],
	///     changeHandler:function(btn, item){
	///     Ext.Msg.alert('Change View', item.text);
	///     }
	///     });
	///     </code></pre>
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\CycleButton.js</jssource>
	public class CycleButton : Ext.SplitButton {

		/// <summary>Create a new split button</summary>
		/// <returns></returns>
		public CycleButton() { C_(); }
		/// <summary>Create a new split button</summary>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public CycleButton(object config) { C_(config); }
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public CycleButton(Ext.Element config) { C_(config); }
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public CycleButton(string config) { C_(config); }

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public static CycleButton prototype { get { return S_<CycleButton>(); } set { S_(value); } }

		/// <summary>The reference to the constructor function</summary>
		public static Delegate constructor { get { return S_<Delegate>(); } set { S_(value); } }

		/// <summary>The reference to the class that this class inherits from</summary>
		public static Ext.SplitButton superclass { get { return S_<Ext.SplitButton>(); } set { S_(value); } }

		/// <summary>An array of {@link Ext.menu.CheckItem} <b>config</b> objects to be used when creating thebutton's menu items (e.g., {text:'Foo', iconCls:'foo-icon'})</summary>
		public System.Array items { get { return _<System.Array>(); } set { _(value); } }

		/// <summary>True to display the active item's text as the button text (defaults to false)</summary>
		public bool showText { get { return _<bool>(); } set { _(value); } }

		/// <summary>A static string to prepend before the active item's text when displayed as thebutton's text (only applies when showText = true, defaults to '')</summary>
		public string prependText { get { return _<string>(); } set { _(value); } }

		/// <summary>
		///     A callback function that will be invoked each time the active menuitem in the button's menu has changed.  If this callback is not supplied, the SplitButton will instead
		///     fire the {@link #change} event on active item change.  The changeHandler function will be called with the
		///     following argument list: (SplitButton this, Ext.menu.CheckItem item)
		/// </summary>
		public Delegate changeHandler { get { return _<Delegate>(); } set { _(value); } }

		/// <summary>
		///     A css class which sets an image to be used as the static icon for this button.  Thisicon will always be displayed regardless of which item is selected in the dropdown list.  This overrides the
		///     default behavior of changing the button's icon to match the selected item's icon on change.
		/// </summary>
		public string forceIcon { get { return _<string>(); } set { _(value); } }


		/// <summary>Sets the button's active menu item.</summary>
		/// <returns></returns>
		public virtual void setActiveItem() { _(); }

		/// <summary>Sets the button's active menu item.</summary>
		/// <param name="item">The item to activate</param>
		/// <returns></returns>
		public virtual void setActiveItem(Ext.menu.CheckItem item) { _(item); }

		/// <summary>Sets the button's active menu item.</summary>
		/// <param name="item">The item to activate</param>
		/// <param name="suppressEvent">True to prevent the button's change event from firing (defaults to false)</param>
		/// <returns></returns>
		public virtual void setActiveItem(Ext.menu.CheckItem item, bool suppressEvent) { _(item, suppressEvent); }

		/// <summary>Gets the currently active menu item.</summary>
		/// <returns>Ext.menu.CheckItem</returns>
		public virtual void getActiveItem() { _(); }

		/// <summary>
		///     This is normally called internally on button click, but can be called externally to advance the button's
		///     active item programmatically to the next one in the menu.  If the current item is the last one in the menu
		///     the active item will be set to the first item in the menu.
		/// </summary>
		/// <returns></returns>
		public virtual void toggleSelected() { _(); }



	}

	[JsAnonymous]
	public class CycleButtonConfig : DotWeb.Client.JsDynamicBase {
		/// <summary> An array of {@link Ext.menu.CheckItem} <b>config</b> objects to be used when creating the button's menu items (e.g., {text:'Foo', iconCls:'foo-icon'})</summary>
		public System.Array items { get { return _<System.Array>(); } set { _(value); } }

		/// <summary> True to display the active item's text as the button text (defaults to false)</summary>
		public bool showText { get { return _<bool>(); } set { _(value); } }

		/// <summary> A static string to prepend before the active item's text when displayed as the button's text (only applies when showText = true, defaults to '')</summary>
		public string prependText { get { return _<string>(); } set { _(value); } }

		/// <summary> A callback function that will be invoked each time the active menu item in the button's menu has changed.  If this callback is not supplied, the SplitButton will instead fire the {@link #change} event on active item change.  The changeHandler function will be called with the following argument list: (SplitButton this, Ext.menu.CheckItem item)</summary>
		public Delegate changeHandler { get { return _<Delegate>(); } set { _(value); } }

		/// <summary> A css class which sets an image to be used as the static icon for this button.  This icon will always be displayed regardless of which item is selected in the dropdown list.  This overrides the default behavior of changing the button's icon to match the selected item's icon on change.</summary>
		public string forceIcon { get { return _<string>(); } set { _(value); } }

		/// <summary> A function called when the arrow button is clicked (can be used instead of click event)</summary>
		public Delegate arrowHandler { get { return _<Delegate>(); } set { _(value); } }

		/// <summary> The title attribute of the arrow</summary>
		public string arrowTooltip { get { return _<string>(); } set { _(value); } }

		/// <summary> The button text</summary>
		public string text { get { return _<string>(); } set { _(value); } }

		/// <summary> The path to an image to display in the button (the image will be set as the background-image</summary>
		public string icon { get { return _<string>(); } set { _(value); } }

		/// <summary> A function called when the button is clicked (can be used instead of click event)</summary>
		public Delegate handler { get { return _<Delegate>(); } set { _(value); } }

		/// <summary> The scope of the handler</summary>
		public object scope { get { return _<object>(); } set { _(value); } }

		/// <summary> The minimum width for this button (used to give a set of buttons a common width)</summary>
		public double minWidth { get { return _<double>(); } set { _(value); } }

		/// <summary>{String/Object} The tooltip for the button - can be a string or QuickTips config object</summary>
		public object tooltip { get { return _<object>(); } set { _(value); } }

		/// <summary> True to start hidden (defaults to false)</summary>
		public bool hidden { get { return _<bool>(); } set { _(value); } }

		/// <summary> True to start disabled (defaults to false)</summary>
		public bool disabled { get { return _<bool>(); } set { _(value); } }

		/// <summary> True to start pressed (only if enableToggle = true)</summary>
		public bool pressed { get { return _<bool>(); } set { _(value); } }

		/// <summary> The group this toggle button is a member of (only 1 per group can be pressed, only</summary>
		public string toggleGroup { get { return _<string>(); } set { _(value); } }

		/// <summary>{Boolean/Object} True to repeat fire the click event while the mouse is down. This can also be</summary>
		public object repeat { get { return _<object>(); } set { _(value); } }

		/// <summary> Set a DOM tabIndex for this button (defaults to undefined)</summary>
		public double tabIndex { get { return _<double>(); } set { _(value); } }

		/// <summary>  False to not allow a pressed Button to be depressed (defaults to undefined). Only valid when {@link #enableToggle} is true.</summary>
		public bool allowDepress { get { return _<bool>(); } set { _(value); } }

		/// <summary>  True to enable pressed/not pressed toggling (defaults to false)</summary>
		public bool enableToggle { get { return _<bool>(); } set { _(value); } }

		/// <summary>  Function called when a Button with {@link #enableToggle} set to true is clicked. Two arguments are passed:<ul class="mdetail-params"> <li><b>button</b> : Ext.Button<div class="sub-desc">this Button object</div></li> <li><b>state</b> : Boolean<div class="sub-desc">The next state if the Button, true means pressed.</div></li> </ul></summary>
		public Delegate toggleHandler { get { return _<Delegate>(); } set { _(value); } }

		/// <summary>  Standard menu attribute consisting of a reference to a menu object, a menu id or a menu config blob (defaults to undefined).</summary>
		public object menu { get { return _<object>(); } set { _(value); } }

		/// <summary>  The position to align the menu to (see {@link Ext.Element#alignTo} for more details, defaults to 'tl-bl?').</summary>
		public string menuAlign { get { return _<string>(); } set { _(value); } }

		/// <summary>  A css class which sets a background image to be used as the icon for this button</summary>
		public string iconCls { get { return _<string>(); } set { _(value); } }

		/// <summary>  submit, reset or button - defaults to 'button'</summary>
		public string type { get { return _<string>(); } set { _(value); } }

		/// <summary>  The type of event to map to the button's event handler (defaults to 'click')</summary>
		public string clickEvent { get { return _<string>(); } set { _(value); } }

		/// <summary>  False to disable visual cues on mouseover, mouseout and mousedown (defaults to true)</summary>
		public bool handleMouseEvents { get { return _<bool>(); } set { _(value); } }

		/// <summary>  The type of tooltip to use. Either "qtip" (default) for QuickTips or "title" for title attribute.</summary>
		public string tooltipType { get { return _<string>(); } set { _(value); } }

		/// <summary> (Optional) An {@link Ext.Template} with which to create the Button's main element. This Template must contain numeric substitution parameter 0 if it is to display the text property. Changing the template could require code modifications if required elements (e.g. a button) aren't present.</summary>
		public Ext.Template template { get { return _<Ext.Template>(); } set { _(value); } }

		/// <summary>  A CSS class string to apply to the button's main element.</summary>
		public string cls { get { return _<string>(); } set { _(value); } }

		/// <summary> 
		///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
		///     The predefined xtypes are listed at the top of this document.
		///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
		/// </summary>
		public string xtype { get { return _<string>(); } set { _(value); } }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id).</summary>
		public string id { get { return _<string>(); } set { _(value); } }

		/// <summary>{String/Object}  A tag name or DomHelper spec to create an element with. This is intended to create shorthand utility components inline via JSON. It should not be used for higher level components which already create their own elements. Example usage: <pre><code> {xtype:'box', autoEl: 'div', cls:'my-class'} {xtype:'box', autoEl: {tag:'blockquote', html:'autoEl is cool!'}} // with DomHelper </code></pre></summary>
		public object autoEl { get { return _<object>(); } set { _(value); } }

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public string overCls { get { return _<string>(); } set { _(value); } }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public string style { get { return _<string>(); } set { _(value); } }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public string ctCls { get { return _<string>(); } set { _(value); } }

		/// <summary>{Object/Array}  An object or array of objects that will provide custom functionality for this component.  The only requirement for a valid plugin is that it contain an init method that accepts a reference of type Ext.Component. When a component is created, if any plugins are available, the component will call the init method on each plugin, passing a reference to itself.  Each plugin can then call methods or respond to events on the component as needed to provide its functionality.</summary>
		public object plugins { get { return _<object>(); } set { _(value); } }

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some structural markup for this component.  When applyTo is used, constituent parts of the component can also be specified by id or CSS class name within the main element, and the component being created may attempt to create its subcomponents from that markup if applicable. Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the component's container.</summary>
		public object applyTo { get { return _<object>(); } set { _(value); } }

		/// <summary>  The id of the node, a DOM node or an existing Element that will be the container to render this component into. Using this config, a call to render() is not required.</summary>
		public object renderTo { get { return _<object>(); } set { _(value); } }

		/// <summary>  A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link staterestore}, {@link beforestatesave} and {@link statesave} events</p></summary>
		public bool stateful { get { return _<bool>(); } set { _(value); } }

		/// <summary>  The unique id for this component to use for state management purposes (defaults to the component id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
		public string stateId { get { return _<string>(); } set { _(value); } }

		/// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
		public string disabledClass { get { return _<string>(); } set { _(value); } }

		/// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
		public bool allowDomMove { get { return _<bool>(); } set { _(value); } }

		/// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
		public bool autoShow { get { return _<bool>(); } set { _(value); } }

		/// <summary>  How this component should hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</summary>
		public string hideMode { get { return _<string>(); } set { _(value); } }

		/// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
		public bool hideParent { get { return _<bool>(); } set { _(value); } }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return _<object>(); } set { _(value); } }

	}

    public class CycleButtonEvents {
        /// <summary>
        ///     Fires after the button's active menu item has changed.  Note that if a {@link #changeHandler} function
        ///     is set on this CycleButton, it will be called instead on active item change and this change event will
        ///     not be fired.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.CycleButton} objthis, {Ext.menu.CheckItem} item)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>item</b></term><description>The menu item that was selected</description></item>
        /// </list>
        /// </summary>
        public static string change { get { return "change"; } }
    }

    public delegate void CycleButtonChangeDelegate(Ext.CycleButton objthis, Ext.menu.CheckItem item);
}