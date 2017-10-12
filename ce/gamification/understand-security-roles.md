---
title: "Security Roles in Dynamics 365 - Gamification | Microsoft Docs"
description: "Learn about the security roles used in Microsoft Dynamics 365 – Gamification."
keywords: "security roles, game manager, commissioner, permissions"
ms.date: 10/12/2017
ms.service: gamification
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 997fe3ba-01d7-f0fb-6111-5340f6ff7bab
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Understand security roles used in Gamification

Administrators assign licenses to users to grant them permissions for certain applications. [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] users can't be enabled for [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] unless they have a [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] license assigned. The first user to have a Game Manager security role assigned by a system admin in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] is required to set up the connection between [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] and [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)].

[comment]: <> (Check if first Game manager activate flow is still accurate.)

  
## Available security roles

[!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] provides three security roles: 
- **Commissioner**: Administrators of the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] solution and web portal. The user successfully activating Gamification becomes the first Commissioner in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. Additionally, all users in[!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] with a **Global Admin** or **Dynamics 365 Service Administrator** become Commissioners in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].
- **Game Manager**: Game managers create and run games in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. To become a game manager, a [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] admin has to assign the **Game Manager** security role to these users in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)].
- **User**: The default security role for every user of the connected Dynamics 365 (online) organization. Game managers and commissioners can add them to games as players or fans.

[comment]: <> (Add link to change security roles in D365)

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
  
 \* Managing [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] is regulated by [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)] permissions and requires a Game Manager security role in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)].  For information about the Game Manager security role in [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-shortest.md)], see [Configure KPIs for Gamification in Dynamics 365 (online)](configure-kpis.md) and [Install and configure the Gamification solution in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md).  
  
 \** Game managers can participate as a fan or a player in a game they don't administer.  
  
### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Overview for players and fans in Gamification](for-players-fans.md)   
 [Import players and fans from Dynamics 365 (online) and manage their security roles](manage-players-fans.md)