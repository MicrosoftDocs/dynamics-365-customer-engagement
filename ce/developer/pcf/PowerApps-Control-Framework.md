---
title: "Create Custom Controls using PowerApps Control Framework | MicrosoftDocs"
ms.custom: ""
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 046a8ef1-d1f8-4eb0-9938-40ee8fda11b4
caps.latest.revision: 18
ms.author: "nabuthuk"
manager: ""
---
# Create Custom Controls using PowerApps Control Framework

Use the **PowerApps Control Framework (PCF)** to create custom controls to provide enhanced experiences for people to view and work with data in forms, views, and dashboards. For example: 
-	Replace a field that displays a numeric text value with a dial or slider control. 
- Transform a list into an entirely different visual experience bound to the data set like a “Calendar” or “Map”.

Majority of the controls found in model-driven apps that use the **Unified Interface** are implemented using PCF. Custom controls are metadata driven, configurable, reusable, solution aware and responsive. As a developer, you will implement an interface and the application will take care of the rest.

> [!NOTE] 
> Custom controls are supported only on Unified Interface. 

## What are custom controls?

Custom controls are a type of solution component, which means they can be included in a solution and installed in different environments. More information: Package and distribute extensions using solutions.

Custom controls created using PCF enable a developer to add custom visualization and logic for various UI elements. You can view custom controls in the solution explorer, but there is no way to add or edit them in the application. 

You add custom controls by including them in a solution and then importing it into the system. Once they are in the system, customizers can configure form fields, sub-grids, views, and dashboard sub-grids to use them in place of default controls. 

Data about custom controls is stored in the *CustomControl* and *CustomControlResource* entities. 
The CustomControl entity has the following important attributes:


|Attribute  |	Description|
|---|---|
|Manifest |An XML document describing application metadata about the control|
|Name | The name of the control described in the manifest| 
|Version |	The version number of the control described in the manifest|

The *CustomControlResource* entity is related to the *CustomControl* entity to provide details about the resources used by the control. The *CustomControlResource.WebResourceId* attribute contains the value of the *WebResource.WebResourceId* for the *WebResource* entity record that will contain the definition of the resource used by the custom control.

### Manifest
The manifest is the metadata file that defines a control. It is an XML document that describes:
- The namespace of the control.
- The kind of data it can be bound to, either a field or a data-set.
- Any properties that can be configured in the application when the control is added.
- A list of web resource files that the control needs. 
  - One of them must be a JavaScript web resource. This JavaScript must include a function that will instantiate an object. This implements an interface that exposes methods that are required for the control to work. This is called the control implementation library.
- The name of a JavaScript function in the control implementation library that will return an object that applies the required control interface. 

When someone configures a control in the application, the data in the manifest will filter out available controls so that only valid controls for the context are available for configuration.The properties defined in the manifest for a control are rendered as configuration fields so that the person configuring the control can specify values. These property values are then available to your control function at run time.More information: Manifest file reference

### Control implementation library
Each custom control must have one JavaScript library that includes the definition of a function which will return an object that implements the methods described in the custom control interface. 
The object can implement the following methods:
- init (Required)
- updateView (Required)
- getOutputs (Optional)
- destroy (Required)

These methods control the lifecycle of the custom control. 

#### Page load
When the page loads, the application requires an object to work with. Using data from the Manifest, the code will get the object by calling
```js
var obj =  new ["namespace on manifest"].["constructor on maifest"]();
```
If the namespace and constructor values from the manifest were *"MyNameSpace"* and *"LinearInputControl"* respectively, the code run to instantiate the object would be this:
```js
var controlObj = new MyNameSpace.LinearInputControl();
```
When the page is ready, it will initialize the control by calling the init function. The page will call the init function with a set of parameters.
```js
controlObj.init(context,notifyOutputChanged,state,container);
```
|Parameter|	Description|
|---|---|
|context| Contains all the information about how the control is configured and all the PCF API's that can be used within the custom control.For example, the *context.parameters.["property name from manifest"]* can be used to access an input property.|
|notifyOutputChanged |	A function that your code will call to alert the framework that the control has new outputs ready to be retrieved asynchronously. You must implement this within the init function. More information: User changes data.|
|state|Contains control data from the previous page load in the current session.|
|container|An HTML div element to which you will append the HTML elements for the UI that defines your control. To display the value in your UI, you must get the data from the context.parameters.controlValue object. You must implement this in the init function.|


