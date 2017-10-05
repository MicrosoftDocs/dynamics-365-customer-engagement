---
title: "Security Roles in Dynamics 365 - Gamification | Microsoft Docs"
description: "Learn about the security roles used in Microsoft Dynamics 365 – Gamification."
ms.custom: ""
ms.date: 05/31/2017
ms.reviewer: ""
ms.service: gamification
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: Dynamics 365 (online)
ms.assetid: afad369f-fe8a-4ced-8808-0af86ffad2c1
caps.latest.revision: 15
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Understand security roles used in Gamification

Administrators assign licenses to users to grant them permissions for certain applications. [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] users can't be enabled for [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] unless they have a [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] license assigned. The first user to have a KPI Manager security role assigned by a system admin in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] is required to set up the connection between [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] and [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)]. The user successfully activating Gamification becomes the first Commissioner in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. Be sure that you don't delete this user before assigning Commissioner permissions to other users.   
  
## Available security roles

The permissions in games are exclusively granted by the security roles in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. For a description of the available security roles, review the [Gamification terminology](glossary.md).  

To learn more about the permissions of the available security roles, refer to the following table.  
  
|Permission|Commissioner|Game Manager|User|  
|----------------|------------------|------------------|----------|  
|[Install and configure the Gamification solution in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md)|No*|No*|No*|  
|[Import players and fans from Dynamics 365 (online) and manage their security roles](manage-players-fans.md)|Yes|No|No|  
|[Set up and run games in Gamification](run-games.md)|Yes|Yes|No|  
|[Manage Stream TV games in Gamification](configure-view-tvs.md)|Yes|Yes|No|  
|[Update game scores by using Excel point scoring capabilities in Gamification](update-scores-using-excel-point-scoring.md)|Yes|Yes|No|  
|[Schedule weekly or one-time emails](schedule-weekly-one-time-emails.md)|Yes|Yes|No|  
|[Create weekly awards to keep players and fans engaged](define-weekly-awards.md)|Yes|Yes|No|  
|[Draft and manage your fantasy teams in Gamification](manage-fantasy-team.md)|No|Yes**|Yes|  
|[Post on the smack talk board in Gamification](smack-talk-post.md)|Yes|Yes|Yes|  
|[See how you rank against other players on a Gamification leaderboard](view-leaderboard.md)|Yes|Yes|Yes|  
  
 \* Managing [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] is regulated by [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] permissions and requires a KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)].  For information about the KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)], see [Configure KPIs for Gamification in Dynamics 365 (online)](configure-kpis.md) and [Install and configure the Gamification solution in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md).  
  
 \** Game managers can participate as a fan or a player in a game they don't administer.  
  
### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Overview for players and fans in Gamification](for-players-fans.md)   
 [Import players and fans from Dynamics 365 (online) and manage their security roles](manage-players-fans.md)
