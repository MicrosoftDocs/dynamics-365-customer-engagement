---
title: "Manage players and fans in Gamification | MicrosoftDocs"
ms.custom: ""
ms.date: "04/18/2017"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4df5e61b-0d7b-4cef-b741-14bed0637756
caps.latest.revision: 34
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Manage players and fans in Gamification

When you set up a new game, you need to define which users are  players and which are fans in the upcoming [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] game.  
  
 **Players** are competing participants in your game who get points for achieving defined KPIs.  
  
 **Fans** are people who aren’t players in an active game—for example executives,  managers or receptionists—that participate in a [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] game by drafting a team. If your CEO gets involved in the game, drafts a team, and is personally looking after player stats, that’s quite an incentive to deliver the best results!  
  
## Import users from Azure Active Directory  

 Users from [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] are available automatically in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]. Commissioners can import additional users from [!INCLUDE[pn_azure_active_directory](includes/pn-azure-active-directory-md.md)] which don't have a [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] license assigned.  
  
### Import users from [!INCLUDE[pn_microsoftcrm](includes/pn-microsoftcrm-md.md)]  
  
1.  In [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)], go to **Users**.  
  
2.  On the **Import Users from Dynamics 365** page, select the **Security role** for each user.  
  
     Likely, a vast majority of the imported users will be users who are joined by a handful of game managers. For more information about the available security roles and their associated permissions, see [Understand Gamification security roles](understand-security-roles.md).  
  
3.  Select the check box for the users you want to import to [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)].  
  
4.  To start the import process, click **Import Selected Users**.  
  
    > [!NOTE]
    >  This can take up to a couple of minutes, depending on the number of users that are being imported.  
  
 Imported users now show in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] when you navigate to the **Users** page.  
  
 Now you can edit security roles for the players, according to your planned game setup.  
  
## See Also  

 [For Commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Run a game in Dynamics 365 - Gamification](run-games.md)