### User changes data
After the page loads, your control is just displaying the data until the user interacts with the control to change the data. When this occurs, you can manage it any way you like, but you must call the function passed in as notifyOutputChanged parameter in the init function. When you use this function, the platform will then respond by calling the getOutputs method that you must implement. The getOutputs methods will return any values that represent changes a user made. For a field control, this would typically be the new value for the control.

### App changes data
If the data is changed by the platform it will call the updateView method of your control object and pass a new context object as a parameter. You must implement this method and use it to update the value displayed in the control.

### Page close
When the user navigates away from the page the control will lose scope and usually all the memory allocated in that page for the objects in your control will be cleared. However, some items based on the browser implementation mechanism might stay and consume memory. Typically, these are event handlers. If user wants to store the information, they should implement the “setControlState” method so that the information will be given next time within the same session.
You should define a destroy method in your object. This will be called when the page closes and you should use it to remove any clean up code such as removing any event handlers. 

Before you go ahead and start creating your custom controls, make sure you have all the pre-requisites. 

## Pre-requisites
To create custom controls, you will need:
- Microsoft Dynamics 365 Online (v9.0) environment with System administrator or System customizer Privileges.
- Download and extract the PowerAppsControlFramework_Preview.zip file. 
- Install Typescript from Typescript official web (Optional).
- Install Visual Studio Code (optional)

## How to create a custom control
To create custom controls, you need to follow each step mentioned below.

- Copy and paste one of the existing controls in the controls folder.
- Update the Manifest, CSS, JavaScript and TypeScript files
- Create a solution zip file using the PowerShell script.
- Import custom controls into Dynamics 365.
- Adding custom controls to a form.

## Copy and paste one of the existing controls in the controls folder
When you download the PowerAppsControlFramework_Preview.zip file and extract it, 
You will get,
•	Docs folder which has documentation files for all the individual sample controls.
•	src folder which has two subfolders controls and typing. 
o	controls folder has the sample controls. 
o	typing folder contains TypeScript file for the control framework APIs.
•	solution_template folder which has the necessary template files for building the solution.
•	A PowerShell script “Create_Preview_Solution.ps1” which generates a solution file for the controls. 
•	LegacyWebResource folder which contains a sample HTML web resource.

In the controls folder you have an option to choose either a TypeScript or JavaScript control for creating your custom control. All the TypeScript controls starts with “TS_(name)” and all the JavaScript controls start with “JS_(name)”. 
Note: Copy and paste the control inside the controls folder. If you copy and paste it outside the controls folder and when you run the script, this control is not included in the solution package. 

## Update the Manifest, CSS, JavaScript and TypeScript files 
When you copy and paste the existing controls and rename it, you need to update the accompanying Manifest, CSS and any other files for that control. More information: Manifest file reference 
You need to edit the existing TypeScript or JavaScript file to implement the custom logic for the control. See the tutorial on how to implement the logic. 
Tutorial: Implementing controls using JavaScript.
Tutorial: Implementing controls using TypeScript.

## Create a solution zip file using the PowerShell script
The Create_Preview_Solution.ps1 PowerShell script creates the solution package file for the controls. It is recommended to change the publisher and solution unique name in the solution.xml file in solution_template folder before you run the script.

### To run the PowerShell script in the file explorer, 
- Right click on the Create_Preview_Solution and click on Run with PowerShell as shown in the screenshot.
- A drop folder is created which has the solution package file, that you can import manually. A target folder is also created at the same time. When you run the script, initially the files are copied over to the target folder and then a drop package is built from the contents of the target folder.

