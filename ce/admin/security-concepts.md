---
title: "Security concepts for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5ca6019e-65f6-4bd8-8bd1-8f66d8814363
caps.latest.revision: 30
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Security concepts

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You use the security model in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to protect the data integrity and privacy in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization. The security model also promotes efficient data access and collaboration. The goals of the model are as follows:  
  
-   Provide a multi-tiered licensing model for users.  
  
-   Grant users access that allows only the levels of information required to do their jobs.  
  
-   Categorize users and teams by security role and restrict access based on those roles.  
  
-   Support data sharing so that users can be granted access to objects they do not own for a one-time collaborative effort.  
  
-   Prevent access to objects a user does not own or share.  
  
You combine business units, role-based security, record-based security, and field-based security to define the overall access to information that users have in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization.  
  
<a name="Bizunits"></a>   
## Business units  
 A business unit basically is a group of users. Large organizations with multiple customer bases often use multiple business units to control data access and define security roles so that users can access records only in their own business unit. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create business units](../admin/create-edit-business-units.md)  
  
<a name="Roles"></a>   
## Role-based security  
 You can use role-based security to group sets of privileges together into *roles* that describe the tasks that can be performed by a user or team. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes a set of predefined security roles, each of which is a set of privileges aggregated to make security management easier. The bulk of the privileges define the ability to create, read, write, delete and share records of a specific entity type. Each privilege also defines how broadly the privilege applies: at the user level, business unit level, the entire business unit hierarchy or across the entire organization.  
  
 For example, if you sign in as a user that is assigned the Salesperson role, you have the privileges to read, write and share accounts for the entire organization, but you can only delete account records that you own. Also, you have no privileges to perform system administration tasks such as install product updates, or to add users to the system.  
  
 A user that has been assigned the Vice President of Sales role can perform a wider set of tasks (and has a greater number of privileges) associated with viewing and modifying data and resources than can a user who has been assigned to the Salesperson role. A user assigned the Vice President of Sales role can, for instance, read and assign any account to anyone in the system, while a user assigned the Salesperson role cannot.  
  
 There are two roles that have very broad privileges: System Administrator and Customizer. To minimize misconfiguration, the use of these two roles should be limited to a few people in your organization responsible for administering and customizing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Organizations can also customize existing roles and create its own roles to meet their needs. More information: [Security roles](../admin/security-roles-privileges.md)  
  
<a name="User"></a>   
## User-based access and licensing  
 By default, when you create a user the user has read and write access to any data for which they have permission. Also, by default, the user client access license (CAL) is set to Professional. You can change either of these settings to further restrict data and feature access.  
  
**Access mode**. This setting determines the level of access for each user.  
  
- Read-Write access. By default, users have Read-Write access that allows them access to data for which they have appropriate permission set by security roles.  
  
- Administrative access. Allows access to areas that the user has appropriate permission set by security roles but doesn’t allow the user to view or access business data typically found in the Sales, Service, and Marketing areas, such as accounts, contacts, leads, opportunities, campaigns, and cases. For example, Administrative access can be used to create [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrators who can have access to perform a complete variety of administrative tasks, such as create business units, create users, set duplicate detection, but cannot view or access any business data. Notice that users who are assigned this access mode do not consume a CAL.  
  
- Read access. Allows access to areas for which the user has appropriate access set by security role but the user with Read access can only view data and can’t create or change existing data. For example, a user with the system administrator security role who has read access can view business units, users, and teams but can’t create or modify those records.  
  
**License type**. This sets the user CAL and determines what features and areas are available to the user. This feature and area control is separate from the user’s security role setting. By default, users are created with Professional CAL for the most feature and area access that they have permission granted.  
  
<a name="Teams"></a>   

## Teams  
 Teams provide an easy way to share business objects and let you collaborate with other people across business units. While a team belongs to one business unit, it can include users from other business units. You can associate a user with more than one team. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage teams](../admin/manage-teams.md)  
  
<a name="Records"></a>   
## Record-based security  
 You can use record-based security to control user and team rights to perform actions on individual records. This applies to instances of entities (records) and is provided by access rights. The owner of a record can share, or grant access to a record to another user or team. When this is done, they must choose which rights they are granting. For example, the owner of an account record can grant read access to that account information, but not grant write access.  
  
 Access rights apply only after privileges have taken effect. For example, if a user does not have the privileges to view (read) account records, they will be unable to view any account, regardless of the access rights another user might grant them to a specific account through sharing.  
  
<a name="Hierarchy"></a>   
## Hierarchy security 
 You can use the hierarchy security model for accessing hierarchical data. With this additional security, you gain a more granular access to records, allowing managers to access the records of their reports for approval or do work on reports’ behalf. More information: [Hierarchy security](../admin/hierarchy-security.md)  
  
<a name="Field"></a>   
## Field-based security  
 You can use field-level security to restrict access to specific high business impact fields in an entity only to specified users or teams. Like record-based security, this applies after privileges have taken affect. For example, a user may have privileges to read an account, but can be restricted from seeing specific fields in all accounts. More information: [Field level security](../admin/field-level-security.md)  
  
<a name="WP"></a>   
## Security Modeling with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]  
 For detailed information about and best practices for designing  the  security model in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], read the [Scalable Security Modeling with Microsoft Dynamics CRM](http://download.microsoft.com/download/D/6/6/D66E61BA-3D18-49E8-B042-8434E64FAFCA/Scalable%20Security%20Modeling%20with%20Microsoft%20Dynamics%20CRM%202015.pdf) white paper available from the [!INCLUDE[pn_Microsoft_Download_Center](../includes/pn-microsoft-download-center.md)].  
  
### See also  
 [Field level security](../admin/field-level-security.md)   
 [Hierarchy security](../admin/hierarchy-security.md)   
 [Control data access](../admin/security-roles-privileges.md)   
 [Create or edit a security role](../admin/create-edit-security-role.md)   
 [Copy a security role](../admin/copy-security-role.md)   
 [Manage users](../admin/create-users-assign-online-security-roles.md)   
 [Manage teams](../admin/manage-teams.md)   
 [Add teams or users to a field security profile](../admin/add-teams-users-field-security-profile.md)   
 [Manage security, users and teams](../admin/manage-security-users-and-teams.md)
 <!-- [Microsoft Dynamics 365 administration best practices](Administration%20best%20practices%20for%20on-premises%20deployments%20of%20Microsoft%20Dynamics%20365.md)   -->
