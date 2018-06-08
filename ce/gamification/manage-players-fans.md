---
title: "Import and manage players and fans in Dynamics 365 – Gamification | Microsoft Docs"
description: "Learn how to import players from your Azure Active Directory and how to assign them the appropriate security roles for the games."
keywords: "gamification, player, fan, import, importing, azure active directory, user, license"
ms.date: 05/03/2018
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: 4df5e61b-0d7b-4cef-b741-14bed0637756
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom:
  - dyn365-gamification
---

# Manage users from Dynamics 365 (online) and their security roles

When you set up a new game, you need to define which users will be players and which will be fans in your upcoming [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] game. Users from [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] are available automatically in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].


**Players** are competing participants in your game who get points for achieving defined KPIs.

**Fans** are people who aren’t players in an active game—for example, executives, managers, or receptionists—who participate in a [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] game by drafting a team. If your CEO gets involved in the game, drafts a team, and is personally following player stats, that’s quite an incentive for players to do their best!

## Change a user's security role in Dynamics 365 - Gamification

<!-- <div class="embeddedvideo"><iframe src="https://www.microsoft.com/en-us/videoplayer/embed/cc1cf5fc-097d-4776-a348-2c79a0e8167f" frameborder="0" allowfullscreen=""></iframe></div> -->

After users are imported, an administrator can [change the security role](understand-security-roles.md) of the users directly in the connected [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organization.


## Delete a user from Dynamics 365 - Gamification

You can delete users from [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] once an admin has removed their [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] licenses in the connected organization. If the user is still active in your organization, you can't remove them in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] and need to remove their license first. 

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Users**.

2. On the **Microsoft Dynamics 365 Users** page, search for the user you want to delete.

3. Select the **Delete** symbol ![Delete user symbol](media/delete-symbol-gamification.png "Delete user symbol") and confirm the deletion.    
   You can't undo this action. 

### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Set up and run games in Gamification](run-games.md)
