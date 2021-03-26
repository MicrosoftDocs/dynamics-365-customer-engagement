---
title: "Configure Dynamics 365 Sales Professional to integrate with SharePoint | MicrosoftDocs"
description: "Allow your users to store sales documents in SharePoint and collaborate on them by integrating Dynamics 365 Sales Professional with SharePoint."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Configure Dynamics 365 Sales Professional to integrate with SharePoint

> [!IMPORTANT]
> This capability is introduced in the Dynamics 365 Sales Professional app version 9.1.0.0.

Store the documents related to Dynamics 365 Sales Professional entity records in SharePoint. Quickly access, share, and manage these documents from
the Sales app by integrating with SharePoint Online.

## Prerequisites

To be able to configure SharePoint, you must have:

-   Sales Professional Manager or System Administrator role

-   Microsoft 365 subscription

-   SharePoint Online subscription

## Integrate with SharePoint

1.  In the site map, select **Sales Settings**, and then under **Standard settings**, select **Connect SharePoint**.

    If your organization doesn’t have a SharePoint subscription, you’ll need to first purchase one.

2.  On the **Connect SharePoint to Dynamics 365 Sales** page, enter your organization’s SharePoint address, and select **Connect SharePoint**.

    The following configuration happens in the background:

    1.  A SharePoint subsite is created with the SharePoint default root URL. This URL is used to configure SharePoint. For example, a subsite /Dynamics 365/<orgname> is created under tenant.sharepoint.com.

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

        The folder structure is created based on the **Account** entity. This means that the folders are created under the folder for the related account. For example, the following folder structure is created for a document for the opportunity record “100 Bikes” that has a related account, Margie’s travel:

        `:.../account/Margie's Travel/opportunity/100 Bikes&lt;entityGUID&gt;.`

        You’ll see a confirmation message when SharePoint is successfully configured.

3.  If any error occurs during configuration, a message is shown. Errors can occur in many cases, like issues with permissions or issues while validating a
    site or creating a folder.

4.  Select **Retry**.

    All the back-end configuration steps are performed again in the background.

    > [!IMPORTANT]
    > If the issues persist, please follow the detailed setup process using the Dynamics 365 – custom app. More information: [Set up Dynamics 365 apps to use SharePoint Online](/dynamics365/customer-engagement/admin/set-up-dynamics-365-online-to-use-sharepoint-online).

### See also

[Manage your SharePoint documents](develop-sales-lead-to-cash-sales-professional.md)  
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)  
[Admin settings overview](admin-settings-overview.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]