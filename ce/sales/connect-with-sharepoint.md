---
title: "Configure Dynamics 365 Sales to integrate with SharePoint | MicrosoftDocs"
description: "Allow your users to store sales documents in SharePoint and collaborate on them by integrating Dynamics 365 Sales with SharePoint."
ms.date: 10/01/2019
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - dyn365-sales
---

# Configure Dynamics 365 Sales to integrate with SharePoint

Store the documents related to Dynamics 365 Sales entity records in SharePoint. Quickly access, share, and manage these documents from
the Sales app by integrating with SharePoint Online.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sales Manager, or Sales Professional Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Configure the integration

Depending on the Dynamics 365 Sales license that you have, select one of the tabs for specific information.

# [Sales Premium and Sales Enterprise](#tab/SE)

Configure the integration with Sharepoint in Power Platform. For step-by-step instructions, see [Manage your documents using SharePoint](/power-platform/admin/manage-documents-using-sharepoint?context=/dynamics365/context/sales-context)".  


# [Sales Professional](#tab/SP)


### Prerequisites

To be able to configure SharePoint, you must have:

-   Sales Professional Manager or System Administrator role

-   Microsoft 365 subscription

-   SharePoint Online subscription

### Integrate with SharePoint

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
