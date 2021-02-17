---
title: "Create or edit web resources in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create or edit a web resource"
ms.custom: 
ms.date: 10/29/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: ef4ba8df-9ba9-4066-b40d-def9761c7de2
caps.latest.revision: 21
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Create or edit web resources to extend an app

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create or edit model-driven app web resources to extend an app](/powerapps/maker/model-driven-apps/create-edit-web-resources)

Web resources are typically used by developers to extend an app using files that are used in web development. App users may need to manage web resources provided by a developer or designer.  

> [!TIP]
> For an in-depth discussion of web resources, see [Web resources for Customer Engagement](../developer/web-resources.md).


<a name="BKMK_WhatAreWebResources"></a>   
## What are web resources?  
 Web resources are virtual files stored in the system. Each web resource has a unique name that can be used in a URL to retrieve the file. Think of them this way: If you had access to the actual web server running the web app, you could copy files over to that website. But with most online services, you can’t do this.  Instead, you can use web resources to upload files to the system and then reference them by name just as though you had copied them as files to the web server.  

For example, if you create an HTML page as a web resource named “new_myWebResource.htm”, you could open that page in a browser using a URL like this:  

<Dynamics 365 Customer Engagement (on-premises) URL>/WebResources/new_myWebResource.htm   

 where *\<app URL>* is the URL you usually use to open the app. Because the web resource is data in the system, only licensed users for your organization can access them this way. Normally, web resources are included in forms rather than referenced directly. The most common usage is to provide [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries for form scripts.  

Because web resources are data in the system and are solution aware, you can move them to different organizations by exporting them as part of a solution and importing the solution into a different organization.  

<a name="BKMK_CreateAndEditWebResources"></a>   
## Create and edit web resources  

1. Open solution explorer, and then select  **Web Resources**.  

2. Under **Components**, choose **Web Resources**.  

3. To create a web resource select **New**.  

   To edit a web resource double-click the web resource you want to edit.  

4. The web resource form has the following fields and capabilities:  


   |      Label       |                                                                                                                                                                                                                                                                                                                                                Description                                                                                                                                                                                                                                                                                                                                                |
   |------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |     **Name**     |                                                                                                                                                                            **Required**. This is the unique name for this web resource. You can’t change this after you save the web resource.<br /><br /> This name can only include letters, numbers, periods, and nonconsecutive forward slash (“/”) characters.<br /><br /> The solution publisher customization prefix will be prepended to the name of the web resource.                                                                                                                                                                            |
   | **Display Name** |                                                                                                                                                                                                                                                                                                                          The name displayed if you view a list of web resources.                                                                                                                                                                                                                                                                                                                          |
   | **Description**  |                                                                                                                                                                                                                                                                                                                                    A description of the web resource.                                                                                                                                                                                                                                                                                                                                     |
   |     **Type**     |                                                                                                                                                                                                                                                                                                  **Required**. This is the type of web resource. You can’t change this after you save the web resource.                                                                                                                                                                                                                                                                                                   |
   | **Text Editor**  |                                                                                                                                                                                                                                                                                When the type of web resource represents a kind of text file, select this button to open a page to edit the content using the text editor.                                                                                                                                                                                                                                                                                 |
   |   **Language**   |                                                                                                                                                                                                                                                                       Allows for a selection of a language. This option just tags the record that stores the web resource data. It doesn’t change the behavior of the web resource.                                                                                                                                                                                                                                                                       |
   | **Upload File**  | Select the **Browse…** button to choose a file to upload as a web resource.<br /><br /> You can upload a file when creating a new web resource or to overwrite an existing web resource.<br /><br /> The file name extension of the file must match allowed extensions.<br /><br /> By default the maximum size file that can be uploaded as a web resource is 5MB. This value can be modified in Dynamics 365 Customer Engagement (on-premises) by using the **System Settings** > **Email** tab > **Set file size limit for attachments** setting. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Email tab](../admin/system-settings-dialog-box-email-tab.md) |
   |     **URL**      |                                                                                                                                                                                                                                                                              After you save the web resource, the URL to the web resource will be displayed here. Select this link to view the web resource in your browser.                                                                                                                                                                                                                                                                              |


5. After you have added your changes, choose **Save** and then **Publish**.  

> [!NOTE]
>  Publishing customizations can interfere with normal system operations. We recommend you publish customizations when it’s least disruptive to users.