### To run PowerShell script using Windows PowerShell,
- Open the Windows PowerShell application.
- Navigate to the directory where you have downloaded and extracted the folder, for example, assuming the folder is downloaded at *C:\Users\YourUsername* 
- Run the command *C:\Users\YourUsername\Get-ExecutionPolicy* to check whether the execution policy is **Restricted** on your machine.
- If the command returns Restricted. Run the following command to change the policy.
  *C:\Users\YourUsername\Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned*
- Now, run the command below,
  *C:\Users\username\PowerAppsControlFramework_Preview\create_preview_solution.ps1-uploadToServer $true*
- When you run the above command, it will automatically import the solution file into the org and it also creates a drop folder which has the solution file, that you can import manually. 
- If you don't want to automatically import the solution file into the org, run the following command.
*C:\Users\username\PowerAppsControlFramework_Preview\Create_Preview_Solution.ps1-uploadToServer $false*

## Import custom controls into Dynamics 365

- When you run the PowerShell, script provided in the PowerAppsControlFramework_Preview folder using file explorer, it creates a drop folder which contains the solution file, which you can import manually. More information: Import Solutions
- When you run the PowerShell, script from the command line, a dialog box pops up where you need to enter the org credentials.

 


## Adding custom controls to a form
 To add a custom control to a form, follow the steps in Add controls to a form.

## Adding custom controls to a grid
To add a custom control like data-set control or simple table control to a grid or view, follow the steps below.

- Navigate to Settings > Customizations and click on Customize the System.
- Click on the arrow next to Entities tab a select the entity you want to add the custom control. 
- Click on the Controls tab and click on Add a control.
- On the Add Control page, select the control that you want, such as Simple Table control and then select Add.
- Choose the client where you want the control to appear.

## Tutorial: Implementing controls using JavaScript
The Hello world sample control explains how to implement a custom control in JavaScript
- Copy and paste one of the existing JavaScript controls, rename and save it in the controls folder. 
- Update the ControlManifest.xml, CSS and JavaScript files accordingly. For example, if you renamed the control in the above step, update the same in the ControlManifest.xml file in the code path as shown below.
```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest>
    <control namespace="MyNameSpace" constructor="JSHelloWorldControl" version="1.0.0" display-name-key="JS_HelloWorld_Control_Display_Key" description-key="JS_HelloWorld_Control_Desc_Key" control-type="standard">
        <property name="myFirstProperty" display-name-key="myFirstProperty_Display_Key" description-key="myFirstProperty_Desc_Key" of-type="SingleLine.Text" usage="bound" required="true" />
        <resources>
            <code path="JS_HelloWorldScript.js" order="1" />
            <css path="css/JS_HelloWorldStyle.css" order="1" />
        </resources>
    </control>
</manifest>
```
- Open the JavaScript file and change the existing logic and implement the logic for your custom control.

### Sample Code:
This sample code explains how to implement a control in JavaScript. 

```js
"use strict";

var MyNameSpace = MyNameSpace || {};
MyNameSpace.JSHelloWorldControl = function(){
}

MyNameSpace.JSHelloWorldControl.prototype.init = function (context, notifyOutputChanged, state, container) {
    this._labelElement = document.createElement("label");
    this._labelElement.setAttribute("class", "JS_HelloWorldColor");
    container.appendChild(this._labelElement);
};

MyNameSpace.JSHelloWorldControl.prototype.updateView = function (context) {
    this._labelElement.innerText = "Hello World! (JS)";
};

MyNameSpace.JSHelloWorldControl.prototype.getOutputs = function () {
    return {};
};

MyNameSpace.JSHelloWorldControl.prototype.destroy = function () {
};
```
- Build the solution file using the script in the PowerAppsControlFramework_Preview folder. More information: Create a solution zip file using the PowerShell script.

> [!NOTE]
> You can find more samples in the controls folder. 

