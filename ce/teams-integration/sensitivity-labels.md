---
title: "Enable sensitivity labels to protect content in Microsoft Teams| MicrosoftDocs"
ms.custom: 
description: Use sensitivity labels to protect content in Microsoft Teams.
ms.date: 05/24/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Enable sensitivity labels to protect content in Microsoft Teams

Users in your organization collaborate with others both inside and outside the organization. This means that content no longer stays behind a firewall—it can roam everywhere, across devices, apps, and services. And when it roams, you want it to do so in a secure, protected way that meets your organization's business and compliance policies. For more information, see [Get started with sensitivity labels](/microsoft-365/compliance/get-started-with-sensitivity-labels).

Sensitivity labels in Microsoft Teams integration with customer engagement apps in Dynamics 365 (such as Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation) lets you create teams with sensitivity label and  make the team private so that only the owner of the team can add other members to the team.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the sensitivity labels drop-down while creating a team](media/teams-enter-team-name-5.png)

## Prerequisites

The following prerequisites are required before you can turn on sensitivity labels in your app:

 - Azure Information Protection (AIP) P2 Premium license. For more information, see [Azure Information Protection](https://azure.microsoft.com/services/information-protection)
 - Create and configure sensitivity labels in your tenant. For more information, see [Create and configure sensitivity labels and their policies](/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide).



## Turn on sensitivity labels

Sensitivity labels are only available when the Enhanced Collaboration Experience is turned on. For more information, see [Install and set up Microsoft Teams integration](teams-install-app.md).

> [!NOTE]
  > If you are still using the group classification labels instead of sensitivity labels, turning on this option will let you use the classification labels in Teams.

**To turn on sensitivity labels**

1. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area")
    in the lower-left corner and then select **App Settings**.
   > [!div class="mx-imgBorder"]
   > ![Screenshot depicting the App settings option in change area](media/app-settings-menu.png)

    > [!NOTE]
    > **App Settings** is only available in the Sales Hub app. If you don't have the Sales Hub app and want to access the settings from your custom app, add a subarea with the following URL:  
        `/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings&data={"id":"overview","ismanage":"cnc"}`  
    > Alternatively, suffix the URL to your Dynamics 365 domain URL to instantly access the settings page mentioned in Step 3:  
   `Example: https://adatum.crm.dynamics.com/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings&data={"id":"overview","ismanage":"cnc"}`

2. From the site map, under **General Settings**, select **Chat and collaborate**.

3. Set the **Enable Confidential Labels** toggle to **Yes**. When you're done, select **Save**. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot highlighting the Enable Confidential Labels option](media/enable-sensitivity-labels.png)  
    
To learn how to use sensitivity labels, see [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).
