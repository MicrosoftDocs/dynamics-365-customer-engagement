---
title: "Understand Gamification security roles | MicrosoftDocs"
ms.custom: ""
ms.date: "04/18/2017"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: afad369f-fe8a-4ced-8808-0af86ffad2c1
caps.latest.revision: 15
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Understand Gamification security roles
Administrators assign licenses to users to grant them permissions for certain applications. To enable [!INCLUDE[pn_azure_active_directory](includes/pn-azure-active-directory-md.md)] users for [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)], they need to have a [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] license assigned. The first user to have a KPI Manager security role assigned by a system admin in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] is required to set up the connection between [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] and [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)]. The same user automatically becomes the first Commissioner in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)].  
  
## Available security roles  
 The permissions in games are exclusively granted by the security roles in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]. For a description of the available security roles, review the [Gamification glossary](glossary.md).  
  
 To learn more about the permissions of the available security roles, refer to the following table.  
  
|Permission|Commissioner|Game Manager|User|  
|----------------|------------------|------------------|----------|  
|[Manage Gamification in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md)|No*|No*|No*|  
|[Manage players and fans in Gamification](manage-players-fans.md)|Yes|No|No|  
|[Run a game in Dynamics 365 - Gamification](run-games.md)|Yes|Yes|No|  
|[Configure and view TVs](configure-view-tvs.md)|Yes|Yes|No|  
|[Update scores using Excel point scoring](update-scores-using-excel-point-scoring.md)|Yes|Yes|No|  
|[Schedule weekly or one-time emails](schedule-weekly-one-time-emails.md)|Yes|Yes|No|  
|[Define weekly awards for Gamification players and fans](define-weekly-awards.md)|Yes|Yes|No|  
|[Manage a fantasy team](manage-fantasy-team.md)|No|Yes**|Yes|  
|[Post on Smack Talk](smack-talk-post.md)|Yes|Yes|Yes|  
|[View the leaderboard](view-leaderboard.md)|Yes|Yes|Yes|  
  
 No* = Managing the [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] is regulated by [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] permissions and requires a KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)].  If you are looking for information about the KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)], see [Configure KPIs in Dynamics 365 (online)](configure-kpis.md) and [Manage Gamification in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md).  
  
 Yes** = Game Managers can participate as a fan or a player in a game they don't administer.  
  
## See Also  
 [For Commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [For players and fans in Gamification](for-players-fans.md)   
 [Manage players and fans in Gamification](manage-players-fans.md)