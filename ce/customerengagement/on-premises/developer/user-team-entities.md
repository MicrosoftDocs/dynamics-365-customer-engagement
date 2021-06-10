---
title: "User and team entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about user and team management using which you can create and maintain user accounts and profiles."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a88d9a7c-865c-45cc-be2a-fb5693a58268
author: KumarVivek
ms.author: kvivek
manager: amyla
helpviewer_keywords: 
  - user settings
  - users, significant attributes
  - users and teams, introduction
  - systemuser entity
  - user accounts
  - access types, users
  - team entity
  - teams and users, introduction
  - users, noninteractive
  - records owned, users and teams
  - user license types
  - bulk-assigning of records
  - license types, users
  - system user (user) entity, user and team entities
  - user access types
  - records, bulk-assigning
  - users, synchronizing with Microsoft Office 365
  - security roles, users
  - teams, definition
topic-status: Drafting
search.audienceType: 
  - developer

---

# User and team entities

User and team management is the area of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] where you can create and maintain user accounts and profiles.  

 A *user* is any person who works for a business unit who uses [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Each user has a user account. All users must be associated with only one business unit. This association controls which customer data the user will have access to. Included in the user's account is information such as the user's telephone numbers, email address, and a link to the user's manager. Each user has privileges and rights to manage their own personal settings. Each user corresponds to a user in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] for that organization. When you create a user, you must assign the user to at least one security role. Even if the user is part of a team that has assigned roles, the user should be assigned to a role. For more information about access levels and roles, see [How Role-Based Security Can Be Used to Control Access to Entities In Dynamics 365 Customer Engagement (on-premises)](security-dev/how-role-based-security-control-access-entities.md).  

 A *team* is a group of users. Teams let users across an organization collaborate and share information. For more information about teams, see [Use Teams to Collaborate and Share Information](use-access-teams-owner-teams-collaborate-share-information.md).  

 Records can be owned by users or teams. Set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.OwnershipType> to <xref:Microsoft.Xrm.Sdk.Metadata.OwnershipTypes>.`UserOwned` or <xref:Microsoft.Xrm.Sdk.Metadata.OwnershipTypes>.`TeamOwned` to enable ownership. You can use the <xref:Microsoft.Crm.Sdk.Messages.ReassignObjectsOwnerRequest> message or the <xref:Microsoft.Crm.Sdk.Messages.ReassignObjectsSystemUserRequest> message to do bulk reassignment of all records for an owner.  

 The following illustration shows the entity relationships for users and teams.  

 ![User and team entity relationship diagram](media/crm-v5s-em-userteam.gif "User and team entity relationship diagram")  

## Users  
 In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], users can be disabled but they cannot be deleted. To find the user who is currently logged on or who is impersonated, call the <xref:Microsoft.Crm.Sdk.Messages.WhoAmIRequest> message.  

 The following table provides details about the significant attributes for the system user entity.  


|   Attribute name    |                                                                                                                                                                                                                                                                                                                              Description                                                                                                                                                                                                                                                                                                                              |
|---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     AccessMode      | Specifies the type of access that this user has to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. This is sometimes referred to as the type of user.<br /><br /> -   Administrative – The user has access to the Settings area but does not have access to the Sales, Marketing, and Service areas.<br />-   Non-Interactive – The user can access the system but only through the Web service.<br />-   Read – The user has read-only access.<br />-   Read-Write – The user has both read and write access.<br />-   Support User – The user was created by the [!INCLUDE[pn_Microsoft_Dynamics](../includes/pn-microsoft-dynamics.md)] support team. |
|       CalType       |                                                               Specifies the user’s license type.<br /><br /> -   Administrative – The user has administrative user rights.<br />-   Device Full – The user who is using the device running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] has both read and write access.<br />-   Device Limited – The user who is using the device running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] has only read access.<br />-   Full – The user has both read and write access.<br />-   Limited – The user has only read access.                                                                |
|     IsDisabled      |                                                                                                                                                                                                                                             Specifies whether the user is disabled. Only licensed users or users who have an access mode of support or non-interactive can be enabled. Support users cannot be disabled.                                                                                                                                                                                                                                              |
|     IsLicensed      |                                                                                                                                                                             Specifies whether the user is licensed. This applies to customers who access [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] through the [!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. This attribute is read-only, and is updated by the system.                                                                                                                                                                              |
| IsSyncWithDirectory |                                                                                                                                 Specifies whether the user is synchronized with the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] directory. This applies to customers who access [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] through the [!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. This attribute can only be set on create and is otherwise read-only.                                                                                                                                 |
|       QueueId       |                                                                                                                                                                                                                                                                                                               Specifies the default queue for the user.                                                                                                                                                                                                                                                                                                               |

 Access checks are additive. You can access entities based on the roles assigned to the user plus the roles assigned to the team that a user is a member of. This allows a user to have privileges outside their business unit.  

> [!NOTE]
>  A user's set of privileges is a union of privileges from the user's roles and privileges from all teams’ roles in which the user is a member.  


 Non-interactive users are often used when writing service-to-service code because they do not use up a license. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] allows for five free non-interactive users. To disable a non-interactive user, update the user record changing the `accessmode` value to any other value. The user will be disabled automatically.

## Community tools

**User Settings Utility** is a tool that XrmToolbox community developed for Dynamics 365 Customer Engagement (on-premises). Please see the [Developer tools](developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools.
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also  
 [Administration and Security Entities](administration-security-entities.md)   
 [Use Teams to Collaborate and Share Information](use-access-teams-owner-teams-collaborate-share-information.md)   
 [Team Entity](entities/team.md)   
 [Specify time zone settings for a user](specify-time-zone-settings-user.md)   
 [TeamTemplate Entity](entities/teamtemplate.md)   
 [SystemUser Entity](entities/systemuser.md)   
 [UserSettings Entity](entities/usersettings.md)   
 [Sample: Assign a Record to a Team](sample-assign-record-team.md)   
 [Sample: Create an On-Premises User](sample-create-on-premises-user.md)   
 [Sample: Disable a User](sample-disable-user.md)   
 [Sample: Share Records Using GrantAccess, ModifyAccess and RevokeAccess Messages](sample-share-records-using-grantaccess-modifyaccess-revokeaccess-messages.md)   
 [Sample: Share a record using an access team](sample-share-record-using-access-team.md)   
 [Blog: Service Accounts – Non-Interactive Users](https://go.microsoft.com/fwlink/p/?LinkId=234350)   
 [Privilege and Role Entities](privilege-role-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]