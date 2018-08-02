---
title: "Use IFRAME and web resource controls on a form | MicrosoftDocs"
ms.custom: ""
ms.date: 04/18/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1d1b53cb-bfee-4fba-9bea-ea9e6e31309d
author: "JimDaly"
ms.author: "jdaly"
manager: "faisalmo"
---
# Use IFRAME and web resource controls on a form

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

IFRAME and web resource controls embed content from another location in pages by using an HTML IFRAME element.  

> [!NOTE]
>  The designs you choose for the form are also used for the [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] reading pane and forms used by [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)]. Web resources and IFRAMEs aren’t displayed using the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] reading pane, however, they are supported in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. If your IFRAME depends on access to the `Xrm` object of the page or any form event handlers, you should configure the IFRAME so that it's not visible by default.  

 You can use an IFRAME to display the contents from another website in a form, for example, in an [!INCLUDE[pn_ASP.NET_short](../includes/pn-asp-net-short.md)] page. Displaying an entity form within an IFrame embedded in another entity form is not supported.  

 You can use one of the following web resources to display the contents of web resources in a form:  

-   [Web Page (HTML) Web Resources](webpage-html-web-resources.md)  

-   [Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)  

-   [Image (JPG, PNG, GIF, ICO) Web Resources](image-web-resources.md)  

> [!NOTE]
> [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] is included for backward compatibility only and is not recommended. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)  

 The following sections describe your options if you want these controls to show more than static content.  

<a name="BKMK_IframeSecurity"></a>   
## Select whether to restrict cross-frame scripting  
 Use the **Restrict cross-frame scripting, where supported** option when you don’t fully trust the content displayed in an IFRAME. When this option is selected, the IFRAME has the attributes set that are listed in the following table.  


