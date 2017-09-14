---
title: "Understand user roles | Microsoft Docs"
description: "Understand the permissions for the available user roles in Social Engagement."
ms.date: 09/12/2017
ms.service: mse
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: 40ba637e-3eb2-40bc-b512-ff12aeb12f58
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Understand user roles
You can assign roles with appropriate permissions for your [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] solution users. Every user can be assigned two sets of roles: configuration roles and interaction roles. This gives administrators flexibility to manage user roles and permissions, and give users the functionality they need.  
  
 Every invited user should be assigned both types of roles.  
  
 An administrator needs to confirm the automatically-assigned Analyst and Reader role for an invited user, or update the user role.  
  
 To assign and edit user roles, go to **Settings** > **User Management**.  
  
> [!NOTE]
>  This Settings page is visible to administrators only.  
  
> [!IMPORTANT]
>  User roles set in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] don’t apply to [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. You’ll need to set roles in both [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] and in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. A user can have a different role in each solution.  
>   
>  If there are **Newly invited (Analyst/Reader)** users in the solution, administrators will receive a notification when accessing the **Settings** area.  
  
## Configuration user roles  
 The configuration role defines permissions to set up search topics and to configure the application.  
  
 The following table shows the Analyst, Power Analyst, and Administrator configuration roles and their permissions.  
  
|Permissions|Analyst|Power Analyst|Administrator|  
|-----------------|-------------|-------------------|-------------------|  
|View all analysis|Yes|Yes|Yes|  
|Edit sentiment value for posts|Yes|Yes|Yes|  
|Delete posts|No|Yes|Yes|  
|Exclude/delete authors|No|Yes|Yes|  
|Create and edit search topics|No|Yes. Can only edit  search topics created by himself|Yes|  
|Create and manage categories|No|Can only edit owned categories|Yes|  
|Manage custom sources|No|No|Yes|  
|Create and edit location groups|No|Can only edit owned location groups|Yes|  
|Manage user roles|No|No|Yes|  
|Exclude sources and terms|No|No|Yes|  
|Set up connections to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]|No|No|Yes|  
|Create and manage alerts|Yes|Yes|Yes|  
|Define global settings|No|No|Yes|  
|Create and edit activity maps|Yes|Yes|Yes|  
|Manage automation rules|No|No|Yes|  
|Manage event hub connections|No|No|Yes|  
|View event hub connections|No|No|Yes|  
|Promote custom tags to auto tags, rename custom tags, delete custom tags|No|No|Yes|  
|Edit search topic owners|No|No|Yes|  
  
## Interaction user roles  
 The interaction role defines permissions to collaborate with other solution users and to engage on social media from within the solution.  
  
 To let users interact with a post from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], administrators can assign the appropriate interaction roles. Typically, a user with a Manager role defines streams and shares them with other users. Readers just want to keep track of the conversations and posts assigned to them, while Responders tend to take action on a post.  
  
|Permissions|Reader|Responder|Manager|  
|-----------------|------------|---------------|-------------|  
|View streams|Yes|Yes|Yes|  
|Manage social profiles|No|Yes|Yes|  
|Edit labels on posts|No|Yes|Yes|  
|Edit post assignments|No|Yes|Yes|  
|Manage streams|No|No|Yes|  
|React on a post|No|Yes|Yes|  
|Publish a new post|No|Yes|Yes|  
|Create a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record from a social post|No|Yes|Yes|  
|Unlink a post from a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record|No|No|Yes|  
|View record details|Yes|Yes|Yes|  
|View automation rules|Yes|Yes|Yes|  
|Create custom tags|No|Yes|Yes|  
|Edit tags on posts (confirm  tags, add tags, remove tags)|Yes|Yes|Yes|  
  
### See Also  
 [Administer Microsoft Social Engagement](../social-engagement/administer-microsoft-social-engagement.md)   
 [Integrate Social Engagement with Office 365](../social-engagement/manage-licenses.md)   
 [Assign permissions and user roles](../social-engagement/assign-user-roles.md)
 
