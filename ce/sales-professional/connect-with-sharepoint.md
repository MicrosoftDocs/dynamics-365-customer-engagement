---
title: "Configure Dynamics 365 for Sales Professional to integrate with SharePoint | MicrosoftDocs"
description: ""
keywords: ""
author: shubhadaj
ms.author: shujoshi
manager: annbe
applies_to: 
	- Dynamics 365 for Customer Engagement
	- Dynamics 365 for Customer Engagement apps version 9.x
ms.date: 03/26/2019
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: 4b7ba471-25f9-403b-91cc-6e60fff2c668
ms.custom: dyn365-sales
---
# Configure Dynamics 365 for Sales Professional to integrate with SharePoint

Store the documents related to Dynamics 365 for Sales Professional entity records in SharePoint and quickly access, share, and manage these documents from
the Sales app by integrating with SharePoint Online.

## Prerequisites

To be able to configure SharePoint, you must have:

-   Sales Professional Manager or System Administrator role

-   Office 365 subscription

-   SharePoint Online subscription

## Integrate with SharePoint

1.  In the site map, select Sales Settings, and then under Standard settings, select **Connect SharePoint**.

    If your organization doesn’t have a SharePoint subscription, you’ll need to first purchase a SharePoint subscription.

2.  On the **Connect SharePoint to Dynamics 365 for Sales** page, enter your organization’s SharePoint address, and select **Connect SharePoint**.

    The following configuration happens in the background:

    1.  A SharePoint sub site is created with the SharePoint default root URL. This URL is used to configure SharePoint. For example, a subsite
        /Dynamics 365/\<orgname\> is created under tenant.sharepoint.com.

    2.  The SharePoint site is validated.

        By default, SharePoint is enabled on the following entities:

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

        The folder structure is created based on the **Account** entity. This means that the folders are created under the folder for the related
        account.  For example, the following folder structure is created for a document for an opportunity record “100 Bikes” that has a related account as
        Margie’s travel:

        `:.../account/Margie's Travel/opportunity/100 Bikes&lt;entityGUID&gt;.`

        You’ll see a confirmation message when SharePoint is successfully configured.

3.  If any error occurs during configuration, a message is shown. Errors can occur in many cases like issues with permissions, issues while validating a
    site, or while creating a folder.

4.  Select **Retry**.

    All the backend configuration steps are performed again in the background.

    
    > [!IMPORTANT]

    > If the issues persist, please follow the detailed setup process using the Dynamics 365 – custom app. More information: [Set up Dynamics 365 for
    Customer Engagement to use SharePoint Online](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### See Also

[Manage your SharePoint documents](manage-sharepoint-documents-sales-professional.md)  
[Overview of Dynamics 365 for Sales Professional](sales-professional-overview.md)  
[Quick Setup & Advanced Settings overview](standard-advanced-settings-overview.md)
