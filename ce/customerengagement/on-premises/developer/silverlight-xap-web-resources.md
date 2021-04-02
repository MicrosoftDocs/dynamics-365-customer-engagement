---
title: "Silverlight (XAP) web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about creating and adding Silverlight 4.0 web resources to entity forms. You can display Silverlight 5.0 web resources within an HTML web resource using a hosting <object> element that is configured for that version."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 982189a4-93a9-44ee-99e0-7b8d85318cf4
author: JimDaly
ms.author: jdaly
manager: amyla
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
search.audienceType: 
  - developer
---

# Silverlight (XAP) web resources

> [!IMPORTANT]
> [!INCLUDE [pn-ms-silverlight-full](../includes/pn-ms-silverlight-full.md)] web resources are deprecated in [!INCLUDE[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)].
>  HTML5 is the preferred client technology for the web, over web plug-ins like Silverlight and Flash. HTML5 can be consumed from any device (PC, tablet, smartphone, and more) and heavily uses JavaScript (and many powerful JavaScript libraries, such as jQuery) and CSS. 
> 
> [!INCLUDE [pn-ms-silverlight-full](../includes/pn-ms-silverlight-full.md)] web resources remain supported in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] for backwards compatibility in the web application only. [!INCLUDE[pn_MS_Silverlight_full](../includes/pn-ms-silverlight-full.md)] will not work for the Unified Interface.  For components that will be able to be presented on all clients, we recommend using HTML web resources with HTML5 instead of [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)].  

  
 [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] support adding [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] 4.0 web resources to entity forms. You can display [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] 5.0 web resources within an HTML web resource using a hosting `<object>` element that is configured for that version.  
  
> [!NOTE]
> - [!INCLUDE [pn-ms-silverlight-full](../includes/pn-ms-silverlight-full.md)] web resources cannot be viewed in the 64-bit version of [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)].  
>   - [!INCLUDE[sdk_silverlightwebresourcedirective](../includes/sdk-silverlightwebresourcedirective.md)]  
  
