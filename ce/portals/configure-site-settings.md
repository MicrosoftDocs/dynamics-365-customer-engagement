---
title: "Configure site settings for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to add and configure site settings for a portal and global settings for all portals in your organization."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 53642ce6-f6eb-4cc1-8f80-2df8aad2fa39
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Configure site settings for portals

A site setting is a configurable, named value that is used by website code to modify the behavior or visual style of the portal. Typically when a developer creates the website code, they will reference site settings for various components to enable an end user to modify the setting values to alter the website without having to change the code, recompile, and redeploy the website.

The sample portals that are provided with the installation of [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals contain several configurable site settings for various styles used to modify many visual elements within the site such as background style, text color, and layout width.
You can manage the following types of site settings:
- **Global Portal settings**: These settings apply to all portals associated with the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization in which they are being added.
- **Portal site settings**: These settings apply to specific portals (website records) that are associated with the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization in which they are being added.


## Manage portal site settings

1.  Sign in to **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]**.
2.  Go to **Portals** &gt; **Site Settings**.
3.  To create a new setting, select **New**.
4.  To edit an existing setting, select the **Site Setting** listed in the grid.
5. Specify values for the fields provided: 
    - **Name**:  A label referenced by website code to retrieve the appropriate setting. The name should be unique for the associated website, because the code retrieving the setting will take the first record found with the matching name.
    - **Website**:  The associated website. 
    - **Value**: The setting
    - **Description**: The purpose of the setting or special instructions.
6. Select **Save & Close**.

> [!Note] 
> Bing Maps integration is not supported in the German Sovereign Cloud. If you try to create the Bingmaps/credentials setting in this environment, an error message will be displayed.

## Manage global portal settings

1.  Sign in to **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]**.
2.  Go to **Settings** &gt; **Settings**.
3.  To create a new setting, select **New**.
4.  To edit an existing setting, select the **Site Setting** listed in the grid.
5. Specify values for the fields provided: 
    - **Name**:  A unique name referenced by code to retrieve the appropriate setting.
    - **Value**: The setting
    - **Description**: The purpose of the setting or special instructions.
6. Select **Save & Close**.

> [!Note] 
> Bing Maps integration is not supported in the German Sovereign Cloud. If you try to create the BinMap/Key or Adxstudio/ProductivityPack/BingMap/Key setting in this environment, an error message will be displayed.

### See also

[How to provision a portal](provision-portal.md)  
[Configure a Dynamics 365 portal](configure-portal.md)  
[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)  

