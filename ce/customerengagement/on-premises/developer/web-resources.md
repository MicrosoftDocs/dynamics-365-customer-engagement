---
title: "Web resources for Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Web resources are virtual files that are stored in the Dynamics 365 Customer Engagement database and that you can retrieve by using a unique URL address."
keywords: 
ms.date: 01/24/2025
ms.custom: 
ms.topic: get-started
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8c947e83-6765-41d9-b4b7-c078a68257eb
author: JimDaly
ms.author: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 46
topic-status: Drafting
search.audienceType: 
  - developer

---

# Web resources for Customer Engagement

Web resources are *virtual files* that are stored in the Dynamics 365 Customer Engagement (on-premises) database and that you can retrieve by using a unique URL address.  

<a name="BKMK_CapabilitiesOfWebResources"></a>
## Capabilities of web resources  
 Web resources represent files that can be used to extend the Dynamics 365 Customer Engagement (on-premises) web application such as html files, [!INCLUDE[pn_JScript](../includes/pn-jscript.md)], and CSS, and several image formats. You can use web resources in form customizations, the `SiteMap`, or the application ribbon because they can be referenced by using URL syntax.  

 The URL syntax for web resources allows for relative path references. With your development tools, you can create a group of interdependent files on a development server by using file types compatible with web resources. Then, if you use a consistent naming convention and relative path references, the website will function after you upload all the files into Dynamics 365 Customer Engagement (on-premises).  

 Because web resources are stored in Dynamics 365 Customer Engagement (on-premises) and are solution components, they can be easily exported and installed to on-premises deployments of Dynamics 365 Customer Engagement (on-premises) or to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. Web resources are also available to users of [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] when offline because they are synchronized with the user's data.  

 You can use the form editor to add and configure form-enabled web resources into your entity forms.  

 Because web resources are stored as records in the database, they can be managed programmatically by using the standard techniques to create, retrieve, and update records. Text-based web resources (JScript, CSS, XML, XSL, RESX, and HTML) can be edited and saved in the application.  

<a name="BKMK_LimitationsOfWebResources"></a>
### Limitations of web resources  
 There is no type of web resource that supports the capabilities of an ASP.NET(.aspx) page to execute code on the server. Web resources are limited to static files or files that are processed in the browser. A web resource can contain code that is processed in the browser to execute web service calls to interact with Dynamics 365 Customer Engagement (on-premises) data. For more information, see [Work with Customer Engagement data using web resources](work-data-using-web-resources.md).

 Web resources are only available by using the Dynamics 365 Customer Engagement (on-premises) web application security context. Only licensed Dynamics 365 Customer Engagement (on-premises) users who have the necessary privileges can access them.  

#### Size limitations  
[!INCLUDE[sdk_MaxUploadFileSize](../includes/sdk-maxuploadfilesize.md)]

<a name="BKMK_WebResourceTypes"></a>
## Web resource types  
 You can use ten file formats to create web resources. The following table lists each file format, the allowed file extensions, and the type value that you use for each.  

|                                    File                                     | File extensions | Type |
|-----------------------------------------------------------------------------|-----------------|------|
|                               Webpage (HTML)                                |   .htm, .html   |  1   |
|                              Style Sheet (CSS)                              |      .css       |  2   |
|                              Script (JScript)                               |       .js       |  3   |
|                                 Data (XML)                                  |      .xml       |  4   |
|                                 Image (PNG)                                 |      .png       |  5   |
|                                 Image (JPG)                                 |      .jpg       |  6   |
|                                 Image (GIF)                                 |      .gif       |  7   |
| [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] (XAP) |      .xap       |  8   |
|                              StyleSheet (XSL)                               |   .xsl, .xslt   |  9   |
|                                 Image (ICO)                                 |      .ico       |  10  |
|                             Vector format (SVG)                             |      .svg       |  11  |
|                                String (RESX)                                |      .resx      |  12  |

<a name="BKMK_ReferencingWebResources"></a>
## Reference web resources  
 There are several methods that you can use to reference web resources.  

> [!NOTE]
>
> - When possible, use the `$webresource` directive. Only references that use the `$webresource` directive in the site map or ribbon commands will establish dependencies. Dependencies are not created when web resources reference each other.  
>   - [!INCLUDE[sdk_silverlightwebresourcedirective](../includes/sdk-silverlightwebresourcedirective.md)]  

<a name="BKMK_WebResourceDirective"></a>
### $webresource directive  
 You should always use the `$webresource` directive when referencing a web resource from a ribbon control or from a `SiteMap` sub area. Use the `$webresource` directive anywhere the XML allows a URL value. The following sample shows how to use it.  

```xml  
$webresource:<name of Web Resource>  
```  

> [!NOTE]
> When using the `$webresource` directive, Dynamics 365 Customer Engagement (on-premises) will create or update solution dependencies.  

### Xrm.Navigation.openWebResource  
 The Xrm.Navigation.[openWebResource](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Navigation/openWebResource) function will open an HTML web resource in a new window with parameters to pass the name of the web resource, any query string data to be passed in the data parameter, and information about height and width of the window.  

 The URL generated includes the unique GUID token so that the cached web resource will be loaded.  

