---
title: "Install and configure Dynamics 365 – Gamification in Dynamics 365 apps | Microsoft Docs"
description: "Learn how to install the Gamification solution in Dynamics 365 apps and its associated web portal and security roles."
keywords: install, solution, manage, uninstall
ms.date: 04/30/2020
ms.service: dynamics-365-sales
ms.topic: get-started-article
ms.assetid: eb33a4c5-2dde-417b-34f2-8d46be8c2f10
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom: 
  - dyn365-gamification
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Gamification
---

# Install and configure the Gamification solution

The [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] capabilities are a solution for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], hosted on [!INCLUDE[pn_microsoft_appsource](../includes/pn-microsoft-appsource.md)], that you need to install before you can start using the capabilities to manage your [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] games, KPIs, and players.  
  
## Prerequisites  
  
- [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] requires at least [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)].  
  
- Users must have a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] license assigned to access the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] service.  
  
- Users must have an up-to-date browser. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Browser requirements to enable a seamless experience in Gamification](browser-system-requirements.md)  

## Install Dynamics 365 - Gamification  

[!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] capabilities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-2016-shortest.md)] are a solution for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] that you install from [Microsoft AppSource](https://go.microsoft.com/fwlink/p/?linkid=830919).  

### Limitations

We recommend to adhere to the following limits when working with [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] to avoid synchronization and performance issues: 
- Up to **15** concurrent games.
- Up to **500** users per game.
- Up to **10** fixed teams per game.
- Up to **4000** users across all connected organizations.
  
> [!NOTE]
> To avoid timeout issues when syncing the data of more than 2000 users, you need to change the number of users sent per page in the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] settings.    
> In Dynamics 365, select **Advanced Find**. Look for **Gamification Settings** and select **Results**. Open the **Gamification Settings** and lower the value for **Users sent per page**.

### Install the solution from AppSource  
  
1. In [AppSource](https://go.microsoft.com/fwlink/p/?linkid=830919), select **[!INCLUDE[pn_gamification](../includes/pn-gamification.md)]**.  
  
2. Sign in to your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] system admin account, if you aren't already signed in.  
  
3. Click **Get** to start installing the solution.  
   If you have more than one Dynamics 365 organization, select the organization you want to install this solution to.
  
4. Review and accept the disclaimer and the terms of service.  
  
   It might take a few minutes for the solution to be installed.  
  
## Game Manager security role

 When you install [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], a security role called **Game Manager** is created in Dynamics 365. System admins can assign this security role to users who the admins want to enable to create KPIs.  

 [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Available security roles in Gamification](understand-security-roles.md)  
 More information about security roles and privileges: [TechNet: Security roles and privileges](https://technet.microsoft.com/library/dn531090.aspx)  
More information about KPIs in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]: [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md) 
  
## Activate Gamification in Dynamics 365

Before you can sync [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] with Dynamics 365, a user with the following prerequisites needs to complete the setup process to obtain the security key.  

- The user profile in Office 365 has a non-empty first name, last name, email address 
- The user has a global admin role in Office 365 
- The user has a system administrator security role with an [access mode of Read-Write](https://docs.microsoft.com/power-platform/admin/create-users-assign-online-security-roles#create-a-read-write-user-account).


> [!TIP]
> Starting with Gamification solution update 17.10, you can connect multiple organizations (business units) of the same Office 365 tenant to a shared Gamification web portal. Repeat the installation and activation for every organization you want to connect to your shared Gamification portal. Users with the Game Manager security role in Organization A can create games for Organization A in Gamification. If they are regular users in Organization B, they can participate as players or fans in games in Organization B. [Learn how to set up and run games.](run-games.md)
  
### Activate the Gamification portal for your organization  
  
1. In [!INCLUDE[pn_microsoftcrm](../includes/pn-crm-2016.md)], go to **Settings** > **Solutions**, and then double-click the **Gamification** solution.  
  
2. Click **Start Activation**, and then sign in with your admin credentials.  
  
3. Accept the disclaimer, and then provide a **Name** and a **Location** for your instance of the Gamification portal.  
  
4. Click **Register** to start the activation and obtain the security key.  
  
5. Copy the **Security Key**, and then paste it in the input box.  
  
6. Click **Authorize** to complete the connection between [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_gamification](../includes/pn-gamification.md)].  
  
   You'll receive an email with additional details, and then you can access your organization's [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] instance.  
  
   Additionally, the system creates a set of default KPIs in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] so you can quickly get started with the first game in [!INCLUDE[cc_gamification_portal](../includes/cc-gamification-portal.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md)  
  
   To sign in as the first Commissioner, go to [Gamification sign-in](https://go.microsoft.com/fwlink/p/?linkid=830344).  
  
## Update the Gamification solution

 A system administrator can update the solution.
  
 If an update is available, a notification is displayed on the **Gamification Settings** page.   
  
1. Sign in to [https://admin.microsoft.com](https://admin.microsoft.com) with your global administrator or [!INCLUDE[pn_microsoftcrm](../includes/pn-crm-2016.md)] system administrator credentials.  
  
2. Click **Admin centers** > **Dynamics 365**.  
  
3. Click the **Instances** tab, and then select the instance the solution is connected to.  
  
4. Click **Solutions**.  
  
5. Select the solution you want to update, and then click **Upgrade**.  
  
6. In [!INCLUDE[pn_microsoftcrm](../includes/pn-crm-2016.md)], go to **Gamification** > **Gamification Settings**, and then click **Configure App** to update all dependencies to the latest version.  
  
   > [!IMPORTANT]
   >  This step is required to keep all synchronization processes running.  
  
   The system will apply all necessary changes and validate the update to ensure that data keeps flowing smoothly.  
  
> [!NOTE]
>  You need to repeat the preceding steps whenever you update the solution.  
  
## View active games in Dynamics 365 apps  

 You can view information about the active games in [!INCLUDE[pn_CRM_shortest](../includes/pn-crm-2016-shortest.md)].  
  
### View active games  
  
1. In [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], go to **Gamification** > **Games**.  
  
2. In the list of games, click the name of the game you want to see details about.  
  
3. In the **Game Details** section, you'll find basic information about the game, like the name and the start and end date.  
  
    In the **Setup KPIs** section, you can see the KPIs and their setup status in the selected game. More information about KPIs in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]: [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md)  

## Uninstall the Gamification solution

You need to remove **GamificationUpdate** *before* you remove **Gamification**. More information about removing a preferred solution: [Delete a preferred solution](https://technet.microsoft.com/library/dn878909.aspx#Delete%20a%20preferred%20solution)

## Privacy notice  

[!INCLUDE[cc_privacy_gamification_solution](../includes/cc-privacy-gamification-solution.md)]  
  
### See also  

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md)   
 [Import players and fans from Dynamics 365 and manage their security roles](manage-players-fans.md)   
 [Set up and run games in Gamification](run-games.md)   
 [Troubleshooting guide](troubleshooting-guide.md)    
 [Privacy information and license terms for Gamification](legal-information.md)
