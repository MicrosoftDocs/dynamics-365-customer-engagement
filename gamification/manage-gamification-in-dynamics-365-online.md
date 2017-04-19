---
title: "Manage Gamification in Dynamics 365 (online) | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-04-06"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cff88aa0-01a3-4cd7-adcf-8d4b8dec9f20
caps.latest.revision: 36
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Manage Gamification in Dynamics 365 (online)
The [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] capabilities are a solution for [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], hosted on [!INCLUDE[pn_microsoft_appsource](includes/pn-microsoft-appsource-md.md)] that you need to install before you can start using the capabilities to manage your [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] games, KPIs, and players.  
  
<a name="BKMK_prerequisistes"></a>   
## Prerequisites  
  
-   The [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] capabilities require at least [!INCLUDE[pn_crm_8_1_0_online](includes/pn-crm-8-1-0-online-md.md)].  
  
-   Users must have a [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] license assigned to access the [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] service.  
  
-   Users must have an up-to-date browser. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Browser and system requirements for Gamification](browser-and-system-requirements-for-gamification.md)  
  
<a name="BKMK_install"></a>   
## Install Gamification for [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)]  
 [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] capabilities in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)] are a solution for [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] that you install from [Microsoft AppSource](https://go.microsoft.com/fwlink/p/?linkid=830919).  
  
> [!NOTE]
> [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] can be used exclusively on a single [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] instance per [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] tenant. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [TechNet: Multiple online instances or tenants](https://technet.microsoft.com/library/dn722373.aspx)  
  
#### Install the solution from AppSource  
  
1.  In [AppSource](https://go.microsoft.com/fwlink/p/?linkid=830919), select [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)].  
  
2.  Sign in to your [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] system admin account if you aren't already signed in.  
  
3.  Click **Get** to start installing the solution.  
  
4.  Review and accept the disclaimer and the terms to add [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] to [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)].  
  
 It may take a few minutes until the solution is installed in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)].  
  
<a name="BKMK_users"></a>   
## KPI Manager security role  
 When you install [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)], a security role called **KPI Manager** is created. System admins can assign this security role to [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] users they want to enable to create KPIs for [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)].  
  
 To learn more about security roles and privileges, see [TechNet: Security roles and privileges](https://technet.microsoft.com/library/dn531090.aspx)  
  
 For more information about KPIs in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], see [Configure KPIs in Dynamics 365 (online)](configure-kpis-in-dynamics-365-online.md).  
  
<a name="BKMK_authorize"></a>   
## Activate Gamification in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)]  
 Before you can sync [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] with [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], a user with a global admin role in [!INCLUDE[pn_Office_365](includes/pn-office-365-md.md)] and a system administrator security role in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] needs to complete the set-up process to obtain the security key.  
  
#### Activate the Gamification web app for your organization  
  
1.  In [!INCLUDE[pn_microsoftcrm](includes/pn-microsoftcrm-md.md)], go to **Settings** > **Solutions** and then double-click the **[!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)]** solution.  
  
2.  Click **Start Activation** and sign in with your admin credentials.  
  
3.  Accept the disclaimer and provide a **Name** and a **Location** for your instance of the Gamification web app.  
  
4.  Click **Register** to start the activation and obtain the security key.  
  
5.  Copy the **Security Key** and paste it in the input box.  
  
6.  Click **Authorize** to complete the connection between [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] and [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)].  
  
 You'll receive an email with additional details and you can now access your organization's [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] instance.  
  
 Additionally, the system creates a set of default KPIs in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] so you can quickly get started with the first game in [!INCLUDE[pn_gamification_portal](includes/pn-gamification-portal.md)]. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Configure KPIs in Dynamics 365 (online)](configure-kpis-in-dynamics-365-online.md)  
  
 To sign in as the first Commissioner, go to [Gamification sign-in](https://go.microsoft.com/fwlink/p/?linkid=830344).  
  
<a name="updateApp"></a>   
## Update Microsoft Dynamics 365 - Gamification  
 We're working hard to provide the best experience in [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)]. This includes updates to the [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] solution. A system administrator can update the solution directly from within [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)].  
  
 If an update is available, a notification is displayed on the **Gamification Settings** page.  
  
#### Update the Gamification for Dynamics 365 solution  
  
1.  Sign in to [https://portal.office.com](https://portal.office.com) with your Global administrator or [!INCLUDE[pn_microsoftcrm](includes/pn-microsoftcrm-md.md)] System Administrator credentials.  
  
2.  Click **Admin centers** > **Dynamics 365**.  
  
3.  Click the **Instances** tab, and then select the instance the solution is connected to.  
  
4.  Click **Solutions**.  
  
5.  Select the solution you want to update and click **Update**.  
  
6.  In [!INCLUDE[pn_microsoftcrm](includes/pn-microsoftcrm-md.md)], go to **Gamification** > **Gamification Settings** and click **Update App** to update all dependencies to the latest version.  
  
    > [!IMPORTANT]
    >  This step is required to keep all synchronization processes running.  
  
 The system will apply all necessary changes and validate the update to ensure data keeps flowing smoothly.  
  
> [!NOTE]
>  You need to repeat the above steps whenever you update the solution.  
  
## View active games in [!INCLUDE[pn_crm_shortest](includes/pn-crm-shortest-md.md)]  
 When the [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] solution is installed in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], you can view information about the active [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] games.  
  
#### View active games  
  
1.  In [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], go to **Gamification** > **Games**.  
  
2.  In the list of games, click the game name you want to see details about.  
  
3.  In the **Game Details** section, you'll find basic information about the game, like the name and the start and end date.  
  
     In the **Setup KPIs** section, you can see the KPIs and their setup status in the selected game. For more information about KPIs in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], see [Configure KPIs in Dynamics 365 (online)](configure-kpis-in-dynamics-365-online.md).  
  
<a name="BKMK_privacy_notice"></a>   
## Privacy notice  
 [!INCLUDE[cc_privacy_gamification_solution](includes/cc-privacy-gamification-solution-md.md)]  
  
## See Also  
 [For Commissioners and game managers in Gamification](for-commissioners-and-game-managers-in-gamification.md)   
 [Configure KPIs in Dynamics 365 (online)](configure-kpis-in-dynamics-365-online.md)   
 [Manage players and fans in Gamification](manage-players-and-fans-in-gamification.md)   
 [Run a game in Dynamics 365 - Gamification](run-a-game-in-dynamics-365-gamification.md)   
 [Legal information about Dynamics 365 - Gamification](legal-information-about-dynamics-365-gamification.md)