<a name="BKMK_RelativeUrl"></a>
### Relative URL  
 When referencing a web resource from areas that do not support using the `$webresource:` directive, a relative URL can be used. To enable this, we recommend that you use a consistent naming convention for the web resources that reflect a virtual file structure. The solution publisher’s customization prefix will always be included as a prefix to the name of the web resource. This can represent a virtual ”root” folder for all web resources added by that publisher. You can then use the forward slash character (/) to simulate a folder structure that will be honored by the web server.  

 From another web resource, you should always use relative URLs to reference each other. For example, for the web page web resource `new_/content/contentpage.htm` to reference the CSS web resource `new_/Styles/styles.css`, create the link as follows:  

```html  
<link rel="stylesheet" type="text/css" href="../styles/styles.css" />  
```  

 For the web page web resource `new_/content/contentpage.htm` to open the webpage web resource `isv_/foldername/dialogpage.htm`, create the link as follows:  

```html  
<a href="../../isv_/foldername/dialogpage.htm">Dialog Page</a>  
```  

> [!NOTE]
> Do not use a relative URL using the WebResources folder as the root path for the URL. For example, do not use this: `/WebResources/<name of web resource>`. When a user belongs to more than one organization on a server, this path will always refer to the users default organization. If the user is not using their default organization and the expected web resource is not included in the user’s default organization, a “File Not Found” error occurs even though the web resource does occur in the organization the user is currently working in.  

<a name="BKMK_FullUrl"></a>
### Full URL  
 The following sample shows the style of URL you can use to view web resources.  

```  
<Microsoft CRM URL>/WebResources/<name of web resource>  
```  

 The application will process this URL and return the file that contains the latest version of the web resource. This URL will look like this:  

```  
<Microsoft CRM URL>/%7B<version value>%7D/WebResources/<name of web resource>  
```  

 The version value is updated when you publish customizations and ensures that the browser uses the latest cached version of the web resource. Because of this, use a relative path to a web resource, the Xrm.Navigation.[openWebResource](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Navigation/openWebResource) function, or the [$webresource Directive](web-resources.md#BKMK_WebResourceDirective) (when possible) because the version value will automatically be included. For large web resources there can be significant performance implications if you don’t use the cached version of the file.  

 The following sample shows a URL for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], where `MyOrganization` is the name of your organization, and `new_/test/test.htm` is the name of the web resource:  

```  
https://MyOrganization.crm.dynamics.com/WebResources/new_/test/test.htm  
```  

> [!NOTE]
> Including the ‘/’ character and a file name extension in the name of the web resource is an optional best practice.  

 The following sample shows a URL for on–premises Dynamics 365 Customer Engagement (on-premises), where `myServer` is the server name:  

```  
https://myServer/MyOrganization/WebResources/new_/test/test.htm  
```  

 When you write code to reference a web resource that will need to work for either [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] or on–premises Dynamics 365 Customer Engagement (on-premises), you should use the [getClientUrl](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Utility/getGlobalContext/getClientUrl) function.

## Community tools

Here are some of the community tools that work with web resources.

|Tool name|More information|
|--|--|
|WebResourceManager|[https://github.com/gotdibbs/WebResourceManager](https://github.com/gotdibbs/WebResourceManager)|
|XrmToolkit|[https://xrmtoolkit.com/Home/Features](https://xrmtoolkit.com/Home/Features)|
|WebResources Manager|[https://www.xrmtoolbox.com/plugins/MsCrmTools.WebResourcesManager/](https://www.xrmtoolbox.com/plugins/MsCrmTools.WebResourcesManager/)|

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and Microsoft does not extend support to the community tools.
> If you have questions pertaining to a tool, please contact the tool's publisher.

### See also  
 [Write Client Application Extensions for Dynamics 365 Customer Engagement](extend-client.md)<br />
 [Create Accessible Web Resources](create-accessible-web-resources.md)<br />
 [Web Page (HTML) Web Resources](webpage-html-web-resources.md)<br />
 [Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)<br />
 [Script (JScript) Web Resources](script-jscript-web-resources.md)<br />
 [Image Web Resources](image-web-resources.md)<br />
 [Stylesheet (XSL) Web Resources](stylesheet-xsl-web-resources.md)<br />
 [Data (XML) Web Resources](data-xml-web-resources.md)<br />
 [Style Sheet (CSS) Web Resources](css-web-resources.md)<br />
 [Web Resource Messages and Methods](webresource-entity-messages-methods.md)<br />
 [Sample: Passing Multiple Values to a Web Resource Through the Data Parameter](sample-pass-multiple-values-web-resource-through-data-parameter.md)<br />
 [Sample: Importing Files as Web Resources](sample-import-files-web-resources.md)<br />
 [Use Web Service Data in Web Resources](work-data-using-web-resources.md)<br />
 [Streamline web resource development using Fiddler AutoResponder](streamline-javascript-development-fiddler-autoresponder.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
