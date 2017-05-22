---
title: "Configure site settings for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
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

Applies To: Dynamics 365 (online), Dynamics CRM Online

A Site Setting is a configurable named value that is used by website code to modify the behavior or visual style of the portal. Typically when a developer creates the website code, they will reference Site Settings for various components to enable an end user to modify the setting values to alter the website without having to change the code, recompile, and redeploy the website.

The sample portals that are provided with the installation of Dynamics 365 portals contain several configurable Site Settings for various styles used to modify many visual elements within the site such as background style, text color, and layout width.

## Manage site settings in Dynamics 365

1.  Login to **Dynamics 365**

<!-- -->

1.  Go to **Portals** &gt; **Site Settings**

2.  To create a new setting: Click **New**

3.  To edit an existing setting: Double-click on the **Site Setting** listed in the grid

4.  Specify values for the fields provided

| Name        | Description                                                                                                                                                                                                              |
|-------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name        | A label referenced by website code to retrieve the appropriate setting. The name should be unique for the associated website as the code retrieving the setting will take the first record found with the matching name. |
| Website     | The associated website.                                                                                                                                                                                                  |
| Value       | The setting.                                                                                                                                                                                                             |
| Description | The purpose of the setting or special instructions.                                                                                                                                                                      |

1.  Click **Save & Close**

### See Also

[How to provision a portal](provision-portal.md)  
[Configure a Dynamics 365 portal](configure-portal.md)  
[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Configure a Dynamics 365 portal](configure-portal.md)  
[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)  

