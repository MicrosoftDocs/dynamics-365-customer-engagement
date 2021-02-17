---
title: "About team templates  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
helpviewer_keywords: 
  - template
  - team template
  - team
ms.assetid: 7c29ad58-b0f4-4a0f-b686-ecbca053592b
caps.latest.revision: 21
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# About collaborating with team templates

Using teams in Dynamics 365 Customer Engagement (on-premises) is optional, however, teams give you an easy way to share information and collaborate with users across business units. A team is a group of users. As a group, you will be able to track information about the records and perform assigned tasks in much more efficient and coordinated way. While a team belongs to only one business unit, it can include users from other business units. A user can be associated with more than one team.
  
 There are two types of teams that you can work with: *owner* and *access*.  
  
-   An owner team owns records and has security roles assigned to the team. The team’s privileges are defined by these security roles. In addition to privileges provided by the team’s security roles, users have the privileges defined by their individual security roles and by the roles from other teams in which they are members. A team has full access rights on the records that the team owns.  
  
-   An access team doesn’t own records and doesn’t have security roles assigned to the team. The users have privileges defined by their individual security roles and by the roles from other teams in which they are members. The records are shared with an access team and the team members are granted access rights on the records, such as Read, Write, or Append.  
  
An access team can be created manually (user-created) or automatically (system-managed). You can share multiple records with a user-created access team. A system-managed team is created for a specific record and other records can’t be shared with this team. For system-managed teams, you have to provide a team template that the system uses to create a team. In this template, you define the entity type and the access rights on the record that are granted to the team members when the team is created. A team template is displayed on all record forms for the specified entity as a list. When you add the first user to the list, the actual access team for this record is created. You can add and remove members in the team using this list. The team template applies to the records of the specified entity type and the related entities, according to the cascading rules. To give team members different access on the record, you can provide several team templates, each template specifying different access rights. For example, you can create a team template for the account entity with the Read access right, which allows the team members to view the specified account. For another team that requires more access to the same account, you can create a team template with Read, Write, Share and other access rights.  
  
Only entities that are enabled for system-managed access teams can be specified in the template.  
  
If you change access rights in the team template, the changes are only applied to new system-managed access teams. The existing teams aren’t affected.  
  
For information about how to create a team template, enable an entity for system-managed access teams and how to customize the entity form to add the team template, see [Create a team template and add to an entity form](create-team-template-add-entity-form.md).
  
### See also  
 [Create a team template and add to an entity form](create-team-template-add-entity-form.md)   
 [Manage teams](manage-teams.md)    
 [Access teams in Microsoft Dynamics CRM](https://download.microsoft.com/download/E/9/0/E9009308-CA01-4B37-B03C-435B8ACB49B4/Access%20Teams%20with%20Microsoft%20Dynamics%20CRM%202013.pdf)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]