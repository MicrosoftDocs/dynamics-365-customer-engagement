---
title: "Use JavaScript with Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This topic helps you explore various opportunities that Dynamics 365 Customer Engagement provides to use JavaScript. You can use JavaScript to perform actions in form scripts, command bar (ribbon) commands, and web resources."
ms.custom: 
ms.date: 06/24/2019
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b7840a25-f25e-409b-8b6a-0ef04c7ed9c4
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Use JavaScript with Customer Engagement (on-premises)

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] provide many opportunities to use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]. All [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] used in Dynamics 365 Customer Engagement (on-premises) is added by creating [!INCLUDE[pn_JScript](../includes/pn-jscript.md)] web resources. This topic has information for developers who use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] and includes links to relevant topics in the [!INCLUDE [pn-sdk](../includes/pn-sdk.md)] and other sources.  
  
<a name="BKMK_AreasToUseJavaScript"></a>   

## Areas where you can use JavaScript in Dynamics 365 Customer Engagement (on-premises)
 
 You can use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] to perform actions in form scripts, command bar (ribbon) commands, and web resources.  
  
<a name="bkmk_FormScripts"></a>   

### Form scripts  

 The most common use of [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] in Dynamics 365 Customer Engagement (on-premises) is to add functions as event handlers for entity form events. For more information, see [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md).  
  
<a name="bkmk_commandBar"></a>   

### Command bar (ribbon) commands  

 When you customize the Dynamics 365 Customer Engagement (on-premises) command bar, you can configure commands for controls that you add. These commands contain rules that control whether the control is enabled and what action is performed when the control is used. For more information, see [Customize commands and the ribbon](../developer/customize-dev/customize-commands-ribbon.md).  
  
<a name="bkmk_webResources"></a>   

### Web resources  

 Dynamics 365 Customer Engagement (on-premises) provides an organization-owned entity that stores a binary representation of a file that can be accessed by using a URL. This file is called a web resource. There are several types of web resources. A web resource that represents a [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] library is called a [!INCLUDE[pn_JScript](../includes/pn-jscript.md)] web resource. You can use a webpage (HTML) web resource to provide a user interface with [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries included just as you would for files on a web server. Because these files are part of Dynamics 365 Customer Engagement (on-premises), users who access them are already authenticated. Therefore, you can use Dynamics 365 Customer Engagement (on-premises) web services without having to write code to authenticate the user. For more information, see [Web Resources for Dynamics 365 Customer Engagement](web-resources.md) and [Work with Dynamics 365 Customer Engagement data using web resources](work-data-using-web-resources.md).  
  
<a name="BKMK_UsingjQuery"></a>   

## Use of jQuery  

 **Use jQuery with HTML web resources**  
 We recommend that you use jQuery together with HTML web resources to provide user interfaces because it is an excellent cross-browser library.  
  
 With HTML web resources, you control the libraries that are present and there is no restriction against manipulating the DOM. Feel free to use jQuery within your HTML Web resources.  
 
 > [!NOTE]
 > If the script reference to [ClientGlobalContext.js.aspx](/dynamics365/customer-engagement/developer/clientapi/reference/getglobalcontext-clientglobalcontext.js.aspx
) is placed after your own jQuery reference, the ClientGlobalContext.js.aspx scripts will overwrite your previously loaded version of jQuery. To avoid this, place the ClientGlobalContext.js.aspx script reference prior to any other script references in your web resource.
  
 
  
<a name="BKMK_WriteJavaScriptForMutlipleBrowsers"></a>
   
## Write JavaScript for multiple browsers  

 Because you don’t know what browser will be in use, you should make sure that any scripts that you use will work with all supported browsers. Most of the significant differences between [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] and other browser have to do with HTML and XML DOM manipulation. Because HTML DOM manipulation is not supported, if script logic is only performing supported actions and using the [Client API](/powerapps/developer/model-driven-apps/clientapi/understand-clientapi-object-model), the changes required to support other browsers could be small.  
  
 A cross-browser library like jQuery is a good solution for developing web resources but should not be necessary for form scripts or ribbon commands. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Avoid using jQuery for form scripts](/powerapps/developer/model-driven-apps/clientapi/client-scripting-best-practices#avoid-using-jquery-for-form-scripts)   
 
  
<a name="BKMK_JavaScriptBestPractices"></a>  
 
## JavaScript programming best practices  

 The following sections describe best practices when you use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] with Dynamics 365 Customer Engagement (on-premises).  
  
<a name="bkmk_avoidUnsupportedMethods"></a> 
  
### Avoid using unsupported methods  

 On the Internet, you can find many examples or suggestions that describe using unsupported methods. These may include leveraging undocumented internal function for page controls. These methods may work but because they are not supported you can’t expect that they will continue to work in future versions of Dynamics 365 Customer Engagement (on-premises).  
 
  
<a name="bkmk_useJavaScriptFramework"></a>

