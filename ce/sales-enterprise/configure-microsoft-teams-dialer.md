---
title: "Configure Microsoft Teams dialer in Dynamics 365 Sales | MicrosoftDocs"
description: "How to configure Microsoft Teams dialer in Dynamics 365 Sales."
ms.date: 01/29/2021
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure Microsoft Teams dialer

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Microsoft Teams dailer helps sellers to be more productive and get work done more effectively by calling customers directly within Dynamics 365 Sales.   
As an administrator, you must configure the Teams dialer  for sellers to use. When configured the Teams dailer are available in your Dynamics 365 app for phone activity.     
You must perform the following steps to configure Teams dialer for your organization:    
1.	[Review the prerequisites](#review-the-prerequisites).   
2.	[Configure the dialer](#configure-the-dialer).    

## Review the prerequisites    
Review the following requirements before you configure the Microsoft Teams dialer in your sales app:     
-	You must have an administrator or equivalent security role. To learn more, see [Assign a security role to a user](https://docs.microsoft.com/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).    
-	Your organization has a phone system installed with proper license to use. To learn more, see [Set up Phone System in your organization](https://docs.microsoft.com/MicrosoftTeams/setting-up-your-phone-system).    
-	You have license to use Microsoft Teams. To learn more, see [Microsoft Teams add-on licenses](https://docs.microsoft.com/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business).    

## Configure the dialer     
1.	Sign in to your sales app.     
2.	Go to **App settings** and under **General settings** select **Teams calls (preview)**.    
    > [!div class="mx-imgBorder"]
    > ![](media/ "")     
3.	In the **What you need to set up Microsoft Teams calls** section, select **Check status**.   
    > [!div class="mx-imgBorder"]
    > ![](media/ "")      

    The application validates that your organization have sufficient privileges to use the **Phone system** and **Microsoft Teams**.    
    Up on successful validation, the status corresponding to **Phone system license** and **Teams license** display **Status: Successfully set up**. 
    > [!div class="mx-imgBorder"]
    > ![](media/ "")      

    If any of the validation fails, you can’t proceed with the configure and you must contact your tenant administrator to setup the phone system and Microsoft Teams for your organization.      
    When the tenant administrator completes the configuration of [phone system](https://docs.microsoft.com/MicrosoftTeams/setting-up-your-phone-system) and [Teams licenses](https://docs.microsoft.com/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business), you can continue with the configuration.       
4.	Select **Enable preview** and the Teams call preview is enabled.   
    > [!div class="mx-imgBorder"]
    > ![](media/ "")      
5.	In the **Security role** section, select one of the following options to provide permissions to users who will view the Teams dialer.

    | Option | Description |
    |--------|-------------|
    | All security roles | This option provides access to view Teams dialer to all the security roles of users in your organization. |
    | Specific security roles | This option allows you to specify security roles when you want to give access to view Teams dialer to specific users. |     

    > [!div class="mx-imgBorder"]
    > ![](media/ "")      
6.	Select **Advanced options** and in the **Select app** drop-down, choose and add apps such as, your custom apps. By default, **Sales Hub** app is selected. 
    > [!div class="mx-imgBorder"]
    > ![](media/ "")      

    >[!NOTE]
    >When Teams call is enabled in your organization for an app, other telephony systems that are connected to app through Channel Integration Framework (CIF) will stop working . Administrator can deactivate or delete the CIF phone system. Follow these steps:
    >1.	Go to your **Channel Integration Framework** app.
    >2.	From the **Active Channel Providers** view, choose the phone system.
    >3.	From the **Tool** bar, select **Deactivate** or **Delete** according to your requirement.   
    >The phone system is disabled or removed from your organization.    
7.	Save and publish the configurations.    
    A confirmation message is displayed, and the Teams dialer is enabled in your organization for selected security roles in the selected app.    
    >[!NOTE]
    >You must refresh the configuration page to make the changes available in the application. 

### See also

[Microsoft Teams integration](../teams-integration/teams-integration.md)