## Tutorial: Implementing controls using TypeScript
The linear input control is designed to change the user experience of interacting with numeric types on the form. Instead of keying in the numbers, this control provides a linear slider using which the value of the attribute can be set on the form.  

- Copy and paste one of the existing TypeScript controls, rename and save it in the controls folder.  
- Update the ControlManifest.xml, CSS, and TypeScript files accordingly. For example, if you have renamed the control in the above step, update the same in the ControlManifest.xml file.
- Open the TypeScript file and change the existing logic and implement the logic for your custom control. 

### Sample Code:
This sample code explains how to implement controls in TypeScript.

```ts
module SampleNamespace
{
    export class TSLinearInputControl implements ControlFramework.StandardControl<InputsOutputs.IInputBag, InputsOutputs.IOutputBag> {
        private _value: number;
        private _notifyOutputChanged: () => void;
        private labelElement: HTMLLabelElement;
        private inputElement: HTMLInputElement;
        private _container: HTMLDivElement;
        private _context: ControlFramework.Context<InputsOutputs.IInputBag>;
        private _refreshData: EventListenerOrEventListenerObject;
        
        public init(context: ControlFramework.Context<InputsOutputs.IInputBag>, notifyOutputChanged: () => void, state: ControlFramework.Dictionary, container:HTMLDivElement)
        {
            this._context = context;
            this._container = document.createElement("div");
            this._notifyOutputChanged = notifyOutputChanged;
            this._refreshData = this.refreshData.bind(this);
            this.inputElement = document.createElement("input");
            this.inputElement.setAttribute("type","range");
            this.inputElement.addEventListener("input",this._refreshData);
            this.inputElement.setAttribute("min","1");
            this.inputElement.setAttribute("max","1000");
            this.inputElement.setAttribute("class","linearslider");
            this.inputElement.setAttribute("id","linearrangeinput");
            this.labelElement = document.createElement("label");
            this.labelElement.setAttribute("class", "TS_LinearRangeLabel");
            this.labelElement.setAttribute("id","lrclabel");
            this._value = context.parameters.controlValue.raw;
            this.inputElement.setAttribute("value",context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "0");
            this.labelElement.innerHTML = context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "0";
            this._container.appendChild(this.inputElement);
            this._container.appendChild(this.labelElement);
            container.appendChild(this._container);
        }
        
        
        public refreshData(context: ControlFramework.Context<InputsOutputs.IInputBag>,)
        {
            this._value = (this.inputElement.value as any)as number;
            this.labelElement.innerHTML = this.inputElement.value;
            this._notifyOutputChanged();
        }

        
        public updateView(context: ControlFramework.Context<InputsOutputs.IInputBag>,): void
        {
            
            this._value = context.parameters.controlValue.raw;
            this._context = context;
            this.inputElement.setAttribute("value",context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "");
            this.labelElement.innerHTML = context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "";
        }

        
        public getOutputs(): InputsOutputs.IOutputBag
        {
            return {
                controlValue : this._value
            };
        }
        public destroy()
        {
            this.inputElement.removeEventListener("input", this._refreshData);
        }
    }
}
```
- Build the solution file using the script in the PowerAppsControlFramework_Preview folder. More information: Create a solution zip file using the PowerShell script.