### Use a cross-browser JavaScript library for HTML web resource user interfaces  
 A cross-browser [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] library, such as [jQuery](https://jquery.com/), provides many advantages when developing HTML web resources that must support multiple browsers. [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries like jQuery provide a unified development experience for all browsers supported by Dynamics 365 Customer Engagement (on-premises). These capabilities are appropriate when you are using HTML web resources to provide user interfaces. [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries like jQuery provide consistent ways to interact with the Document Object Model (DOM).  
  
<a name="bkmk_nojQuery"></a>
 
### Do not use jQuery for form script or commands
 
 We do not recommend or support using jQuery for any pages within the application. This includes form scripts and ribbon commands. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use of jQuery](use-javascript.md#BKMK_UsingjQuery).  
  
<a name="bkmk_CDNLimitations"></a>

### Recognize limitations for content delivery network (CDN) libraries

 Content delivery network (CDN) [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries provide many advantages for public websites. Because these libraries are hosted on the Internet, you do not need to create web resources that contain the content of the libraries. For Dynamics 365 Customer Engagement (on-premises) you should consider the following issues before you use a CDN [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] library.  
  
- Users of the [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] client have the capability to work with no Internet connection while working offline. If you are depending on an Internet connection for your [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries, your code will fail.  
  
- Some organizations will restrict Internet access for employees. Unless they configure the network to allow access to the CDN library sites, your code may fail for those organizations.  
  
  The alternative to using CDN libraries is to create a script ([!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]) web resource with the contents of the library. Because web resources are organization-owned entities they will be synchronized when a [!INCLUDE[pn-oc-online-short](../includes/pn-oc-online-short.md)] with Offline Access user goes offline. Because these web resources now become part of the application they will not be blocked if an organization restricts access to the Internet.  
  
<a name="bkmk_useFeatureDetection"></a>

### Use feature detection when writing functions for multiple browsers

 Even when you use a cross-browser library like jQuery, you need to be very aware of differences between browsers. You can generally detect which browser is being used by querying the `navigator.useragent` property. This is called browser detection. Browser detection is not a good strategy for most cases because it can’t take into account what features newer versions of a browser have. Also, some browsers provide the capability to modify the `navigation.useragent` property so that they appear to be a different browser.  
  
 Feature detection is the recommended approach. By detecting what features are available, you can create code paths for the browsers you support without knowing exactly which browser is being used. For more information about feature detection, see [How to Detect Features Instead of Browsers](https://msdn.microsoft.com/library/hh273397\(VS.85\).aspx).  
  
<a name="bkmk_DoNotAccessDOM"></a>
 
### Do not access the DOM

 [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developers are used to interacting with Document Object Model (DOM) elements in code. You might use the `window.getElementById` method or the jQuery library. You are free to use these techniques in your HTML web resources, but they are not supported to access elements in Dynamics 365 Customer Engagement (on-premises) application pages or entity forms. Instead, access to entity form elements are exposed through the [Client API object model](/powerapps/developer/model-driven-apps/clientapi/understand-clientapi-object-model). The Dynamics 365 Customer Engagement (on-premises) development team reserves the right to change how pages are composed, including the `ID` values for elements, so using the [Client API object model](/powerapps/developer/model-driven-apps/clientapi/understand-clientapi-object-model) protects your code from changes in how pages are implemented.  
  
<a name="bkmk_DefineUniqueNames"></a>
  
### Define unique names for your JavaScript functions

 When you are the only developer for an HTML page you can easily manage the names of the [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions you use. In Dynamics 365 Customer Engagement (on-premises), other solutions may add [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions to the page where your function is used.  
  
 If two [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions on a page have the same name, the first function defined is overwritten by the second. For this reason, make sure that you define unique names for your [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions. For more information, see [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md).  
  
<a name="bkmk_useasynchronous"></a>

### Use asynchronous data access methods

 When you access data by using the Dynamics 365 Customer Engagement (on-premises) web services, always use an [XMLHttpRequest](https://msdn.microsoft.com/library/ms535874\(VS.85\).aspx) that is configured to execute asynchronously. The reason is that the browser operates on a single thread. If that thread is being used to execute a long-running process synchronously the browser will stop responding.  
  
> [!NOTE]
>  Synchronous XMLHttpRequests are deprecated on the main thread of the browser because of the detrimental effects to the end user’s experience. Some browsers now provide a warning when this is detected. If browsers implement the specification at some time in the future an InvalidAccessError exception will be thrown. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [https://www.w3.org/TR/XMLHttpRequest/#synchronous-flag](https://www.w3.org/TR/XMLHttpRequest/) and [https://xhr.spec.whatwg.org/#the-open()-method](https://xhr.spec.whatwg.org/)  
  
  
  
### See also

 [Write Client Application Extensions](extend-client.md)<br />
 [Work with Customer Engagement data using web resources](work-data-using-web-resources.md)<br />
 [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)<br />
 [Customize the Ribbon for Dynamics 365 Customer Engagement (on-premises)](customize-dev/customize-commands-ribbon.md)<br />
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)<br />
 <!--[Use the Web API with web resources](/powerapps/developer/model-driven-apps/clientapi/get-started-web-api-client-side-javascript)<br />-->
 [Understand the Client API Object Model](/powerapps/developer/model-driven-apps/clientapi/understand-clientapi-object-model)<br />
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]