|        Attribute        |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|-------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `security="restricted"` |                                                                                                                                                                                                                                                                                                    This attribute is supported only by versions of [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] no earlier than version 6. The security attribute applies the user security setting Restricted Sites to the source file of the IFRAME. (Zone settings are found on the **Security** tab of the **Internet Options** dialog box.) By default, scripting isn’t enabled in the Restricted Sites zone. By changing the security settings of the zone, various negative results can occur, including allowing scripts to run. For more information, see [security attribute](https://msdn.microsoft.com/library/ie/ms534622.aspx).                                                                                                                                                                                                                                                                                                     |
|      `sandbox=""`       | For browsers that support this attribute, the content in the IFRAME is essentially limited to only displaying information. The following restrictions could be applied:<br /><br /> -   Browser plug-ins are disabled.<br />-   Forms and scripts are disabled.<br />-   Links to other browsing contexts are disabled.<br />-   Content is treated as from a different domain even if the domain is the same.<br /><br /> This attribute is defined by W3C and is supported by the following browsers:<br /><br /> - [!INCLUDE[pn_IE_10](../includes/pn-ie-10.md)], [!INCLUDE[pn_ie_11](../includes/pn-ie-11.md)], and [!INCLUDE[pn_microsoft_edge](../includes/pn-microsoft-edge.md)]<br />- [!INCLUDE[tn_Google_Chrome](../includes/tn-google-chrome.md)]<br />- [!INCLUDE[tn_Apple_Safari](../includes/tn-apple-safari.md)]<br />- [!INCLUDE[tn_Mozilla_Firefox](../includes/tn-mozilla-firefox.md)]<br /><br /> For more information about the sandbox attribute see:<br /><br /> -   [How to Safeguard your Site with HTML5 Sandbox](https://msdn.microsoft.com/hh563496)<br />-   [WC3 Sandbox attribute](http://dev.w3.org/html5/spec-author-view/the-iframe-element.html)<br />-   [Sandbox](https://msdn.microsoft.com/library/ie/hh673561.aspx) |

<a name="BKMK_EnableIFrameCommunicationAccrossDomains"></a>   

### Enabling IFrame communication across domains  
 There are times when you want to enable communication for an IFRAME that contains content on a different domain. `Window.postMessage` is a browser method that provides this capability for versions of [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] no earlier than [!INCLUDE[pn_IE_8](../includes/pn-ie-8.md)]. [!INCLUDE[tn_Google_Chrome](../includes/tn-google-chrome.md)], [!INCLUDE[tn_Mozilla_Firefox](../includes/tn-mozilla-firefox.md)], and [!INCLUDE[tn_Apple_Safari](../includes/tn-apple-safari.md)] also support it. For more information about using `postMessage`, see the following blog posts:  

-   [Cross domain calls to the parent CRM 2011 form](http://blogs.msdn.com/b/devkeydet/archive/2012/02/14/cross-domain-calls-to-the-parent-crm-2011-form.aspx)  

-   [Cross-Document Messaging and RPC](https://msdn.microsoft.com/magazine/ff800814.aspx)  

<a name="BKMK_PassContextualInformation"></a>   

## Pass contextual information about the record  
 You can provide contextual information by passing parameters to the URL defined in the control. The page that is displayed in the frame must be able to process parameters passed to it. All the parameters in the following table are passed if the IFRAME or web resource is configured by using the **Pass record object-type code and unique identifier as parameters** option.  

 You can specify whether all the parameters in the following table will be passed.  


| Parameter  |        Name        |                                 Description                                 |
|------------|--------------------|-----------------------------------------------------------------------------|
| `typename` |    Entity Name     |                           The name of the entity.                           |
|   `type`   |  Entity Type Code  | The integer that uniquely identifies the entity in a specific organization. |
|    `id`    |    Object GUID     |                      A GUID that represents a record.                       |
| `orgname`  | Organization Name  |                    The unique name of the organization.                     |
| `userlcid` | User Language Code |    The language code identifier that is being used by the current user.     |

 [!INCLUDE[languagecode](../includes/languagecode.md)]  

> [!NOTE]
>  We suggest that you use the entity name instead of the type code because the entity type code for custom entities may be different between [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organizations.  

### Example  
 The following sample shows the URL without parameters.  

```  
http://myserver/mypage.aspx  
```  

 The following sample shows the URL with parameters.  

```  
http://myserver/mypage.aspx?id=%7bB2232821-A775-DF11-8DD1-00155DBA3809%7d&orglcid=1033&orgname=adventureworkscycle&type=1&typename=account&userlcid=1033  
```  

### Read passed parameters  

 Passed parameters are typically read in the target .aspx page by using the **HttpRequest.QueryString** property. In an HTML page, the parameters can be accessed by using the **window.location.search** property in [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]. For more information, see [HttpRequest.QueryString Property](http://msdn2.microsoft.com/library/system.web.httprequest.querystring.aspx) and [search Property](http://msdn2.microsoft.com/library/ms534620.aspx).  

<a name="BKMK_PassFormData"></a>  

## Pass form data  

 Use the [getValue](clientapi/reference/controls/getValue.md) method on the attributes that contain the data that you want to pass to the other website, and compose a string of the query string arguments the other page will be able to use. Then use a [Field OnChange Event](clientapi/reference/events/attribute-onchange.md), [IFRAME OnReadyStateComplete Event](clientapi/reference/events/onreadystatecomplete.md), or [Tab TabStateChange Event](clientapi/reference/events/tabstatechange.md) and the [setSrc](clientapi/reference/controls/setSrc.md) method to append your parameters to the `src` property of the IFRAME or web resource.  

 If you’re using the data parameter to pass data to a [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource, you can use the [getData](clientapi/reference/controls/getData.md) and [setData](clientapi/reference/controls/setData.md) methods to manipulate the value passed via the data parameter. For webpage (HTML) web resources, use the [setSrc](clientapi/reference/controls/setSrc.md) method to manipulate the `querystring` parameter directly.  

 Avoid using the [OnLoad Event](clientapi/reference/events/form-onload.md). IFRAMES and web resources load asynchronously and the frame may not have finished loading before the `Onload` event script finishes. This can cause the `src` property of the IFRAME or web resource you have changed to be overwritten by the default value of the IFRAME or web resource URL property.  

<a name="BKMK_ChangeThePage"></a>   

## Change the URL  

 You may want to change the target of the IFRAME based on such considerations as the data in the form or whether the user is working offline. You can set the target of the IFRAME dynamically.  

> [!NOTE]
>  When you change the target page for the IFRAME, parameters aren’t passed to the new URL automatically. You must append the query string parameters to the URL before you use the `setSrc` method.  

### Example  

 The following sample shows you how to set the `src` property for the IFRAME and any parameters by using the `onChange` event of an option set field.  

```javascript  
//Get the value of an option set attribute  
var value = Xrm.Page.data.entity.attributes.get("new_pagechooser").getValue();  
var newTarget = "";  
//Set the target based on the value of the option set  
switch (value) {  
    case 100000001:  
        newTarget = "http://myServer/test/pageOne.aspx";  
        break;  
    default:  
        newTarget = "http://myServer/test/pageTwo.aspx";  
        break;  
}  
//Get the default URL for the IFRAME, which includes the   
// query string parameters  
var IFrame = Xrm.Page.ui.controls.get("IFRAME_test");  
var Url = IFrame.getSrc();  
// Capture the parameters  
var params = Url.substr(Url.indexOf("?"));  
//Append the parameters to the new page URL  
newTarget = newTarget + params;  
// Use the setSrc method so that the IFRAME uses the  
// new page with the existing parameters  
IFrame.setSrc(newTarget);  
```  

## See Also  

 [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md)   
 [Use JavaScript with Customer Engagement](use-javascript.md)   