## Debugging custom controls
Use Fiddler AutoResponder to quickly debug your custom controls. Install the latest Fiddler from [https://www.telerik.com/download/fiddler]. 
Follow the steps mentioned in the article to configure AutoResponder  Streamline JavaScript web resource development using Fiddler AutoResponder. 
This tool comes handy while you debugging your controls. You don’t need to publish all the changes you made in the script and debug. Apply the changes to your local file and start Fiddler trace capture and go to the browser where you are debugging the control and reload the page. You will see the local file in the developer tools. 

### Browser debugging 
Each browser provides you with a debugging tool to help you debug your code natively in the browser. Typically, you activate debugging in your browser by pressing the F12 key to display the native developer tool used for debugging.
For example, on Microsoft Edge, 
- Go to the Form/Dashboard where the control should be rendered. 
- Press F12 to open inspector. 
- On top bar, go to ‘Debugger’, and then start searching for the control name described in the Manifest file in the search bar. For example, type your control name like ‘Increment Control’.        
      
 
        
> [!NOTE] 
> It's a good practice to set breakpoints on the control’s lifecycle method like init & updateView.

# Reference

## Manifest file reference
The Manifest is an XML file which defines the properties of the custom control in a format that model-driven apps understand. It specifies various aspects of the control including the control's name, version, and dependent resource files. In addition, the manifest defines configurable properties that it expects from model-driven apps.  The following is an example of the manifest for a field control:
```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest>
    <control namespace="SampleNamespace" constructor="TSLinearInputControl" version="1.0.0" display-name-key="TS_LinearInputControl" description-key="TS_LinearInputControl_Desc" control-type="standard">
        <type-group name="numbers">
            <type>Whole.None</type>
            <type>Currency</type>
            <type>FP</type>
            <type>Decimal</type>
        </type-group>
        <property name="controlValue" display-name-key="controlValue_Display_Key" description-key="controlValue_Desc_Key" of-type-group="numbers" usage="bound" required="true" />
        <resources>
            <code path="TS_LinearInputControl.js" order="1" />
            <css path="css/TS_LinearInputControl.css" order="1" />
        </resources>
    </control>
</manifest>
```
The following is an example of the manifest for a data-set control:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<manifest>
  <control namespace="SampleNamespace" constructor="TSDataSetGrid" version="1.0.0" display-name-key="TS_DataSetGrid">
    <data-set name="dataSetGrid" display-name-key="DataSetGridProperty">
      </data-set>
    <resources>
      <code path="TS_DataSetGrid.js" order="1" />
        <css path="css/TS_DataSetGrid.css" order="1" />
      <resx path="strings/TSDataSetGrid.1033.resx" version="1.0.0" />
    </resources>
  </control>
</manifest
```
A manifest file has the following elements:

### control 
```xml
<control namespace="SampleNamespace" constructor="TSLinearInputControl" version="1.0.0" display-name-key="TS_LinearInputControl" description-key="TS_LinearInputControl_Desc" control-type="standard">
```
This defines the control's namespace, constructor, version and display information. 

- The *namespace* and *constructor* attributes identifies the object prototype of the control.        
- The *version*  attribute allows the control to publish various versions of itself over time. This attribute is used by the solution import infrastructure to decide if a control has already been installed, or not. Also, it allows a control to release versions of itself over time that are compatible with previously released versions / configurations.  If version v2 > v1, all the CSS resources will be updated to v2 and vice-versa. The resx and library files will be updated based on the resx version and library versions. 
- *display-name-key* and *description-key* are used in on customization screens as localized keys that describe the name and a description for the control. The key is used to lookup the localized value of the key string. If found in the resx then the localized value is used, else the key is used directly.
- *preview-image* is an image that will be used in the customizations screens to show a preview of the control to the customizer. The ideal size for the image is 170px width and 130px height. If the size of the image is higher than the ideal size, the image is croped to fit the size and vice-versa. This image must be packaged as part of the solution.  

## type-group 
This element allows the control to define a set of types identified by a single name. This typing information can be used to identify the data types supported by a specific property. 
```xml
<type-group name="numbers"> 
 <type>Whole.None</type> 
 <type>Currency</type> 
 <type>FP</type> 
 <type>Decimal</type> 
</type-group> 
```
### property 
This element identifies a specific, configurable piece of data that the control expects from Common Data Service for Apps.  
```xml
<property name="controlValue" display-name-key="controlValue_Display_Key" description-key="controlValue_Desc_Key" of-type-group="numbers" usage="bound" required="true" />
```
- The *name* attribute identifies the unique name of the property to the control.   The *name* value will be used to identify the property during configuration and at run-time.   
- The data type of the property is defined by the *of-type* or *of-type-group* attribute. For a list of supported Common Data Service for Apps data types. More information : Fields and Field Types

Types supported:
	Whole.None
	TwoOptions
	DateAndTime.DateOnly
	DateAndTime.DateAndTime
	Decimal
	Enum
	FP (Floating Point)
	Multiple (Multiple lines of text)
	Currency
	OptionSet
	SingleLine.Email
	SingleLine.Text
	SingleLine.TextArea
	SingleLine.URL
	SingleLine.Ticker
	SingleLine.Phone

- The *usage* attribute identifies if this property is meant to represent a Common Data Service for Apps entity attribute that the control can change (bound) or read-only values (input).  
- The *required* attribute indicates if configuration of the property is required, or not.  
- *display-name-key* and *description-key* are used  on customization screens as localized strings that describe the name and a description for the property. The key is used to lookup the localized value of the key string. If found in the resx then the localized value is used, else the key is used directly.

### data-set 
This element represents a specific, configurable representation of a set of entity records from Common Data Service for Apps. 
 ```xml     
<data-set name="myDataSetGrid" display-name-key="DataSetGridProperty"> 
 </data-set> 
```
- The *name* attribute identifies the unique name of the data-set to the control. The *name* value will be used to identify the data-set during configuration and at run-time. 
- Each *property-set* node represents a unique, configurable property that each record in the dataset must provide.   
•	The remaining attributes (display-name-key, required, description-key, usage, and of-type) follow the same patterns described for the property node. 

### resources
This element contains references to all the webresources that a control requires to construct its visualization.    
```xml
<resources>
<code path="TS_LinearInputControl.js" order="1" />
<css path="css/TS_LinearInputControl.css" order="1" />
</resources>
```
- Library references should refer to external, published libraries that multiple controls from various ISVs rely on. An example would be a UI framework like jQuery. 
- CSS and image references are also meant to be specific to individual controls. 
- The *order* attribute defines the order in which the webresource must load. The webresource with *order =1* will get the higher priority. 
- CSS scoping can be used to restrict the CSS style to specific control and not affecting the entire application. To do this, control should apply CSS scope using both namespace and control constructor. For example,

```css
MyNameSpace\.JSHelloWorldControl .JS_HelloWorldColor{
    	color: red;
}  
in \src\controls\JS_HelloWorldControl\css\JS_HelloWorldControl.css  
```
## Interface reference

Custom controls are implemented as JavaScript classes that implement a specific interface. This interface requires the control to implement certain lifecycle methods that will be called by model-driven apps.

- init(context: Context<TInputs>, notifyOutputChanged?: () => void, state?: KeyValuePair, container?: HTMLDivElement): void;

Used to initialize the control instance. Controls can kick off remote server calls and other initialization actions here. 

Parameters:

context:	Contains all the values about how the controls are configured in the manifest, as well as utility functions and global org and user data (i.e user agent, org date settings, etc).

notifyOutputChanged: A callback method to alert the framework that the control has new outputs ready to be retrieved asynchronously.
state	A piece of data that persists in one session. Can be set at any point in a controls lifecycle by calling “setControlState” in the mode interface.
container:	If a control is marked control-type=”standard”, it will receive an empty div element within which it can render it’s content.

- updateView(context: Context<TInputs>): void;

Used to alert the control if any value has changed. This includes field values, data sets, global values such as container height and width or offline status, or control level values such as label, visible, etc.        

Parameters:
context: Contains values as set up by the customizer mapped to names defined in the manifest, as well as utility functions.

- getOutputs?(): TOutputs;

Called to retrieve the latest outputs from a control. This should always be called prior to a control receiving new data. 
Returns an object based on nomenclature defined in manifest, expecting object for property marked as “bound” or “output”.

- destroy(): void;

Called when the control is to be unmounted from the DOM tree. Controls should use this call for cleanup i.e. cancelling any pending remote calls, unhooking listeners, etc.
