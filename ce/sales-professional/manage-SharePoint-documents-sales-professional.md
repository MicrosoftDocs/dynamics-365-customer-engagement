---
title: "Manage your SharePoint documents and document locations in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Store your sales documents on SharePoint and manage them from within Dynamics 365 Sales Professional."
ms.date: 10/01/2019
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - "dyn365-sales"
---

# Manage your SharePoint documents and document locations in Dynamics 365 Sales Professional

With Dynamics 365 Sales Professional, you can store your documents on Microsoft SharePoint and manage them from within your app.

The documents that you create in the Sales app are stored on SharePoint and are automatically synced to your desktop and mobile devices.

>[!NOTE] 
>Before you can use SharePoint to store documents, it must be enabled by your system administrator.

>[!IMPORTANT]
>This feature requires that you have a Microsoft 365 subscription or a subscription to an online service such as SharePoint.

## What record types support document management?

By default, SharePoint is enabled for the following entities:

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

For record types that support document management, open the record, select the **Related** tab, and then select **Documents**.

> [!div class="mx-imgBorder"]
> ![Documents option in Related tab](media/documents-option-related-tab.png "Documents option in Related tab")

## What happens when you navigate to the Documents tab the first time?

When SharePoint is enabled for record types that support document management, a default document location (folder) is automatically created on SharePoint the
first time you go to the **Documents** tab. The name of the document location is in the following format: <record_name>_<record_id>.

## View existing SharePoint documents

Open a Document list for an entity record. For example, for an opportunity record:

1.  In the site map, select **Opportunities**.

2. Open an opportunity record.

3.  Select the **Related** tab, and then select **Documents**.

    > [!div class="mx-imgBorder"]
    > ![Documents tab showing the Documents list or Documents Associated Grid in a form](media/documents-tab-in-form.png "Documents tab showing the Documents list or Documents Associated Grid in a form")

4.  Select **Document Location** to filter the document list. Select from the available document locations.

## Create a new document

To create a new SharePoint document in your app:

1.  Go to the record you want to create the document for, and select the **Documents** tab.

2.  Navigate to the location where you want to create this new document.

3.  Select **New**, and then choose a document type such as Microsoft Word, Excel, PowerPoint, or OneNote.

    You can also create a folder from here.

4.  In the **Create a New Document dialog** box, enter a document or folder
    name.

    > [!div class="mx-imgBorder"]
    > ![Create a new Word document dialog box](media/create-word-document-dialog-box.png "Create a new Word document dialog box")

5.  Select **Save**.

    The document is created and is located in your current location in the folder hierarchy.

    If you create a folder, you’ll be able to see a folder hierarchy at the top of Documents list.

    > [!div class="mx-imgBorder"]
    > ![Form showing folder hierarchy in documents list](media/folder-hierarchy-in-document-list.png "Form showing folder hierarchy in documents list")

    Select the folder name to navigate between the folders.

## Upload a document

To upload an existing document to SharePoint from your app:

1.  Go to the record you want to create the document for, and select the **Documents** tab.

2.  Select **Upload.**

3.  Select the file you want to upload. You can select only one file at a time.

    The document is created in the folder of the current document location
    you’re in.

    >[!NOTE] 
    >You can upload a file of up to 50 MB in size. 
    >If your internet connection is slow, you might get an error while uploading large files.

4.  If a file with the same name exists in SharePoint, choose whether you want to overwrite the file.

5.  Select **Upload**.

## Manage SharePoint locations

You can create new or edit existing SharePoint locations from your app.

In the **Documents** list:

1.  To open the location, on the command bar, select **Open Location**, and then
    select the location.

    > [!div class="mx-imgBorder"]
    > ![Open document location from a record](media/open-document-location.png "Open document location from a record")

2.  To edit the location, on the command bar, select **Edit Location** \> \<location name>.

    The **Edit Location** dialog box appears.

    > [!div class="mx-imgBorder"]
    > ![Dialog box to edit a SharePoint location](media/edit-sharepoint-location.png "Dialog box to edit a SharePoint location")

3.  The display name, parent site, and folder name are automatically populated. Provide the new location details, and select **Save**.

4.  To add a location, on the command bar, select **Add Location**.

    The **Add Location** dialog box appears.

    > [!div class="mx-imgBorder"]
    > ![Dialog box to add a SharePoint location](media/add-sharepoint-location.png "Dialog box to add a SharePoint location")

5.  The display name, parent site, and folder name are automatically populated. Change the details if required, and then select **Save**.


## Create folders

1.  To create folders to store documents in, on the command bar, select **New** > **Folder**.

2.  In the **Create a New Folder** dialog box, enter a name for the folder, and select **Save**.

  >[!NOTE]
  >If your folder name contains a slash (/), Dynamics 365 Sales Professional creates nested folders. For example, if you enter the folder name as Bike/2001, two folders are created: "Bike" and "2001". The 2001 folder is created inside the Bike folder.

## Actions on documents

When you select one or more documents in the Documents list, you can take these common SharePoint actions on the documents:

-   Edit
-   Delete
-   Check in
-   Check out
-   Discard check out
-   Edit properties


### See also

[Configure Dynamics 365 Sales Professional to integrate with SharePoint](connect-with-sharepoint.md)  
[Manage your customers](manage-accounts-contacts.md)   
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
