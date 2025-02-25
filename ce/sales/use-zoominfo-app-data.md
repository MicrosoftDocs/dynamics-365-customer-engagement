---
title: Use ZoomInfo app data in Dynamics 365 Sales
description: Understand how you can use ZoomInfo app data in Dynamics 365 Sales. Learn how to find and import B2B account, contact, and lead info, or update existing data
ms.date: 09/20/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.custom: bap-template
---

# Use ZoomInfo app data 

The ZoomInfo app for Dynamics 365 helps sales teams accelerate business growth with accurate contact and account information in their preferred Dynamics 365 Sales workflows.  
As a seller or sales manager, you can do the following tasks using ZoomInfo data in Dynamics 365 Sales:  

- Find and import B2B account, contact, and lead information  
- Update data on existing leads, contacts, and accounts  

## Prerequisites  

Before you start, be sure you've met the following prerequisites:  

- The ZoomInfo app is installed on your Dynamics 365 Sales organization. More information: [Install ZoomInfo app](install-zoominfo-app.md)  
- You have a license to use the ZoomInfo app.  

## Access and understand the ZoomInfo data  

You can access the ZoomInfo app in the following ways:  

- **Through the Dynamics 365 app center**: The ZoomInfo app is available as part of Dynamics 365 published apps. The app for Dynamics includes custom forms with the ZoomInfo iframe built into account, contact, and lead forms. Also included in the left navigation are links to the ZoomInfo app and Knowledge Center.  
- **Customized experience**: The customized experience is available when an administrator customizes the existing environment by adding the same elements available in the ZoomInfo app experience to the Dynamics 365 Sales app and to standard or custom account, contact, and lead objects. More information: [Customize the ZoomInfo app](customize-zoominfo-app.md).  

To access and understand the ZoomInfo data, follow these steps:  

1. Open your Dynamics 365 Apps page and choose one of the following options to open the ZoomInfo data:  
    - Select the **ZoomInfo** app and on the left navigation pane, select **Accounts**, **Contacts**, or **Leads**, depending on the record for which you want to view information.  
    - Select the **Sales Hub** app and on the left navigation pane, select **Accounts**, **Contacts**, or **Leads**, depending on the record for which you want to view information.  

    >[!NOTE]
    >In this example, we're using the **Accounts** record type to explain the steps.   

1. Open an account record and the record opens with a default form.  
1. On the form selector dropdown, choose **ZoomInfo Account**.  
    :::image type="content" source="media/zoominfo-select-zoominfo-form-account.png" alt-text="Screenshot for select zoominfo form from the account record.":::  
    The **Summary** tab of the **ZoomInfo Account** form includes a **ZoomInfo Overview** that displays metadata describing the ZoomInfo data for the selected account. The metadata includes the date and time when the account was first updated, last updated with ZoomInfo data, and the unique ZoomInfo ID.  
    :::image type="content" source="media/zoominfo-overview-section-account.png" alt-text="Screenshot for ZoomInfo overview section in account record.":::  
1. Select the **ZoomInfo** tab to see the data of the account that's available in the ZoomInfo app.  
    :::image type="content" source="media/zoominfo-account-details-home-page.png" alt-text="Screenshot for ZoomInfo home page with account details.":::  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Install ZoomInfo app](install-zoominfo-app.md)  
[ZoomInfo Native App for Microsoft Dynamics 365 Implementation Guide](https://tech-docs.zoominfo.com/microsoft-dynamics-native-app-implementation-guide.pdf)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
