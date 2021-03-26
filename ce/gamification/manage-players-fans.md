---
title: "Manage users from Dynamics 365 apps and their security roles in Dynamics 365 – Gamification | Microsoft Docs"
description: "Learn how to manage users and how to assign them the appropriate security roles for the games."
keywords: gamification, player, fan, user, license
ms.date: 03/04/2020
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: 4df5e61b-0d7b-4cef-b741-14bed0637756
author: m-hartmann
ms.author: mhart
manager: shellyha
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

# Manage users from Dynamics 365 apps and their security roles

When you set up a new game, you need to define which users will be players and which will be fans in your upcoming [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] game. Users from [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] are available automatically in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].


**Players** are competing participants in your game who get points for achieving defined KPIs.

**Fans** are people who aren’t players in an active game—for example, executives, managers, or receptionists—who participate in a [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] game by drafting a team. If your CEO gets involved in the game, drafts a team, and is personally following player stats, that’s quite an incentive for players to do their best!

## Change a user's security role in Dynamics 365 - Gamification

After users are imported, an administrator can [change the security role](understand-security-roles.md) of the users directly in the connected [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organization.


## Delete a user from Dynamics 365 - Gamification

You can delete users from [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] by deleting their user accounts in the connected organization. If the user is still active in your organization, you can't remove them in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. 

For step-by-step instructions, see [Delete a user from your organization](/office365/admin/add-users/delete-a-user)

### Remove a deleted user from Gamification

1. In **Gamification**, go to **Users**.

2. On the **Microsoft Dynamics 365 Users** page, search for the user you want to delete.

3. Select the Delete symbol ![Delete user symbol](media/delete-symbol-gamification.png) and confirm the deletion.
You can't undo this action.

### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Set up and run games in Gamification](run-games.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]