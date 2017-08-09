---
title: "Create and edit web resources in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ef4ba8df-9ba9-4066-b40d-def9761c7de2
caps.latest.revision: 21
ms.author: "rdubois"
manager: "brycho"
---
# Create and edit web resources to extend the web application
Web resources are typically used by developers to extend the web application using files that are used in web development. As a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user you may need to manage web resources provided by a developer or designer.  
   
<a name="BKMK_WhatAreWebResources"></a>   
## What are web resources?  
 Web resources are virtual files stored in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database. Each web resource has a unique name that can be used in a URL to retrieve the file. Think of them this way: If you had access to the actual web server running the web application, you could copy files over to that website. But with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] you can’t do this.  Instead, you can use web resources to upload files to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database and then reference them by name just as though you had copied them as files to the web server.  
  
 For example, if you create an HTML page as a web resource named “new_myWebResource.htm”, you could open that page in a browser using a URL like this:  
  
```  
  
<Microsoft CRM URL>/WebResources/new_myWebResource.htm  
```  
  
 where *\<Microsoft Dynamics 365 URL>* is the URL you usually use to open [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Because the web resource is data in the system, only licensed users for your organization can access them this way. Normally, web resources are included in forms rather than referenced directly. The most common usage is to provide [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries for form scripts.  
  
> [!NOTE]
>  You can’t include a web resource in a form header or footer.  
  
 Because web resources are data in the system and are solution aware, you can move them to different organizations by exporting them as part of a solution and importing the solution into a different organization.  
  
 Web resources are limited to specific types of files. Web resources can only be files that would be loaded into a web browser. The following types of files can be used to create web resources:  
  
|Type|File name extension|  
|----------|-------------------------|  
|Webpage (HTML)|.htm, .html|  
|Style Sheet (CSS)|.css|  
|Script (Jscript, [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)])|.js|  
|Data (XML)|.xml|  
|Image (PNG)|.png|  
|Image (JPG)|.jpg|  
|Image (GIF)|.gif|  
|Silverlight (XAP)|.xap|  
|StyleSheet (XSL)|.xsl, .xslt|  
|Image (ICO)|.ico|  
  
 Silverlight web resources are supported, but to support multiple browsers, HTML web resources are the recommended type of web resources to use if you are designing a user interface.  
  
<a name="BKMK_CreateAndEditWebResources"></a>   
## Create and edit web resources  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Customize the System**.  
  
3.  Under **Components**, choose **Web Resources**.  
  
4. **To create a web resource**: Choose **New**.  
  
 **To edit a web resource**: Double click the web resource you want to edit.  
  
5.  The web resource form has the following fields and capabilities:  
  
    |Label|Description|  
    |-----------|-----------------|  
    |**Name**|**Required**. This is the unique name for this web resource. You can’t change this after you save the web resource.<br /><br /> This name can only include letters, numbers, periods, and nonconsecutive forward slash (“/”) characters.<br /><br /> The solution publisher customization prefix will be prepended to the name of the web resource.|  
    |**Display Name**|The name displayed if you view a list of web resources.|  
    |**Description**|A description of the web resource.|  
    |**Type**|**Required**. This is the type of web resource. You can’t change this after you save the web resource.|  
    |**Text Editor**|When the type of web resource represents a kind of text file, click this button to open a page to edit the content using the text editor.|  
    |**Language**|Allows for a selection of a language. This option just tags the record that stores the web resource data. It doesn’t change the behavior of the web resource.|  
    |**Upload File**|Press the **Browse…** button to choose a file to upload as a web resource.<br /><br /> You can upload a file when creating a new web resource or to overwrite an existing web resource.<br /><br /> The file name extension of the file must match allowed extensions.<br /><br /> By default the maximum size file that can be uploaded as a web resource is 5MB. This value can be modified using the **System Settings** > **Email** tab > **Set file size limit for attachments** setting. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Email tab](http://go.microsoft.com/fwlink/p/?LinkId=394727)|  
    |**URL**|After you save the web resource, the URL to the web resource will be displayed here. Click this link to view the web resource in your browser.|  
  
6.  After you have added your changes, choose **Save** and then **Publish**.  
  
<a name="BKMK_UsingTextEditor"></a>   
### Use the text editor appropriately  
 The text editor provided in the application for web resources should only be used for simple edits of text files. You can use it to create and edit HTML web resources, but you should only edit HTML web resources that were created using the text editor. The text editor is designed for very simple HTML content. If the content of an HTML web resource wasn’t created using the text editor, don’t use the text editor to edit it.  
  
 The text editor uses a control that modifies the HTML source in a way that allows it to be edited. These changes can make the page behave differently in the browser and cause more sophisticated code to stop working. Opening an HTML web resource with the text editor and saving it without making any changes can break some HTML web resources.  
  
 We recommend that you use an external editor to edit text files and then save them locally before uploading them with the **Upload File** button. This way you can preserve a copy of the web resource if you need to return to an earlier version. You can use a simple editor like [!INCLUDE[pn_Notepad](../includes/pn-notepad.md)], but a text editor with more advanced capabilities is highly recommended. [Visual Studio Express editions](http://www.visualstudio.com/products/visual-studio-express-vs.aspx) are free and provide powerful capabilities for editing the files used by text-based web resources.  
  
### See also  
 [Customize your Dynamics 365 system](../customize/customize-your-system.md)   
 [Referencing web resources (Dynamics 365 SDK)](https://msdn.microsoft.com/library/gg309473.aspx)