<a name="BKMK_UsingTextEditor"></a>   
### Use the text editor appropriately  
 The text editor provided in the application for web resources should only be used for simple edits of text files. You can use it to create and edit HTML web resources, but you should only edit HTML web resources that were created using the text editor. The text editor is designed for very simple HTML content. If the content of an HTML web resource wasn’t created using the text editor, don’t use the text editor to edit it.  

 The text editor uses a control that modifies the HTML source in a way that allows it to be edited. These changes can make the page behave differently in the browser and cause more sophisticated code to stop working. Opening an HTML web resource with the text editor and saving it without making any changes can break some HTML web resources.  

 We recommend that you use an external editor to edit text files and then save them locally before uploading them with the **Upload File** button. This way you can preserve a copy of the web resource if you need to return to an earlier version. You can use a simple editor like [!INCLUDE[pn_Notepad](../includes/pn-notepad.md)], but a text editor with more advanced capabilities is highly recommended. [Visual Studio Express](https://visualstudio.microsoft.com/vs/express/) is free and provides powerful capabilities for editing the files used by text-based web resources.  

<a name="BKMK_CreateAndEditFormWebResources"></a>   
## Create and edit a web resource on a form
You can add or edit web resources on a form to make it more appealing or useful to users. Make sure that you have the System Administrator security role or equivalent privileges.

> [!NOTE]
>  You can’t include a web resource in a form header or footer.  

1. Open solution explorer.

2. Under **Components**, expand **Entities**, and then expand the entity you want to work with.

3. Choose **Forms**, in the list locate a form of type Main, and then double-click or tap the entry to open and edit the form.

4. To add a web resource, select the tab (for example, **General** or **Notes**) you would like to insert it on, and then on the **Insert** tab, select **Web Resource**.<br />
    \-OR-<br />
    To edit a Web resource, select a form tab and the web resource that you want to edit, and then on the **Home** tab, select **Change Properties**.

5. In the **Add Web Resource** or **Web Resource Properties** dialog box, on the **General** tab, enter the appropriate information in the required fields.
    In particular, note the following:
   - In the **Web resource** box, select the image, HTML, or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource that you want to use.
       > [!NOTE] 
       > After you specify a web resource, the **Web Resource Properties** section appears at the bottom of this tab, providing options that vary based on the type of web resource you are adding. These options include specifying custom parameters, passing a record object-type code as a parameter, or specifying alternative text that describes the resource or, for images, that makes the image more accessible to all users. Here are a few important properties. For a complete listing, see: [Web resource properties](../customize/web-resource-properties-legacy.md). 
           - In the **Name** box, enter a unique name for the field. The name can contain only alphanumeric characters and underscores.
   - The **Label** field is automatically populated with a variation of the name you specify, but ensure that the proposed label meets your needs or update it accordingly.

6. On the **Formatting** tab, the options that display vary based on the type of web resource inserted. These options include specifying the number of columns and rows display, whether a border displays, and the scrolling behavior.

7. If the **Dependencies** tab displays in the **Add Web Resource** or **Web Resource Properties** dialog box, from the **Available fields** list, select the fields that are required by the Web resource, select the **Add Selected Records** button to move the selected fields to the Dependent fields list, and then select **OK** to close the dialog box.

8. When you finish editing the form, on the **Home** tab, select **Save and Close** to close the form. To preview how the main form will appear and how events will function:
    - On the **Home** tab, select **Preview**, and then select **Create Form**, **Update Form**, or **Read-Only Form**.
    - To close the Preview form, on the **File** menu, select **Close**.

9. When your customizations are complete, publish them:
    - To publish customizations for only the component that you are currently editing, in the navigation pane, select the entity you have been working on, and then select **Publish**.
    - To publish customizations for all unpublished components at one time, in the navigation pane, select **Entities**, and then on the **Actions** toolbar, select **Publish All Customizations**.

<a name="BKMK_CreateAndEditImageWebResource"></a>    
## Add or edit an image web resource
Web resources are virtual files in multiple formats, such as html files, [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], and [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] applications, that are stored in the system and can be retrieved by using a unique URL address.  

1.  Open solution explorer.  

2.  To create a new web resource, choose **Components** > **Web Resources**, and then on the Actions toolbar, choose **New**.  

3.  Type or modify information in the text boxes.  

    -   The name entered in the **Name** text box, plus the file extension will become its file name.  

    -   The name entered in the **Display Name** text box will be displayed in the **Display Name**.  

    -   In the **Type** drop-down box, select the file type you want.  

4.  Choose **Browse** to select and upload the file from your local machine.  

    -   To preview an uploaded image web resource: Choose **Web Resource**>**Preview**.  

    -   To edit a text web resource: Choose **Text Editor**.  

    -   To preview a text web resource: Choose **Web Resource**> **Preview**.  

5.  When you’re ready to save your data, choose **Save and Close**.  

6.  Publish your customization.  

    -   For only the edited component: Choose **Save** > **Publish** on the **Home**.  

    -   For all unpublished components at one time, choose **Publish All Customizations**.  

> [!NOTE]
> [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]

### See also  
[Web resource properties](../customize/web-resource-properties-legacy.md) <br /> 
[Create and design forms](create-design-forms.md) <br />
[Get started with customization](../customize/getting-started-customization.md) <br /> 
[Web resources for Customer Engagement](../developer/web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]