<a name="BKMK_CreatingSilverlightWebResource"></a>   
## Creating Silverlight web resources  
 [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resources are easily created using the web resource form by entering a name, a display name, selecting **Silverlight (XAP)** as the type, and uploading the .xap file. The web resource must be published before you can use it. However, because [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resources typically provide some interaction with contextual data in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you should plan how you create your web resources.  
  
<a name="BKMK_AccessingContextData"></a>   
## Accessing context data  
 When you use the **Preview** button in the web resources form or just browse to the URL provided, the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application is hosted in a generic HTML page without context information. If your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application does not require contextual information, you can use this URL to view your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource.  
  
 If you do require contextual information, you must either:  
  
1. Add your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource to an entity form.  
  
2. View your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource using an HTML web resource configured to provide context information.  
  
   If your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource is designed to be viewed in an entity form, the form has an `Xrm.Page.context` object you can use to access contextual information. For more information, see [Client-side context (client-side reference)](/previous-versions/dynamicscrm-2016/developers-guide/gg334511(v=crm.8))  
  
   If you need your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application to appear outside the context of the form you must configure an HTML web resource to provide this context information by adding a reference to the [ClientGlobalContext.js.aspx](/previous-versions/dynamicscrm-2016/developers-guide/gg328541(v=crm.8)#BKMK_ClientGlobalContext_js_aspx).md#BKMK_ClientGlobalContext_js_aspx) page. After this reference is added, your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application can access contextual information in the same way it can in an entity form. The following sample shows how to call the [getClientUrl](/previous-versions/dynamicscrm-2016/developers-guide/gg334511(v=crm.8)#BKMK_getclienturl) function.
  
```csharp  
private string clientUrl = "";  
ScriptObject xrm = (ScriptObject)HtmlPage.Window.GetProperty("Xrm");  
ScriptObject page = (ScriptObject)xrm.GetProperty("Page");  
ScriptObject pageContext = (ScriptObject)page.GetProperty("context");  
clientUrl = (string)pageContext.Invoke("getClientUrl");  
```  
  
<a name="BKMK_PassingData"></a>   
## Passing data from a form to an embedded Silverlight web resource  
 When you add a [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource to a form you can select the **Pass record object-type code and unique identifier as parameters** option. You also have the option to enter text as a custom parameter.  
  
 These values are passed to the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] control as a [InitParams](https://msdn.microsoft.com/library/system.windows.interop.silverlighthost.initparams\(VS.95\).aspx), a dictionary of key/value pairs.  
  
 The values passed are described in the following table.  
  
|Key|Description|  
|---------|-----------------|  
|id|The unique identifier of the record.|  
|type|The entity type code. For custom entities this can vary between organizations.|  
|typename|The logical name of the entity.|  
|orgname|The name of the organization.|  
|userlcid|The language code representing the user’s language preference.|  
|orglcid|The language code representing the organization’s base language.|  
|data|The value of the text entered as a custom parameter.|  
  
 These values can be accessed at run time using the syntax in the following example:  
  
```csharp  
string entityTypeName = App.Current.Host.InitParams["typename"];  
```  
  
<a name="BKMK_WritingandTestingSilverlightWebResources"></a>   
## Writing and testing Silverlight web resources  
 If your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource is independent of any contextual data from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can write and test your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application as you typically would. After you create a new web resource by uploading your .xap file, you can test it by using the **Preview** button in the web resource form after you have saved and published the web resource.  
  
 However, it is more likely that your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application has contextual data dependencies that cannot be fully simulated outside of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 The process of creating a [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource that includes form or context dependencies is as follows:  
  
1. Create your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application project.  
  
    You should select to create a web application with your project.  
  
2. Write and test as much of the application as you can without requiring contextual data from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
3. Create web resources by uploading the .xap and .htm files as [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] and HTML web resources.  
  
4. Write code in your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application project.  
  
5. Build your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application project.  
  
6. Upload the built version of the .xap file from the web application project ClientBin folder to update the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource you created in step 3.  
  
7. Test your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource by either:  
  
   - Viewing it using the **Preview** button of the host HTML web resource you created.  
  
   - Viewing it in the context of an entity form that you have added it to.  
  
      Use this option is your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application has dependencies on Form elements or context information.  
  
8. Repeat steps 4 through 7 until you are finished.  
  
> [!NOTE]
>  When you want to show a [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource outside of an entity form, for example in the application main frame by editing the Site Map, you must provide a webpage (HTML) web resource to act as the host for the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource.  
> 
> [!IMPORTANT]
>  Never edit the HTML source code for a page hosting a [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource using the text editor provided in the application. The text editor changes the HTML and breaks `<object>` element definition necessary to host the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)]XAP web resource. For more information, see [Using the Text Editor for HTML Web Resources](webpage-html-web-resources.md#BKMK_UsingTextEditor).  
> 
>  If you must use the text editor, omit the `data="data:application/x-silverlight-2,"` parameter in the `<object>` element. Although this should prevent breaking the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource, the text editor may still introduce other undesirable changes.  
  
<a name="BKMK_DebuggingSilverlightWebResources"></a>   
## Debugging Silverlight web resources  
 [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resources that do not rely on contextual data from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] can be debugged in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. However, if the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource requires contextual data to perform the functions, you will have to use a different procedure.  
  
1. Build your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application.  
  
2. Upload the built version of the .xap file from the web application project ClientBin folder.  
  
3. View your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application in the context it is designed to be used in.  
  
4. In your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application project, from the [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] menu, select **Debug** and then **Attach To Process**.  
  
5. In the **Attach to Process** dialog box, find an **iexplore.exe** process where the **Type** column value is **Silverlight, x86**.  
  
6. Select that process and press **Attach** to close the dialog box and start debugging.  
  
7. In your [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application project, set a breakpoint.  
  
8. Refresh the browser window or, in the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] application, perform the action that you need to test your code.  
  
### See also  
 [Create Accessible Web Resources](create-accessible-web-resources.md)   
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)   
 [Using Web Page (HTML) Web Resources](webpage-html-web-resources.md)   
 [Using Style Sheet (CSS) Web Resources](css-web-resources.md)   
 [Using Script (JScript) Web Resources](script-jscript-web-resources.md)   
 [Using Data (XML) Web Resources](data-xml-web-resources.md)   
 [Using Image (JPG, PNG, GIF) Web Resources](image-web-resources.md)   
 [Using Stylesheet (XSL) Web Resources](stylesheet-xsl-web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
