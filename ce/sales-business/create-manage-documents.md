---
title: "Manage your documents from Dynamics 365 for Sales, Business edition | Microsoft Docs"
description: "Store and manage documents on SharePoint from within Dynamics 365 for Sales, business edition."
keywords: "SharePoint; document management; sales"
author: shubhadaj
ms.author: shujoshi
manager: sakudes
applies_to: "Dynamics 365 (online)"
ms.date: 07/15/2017
ms.service: dynamics-365
ms.topic: article
ms.assetid: eaf38d0b-24d1-499d-b157-de109f052786
ms.reviewer: 
---
# Manage your documents from [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)], Business edition

With [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)], you can store your documents on [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)], and manage them from within your app.

The documents that you create in the Sales app are stored on [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)], and are automatically synced to your desktop and mobile devices.

**Note:**

Before you can use [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] to store the documents, it must be enabled by your system administrator.

**Important:**

This feature requires that you have an [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] subscription or a subscription to an online service such as [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)].

## What record types support document management?

By default, [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] is enabled on the following entities:

-   Account

-   Contact

-   Lead

-   Opportunity

-   Quote

-   Invoice

-   Product

-   Appointment

-   Task

-   Phone Call

## Where do you access the documents from?

For record types that support document management, open the record, click the **Related** tab, and then click **Documents**.

![Documents option in Related tab](media/documents-option-in-related-tab.png "Documents option in Related tab")  

## What happens when you navigate to the Documents tab first time?

When [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] is enabled, for record types that support document management, a default document location (folder) is automatically created on [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] the first time you go to the **Documents** tab. The name of the document location is in the following format: &lt;record\_name&gt;\_&lt;record\_id&gt;.

## View existing [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] documents

Open a view with a document grid.

For example,

1.  Click **Sales** &gt; **Opportunities**

2.  Click the **Related** tab, and then click **Documents**.

![Documents tab in a form](media/documents-tab-in-form.png "Documents tab in a form")  

[!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] now organizes documents in a consolidated view.

1.  Click **Document Location** to filter the document list. Select from the available document locations.

## Create a new document

To create a new [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] document in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]:

1.  Go to the record you want to create the document for, and click the **Documents** tab.

2.  Navigate to the document location and folder where you want to create this new document.

3.  Click **New**, and then choose a document type such as [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Word, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)], [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] PowerPoint, or OneNote.

> You can also create a folder from here.

1.  In the **Create a New Document dialog** box, enter a document or folder name.

> ![Dialog box for creating a new document](media/create-new-document-dialog-box.png "Dialog box for creating a new document")  

1.  Click **Save**.

> The document is created in the folder of the current document location you’re in.
>
> If you create a folder, you’ll be able to see a folder hierarchy at the top of Documents list.
>
> ![Form showing folder hierarchy in documents list](media/folder-hierarchy-in-document-list.png "Form showing folder hierarchy in documents list")  
>
> Click on the folder name to navigate between the folders.

## Upload a document

To upload existing document to [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] from [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]:

1.  Go to the record you want to create the document for, and click the **Documents** tab.

2.  Click **Upload.**

3.  Choose the file you want to upload. You can choose only one file at a time.

    The document is created in the folder of the current document location you’re in.

 **Note**: You can upload a file of up to 50 MB of size. ### If your internet connection is slow, you may get an error while uploading large files.

4.  If files with the same name exists in [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)], select if you want to overwrite the files.

5.  Click **Upload**.

## Manage [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] locations

You may create new or edit existing [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] locations from [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)].

In the **Documents** list

1.  To open the location, on the command bar, click **Open Location**, and then select the location.

 ![Open document location from a record](media/open-location-from-record.png "Open document location from a record")  

2.  To edit the location, on the command bar, click **Edit Location** &gt; &lt;location name&gt;.

The Edit Location dialog box appears.

![Dialog box to edit a [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] location](media/edit-location-dialog-box.png "Dialog box to edit a [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] location")  

### The display name, parent site, and folder name is automatically populated. Provide the new location details, and click **Save**.

1.  To add a location, on the command bar, click **Add Location**.

    The Add Location dialog box appears.

 ![Dialog box to add a [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] location](media/add-location-dialog-box.png "Dialog box to add a [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] location")  

    The display name, parent site, and folder name is automatically populated. Change the details if required, and then click **Save**.

## Actions on documents

When you select one or more documents in the Documents list, you can take the following other common [!INCLUDE[pn-sharepoint-short](../includes/pn-sharepoint-short.md)] actions on the documents:

-   Edit

-   Delete

-   Check in

-   Check out

-   Discard check out

-   Edit properties

