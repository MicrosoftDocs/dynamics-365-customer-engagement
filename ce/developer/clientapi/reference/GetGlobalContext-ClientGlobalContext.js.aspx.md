---
title: "GetGlobalContext function and ClientGlobalContext.js.aspx in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 01/22/2018
ms.service: "crm-online"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b58e6173-e3cd-4a3b-b39a-334c295503ec
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# GetGlobalContext function and ClientGlobalContext.js.aspx (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

Use the **GetGlobalContext** function when programming with [web resources](../../web-resources.md) to gain access to the global context information such as the information specific to the client, organization or user for your Customer Engagement instance. 

To get access to the **GetGlobalContext** function in your HTML web resource, include a reference to **ClientGlobalContext.js.aspx**.

## GetGlobalContext function

The **GetGlobalContext** function returns the same context object as returned by the **Xrm.Utility.getGlobalContext** method, which implies that the context object will have the same properties and methods as available for **Xrm.Utility.getGlobalContext**. More information: Xrm.Utility.[getGlobalContext](Xrm-Utility/getGlobalContext.md)

## ClientGlobalContext.js.aspx

You must include a reference to the **ClientGlobalContext.js.aspx** page located at the root of the web resources directory to be able to use the **GetGlobalContext** function.

- If you are not using backslash characters in HTML web resource names to simulate a folder structure, you can include this script by directly referring to it. For example:

    ```HTML
    <head>
      <title>HTML Web Resource</title>
      <script src="ClientGlobalContext.js.aspx" type="text/javascript" ></script>
      
    </head>
    ```
- If you are using backslash characters in HTML web resource names to simulate a directory structure, you must reflect this in your script element. The following example is for an HTML web resource named **sdk_/Contoso.htm** and a JavaScript web resource named **sdk_/Scripts/ContosoScript.js** with a CSS web resource named **sdk_/Styles/ContosoStyles.css**.

    ```HTML
    <head>
      <title>HTML Web Resource</title>
      <script src="../ClientGlobalContext.js.aspx" type="text/javascript" ></script>

      <script src="Scripts/ContosoScript.js" type="text/javascript"></script>
      <link href="Styles/ContosoStyles.css" rel="stylesheet" type="text/css" />
    </head>

    ```

> [!NOTE]
> Using a relative path including the root WebResources folder, for example, /WebResources/ClientGlobalContext.js.aspx, is not recommended because it can cause the page to lose organization context in a multi-tenant environment.

The **ClientGlobalContext.js.aspx** page will include some global event handlers. These event handlers will cancel the [onselectstart](https://developer.mozilla.org/en-US/docs/Web/Events/selectstart), [contextmenu](https://developer.mozilla.org/en-US/docs/Web/Events/contextmenu), and [ondragstart](https://developer.mozilla.org/en-US/docs/Web/Events/dragstart) events. 

> [!NOTE]
> HTML5 introduced a new feature "Content Editable", which allows to edit the content of an element just by clicking on it and typing.
> Loading ClientGlobalContext onto your page may lead to issues when using HTML5 ContentEditable elements, where you can't properly select and edit the content. This is due to the context registering to global events, as described above.
> Example: 
> ```HTML
> <html>
>   <body>
>     <!-- Uncomment below loading of ClientGlobalContext, the div content will not be editable anymore
>       <script src="ClientGlobalContext.js.aspx" type="text/javascript"></script>
>     -->
>     <div contenteditable />
>   </body>
> </html>
> ```


### Related topics

[Xrm.Utility.getGlobalContext](Xrm-Utility/getGlobalContext.md)

[Understand Client API object model](../understand-clientapi-object-model.md) 

[Web resources for Customer Engagement](../../web-resources.md)

