---
title: "Create user roles and user groups | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ba1244cd-3de2-44b7-84d3-ea95b4ee7192
caps.latest.revision: 20
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
robots: noindex,nofollow
---
# Create user roles and user groups
User roles and groups let a Commissioner manage large groups of individuals in [!INCLUDE[pn_gamification](../gamification/includes/pn-gamification-md.md)] efficiently. You'll need user roles if not all players compete on the same KPIs. User roles are used like employee roles in [!INCLUDE[pn_crm_shortest](../gamification/includes/pn-crm-shortest-md.md)]. They have no influence on the users' permissions in [!INCLUDE[pn_crm_shortest](../gamification/includes/pn-crm-shortest-md.md)].  
  
 If you have a large number of players, user groups let you easily determine the players for each game, and simplify adding  players to positions. Both are optional when you run a game.  
  
<a name="playerRoles"></a>   
## Configure user roles  
  
> [!TIP]
>  Create user roles if you want certain KPIs to apply only to certain groups of employees, based on their employee roles.  
  
#### Create a new user role  
  
1.  In [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)], go to **Users** > **User Roles**.  
  
2.  Choose if you want to create roles manually or in batch by using the [!INCLUDE[pn_Excel_short](../gamification/includes/pn-excel-short-md.md)] template.  
  
    1.  To add roles manually, click **Add New Role**, and then enter the role name.  
  
    2.  To create roles in batch, click **Download Excel Template**, add your roles to the template, and then click **Upload Excel File**.  
  
#### Assign a user role  
  
1.  In [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)], go to **Users** > **User Roles**.  
  
2.  In the list of user roles, click **Edit**![Edit button in Gamification](../gamification/media/edit-symbol-gamification.png "Edit button in Gamification").  
  
3.  To assign this role, select the check boxes for the players you want to assign in the users list and click **Assign Users**.  
  
4.  Click **Save** to confirm the role assignments.  
  
#### Edit or delete a user role  
  
1.  In [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)], go to **Users** > **User Roles**.  
  
2.  In the row of the role you want to edit or delete, click **Edit**![Edit button in Gamification](../gamification/media/edit-symbol-gamification.png "Edit button in Gamification") or **Delete**![Delete button in Gamification](../gamification/media/delete-symbol-gamification.png "Delete button in Gamification").  
  
> [!NOTE]
>  You can only delete roles that aren't assigned to any player.  
  
<a name="playerGroups"></a>   
## Configure user groups  
 Commissioners can create user groups  to work with a large number of players. An individual player can be part of more than one group. For example,  a large number of field service reps in several locations might be grouped into reps from the same location, or into reps who work on the same product line.  
  
 When you set up a new game, you can quickly filter the list of players by selecting a user group and a user role.  
  
#### Create a new user group  
  
1.  In [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)], go to **Users** > **User Groups**.  
  
2.  Choose if you want to create groups manually or in batch by using the [!INCLUDE[pn_Excel_short](../gamification/includes/pn-excel-short-md.md)] template.  
  
    1.  To add groups manually, click **Add New Group**, and then enter the **User Group Name**.  
  
    2.  To create groups in batch, click **Download Excel Template**, add your groups to the template, and then click **Upload Excel File**.  
  
    3.  Drag the players from the **Available Users** area to the **Assigned Users** area to add them to the group.  
  
    4.  Click **Save** to apply your changes.  
  
#### Edit or delete a user group  
  
1.  In [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)], go to **Users** > **User Groups**.  
  
2.  In the list of user groups click **Edit**![Edit button in Gamification](../gamification/media/edit-symbol-gamification.png "Edit button in Gamification") or **Delete**![Delete button in Gamification](../gamification/media/delete-symbol-gamification.png "Delete button in Gamification").  
  
3.  Edit the groups, and then click **Save** to apply your changes, or confirm the deletion.  
  
## See Also  
 [For admins](http://msdn.microsoft.com/en-us/9cbe15a2-8239-4601-8af2-50a92c28f81f)   
 [Set up a game](http://msdn.microsoft.com/en-us/ec71f8e3-5cc9-4941-8067-5bf8e1081da9)   
 [Manage players and fans](http://msdn.microsoft.com/en-us/4df5e61b-0d7b-4cef-b741-14bed0637756)