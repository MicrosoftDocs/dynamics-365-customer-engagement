---
title: "How role-based security can be used to control access to entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "A role contains privileges that define a set of actions that can be performed within the organization. All users must be assigned to one or more predefined or custom roles"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fadb3c51-6fa8-4fd4-992c-d413e4cd9433
caps.latest.revision: 32
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# How role-based security can be used to control access to entities

In Dynamics 365 Customer Engagement (on-premises) the fundamental concept in role-based security is that a role contains privileges that define a set of actions that can be performed within the organization. For example, the salesperson role is assigned a set of privileges that are relevant to the performance of the tasks defined for that role. All users must be assigned to one or more predefined or custom roles. In Dynamics 365 Customer Engagement (on-premises), roles can also be assigned to teams. When a user or team is assigned to one of these roles, the person or team members are assigned the set of privileges associated with that role. A user must be assigned to at least one role.  

 A privilege authorizes the user to perform a specific action on a specific entity type. Privileges apply to an entire class of objects, rather than individual instances of objects. For example, if a user does not have the privilege to read accounts, any attempt by that user to read an account will fail. A privilege contains an access level that determines the levels within the organization to which a privilege applies. Each privilege can have up to four access levels: Basic, Local, Deep, and Global.  

<a name="bkmk_roles"></a>   
## Roles  
 Dynamics 365 Customer Engagement (on-premises) includes fourteen predefined roles that reflect common user roles with access levels defined to match the security best-practice goal of providing access to the minimum amount of business data required for the job. With these roles you can quickly deploy a Dynamics 365 Customer Engagement (on-premises) system without having to define your own roles. However, you can create custom roles using the predefined roles as a template, or you can define a new set of roles. For a list, see [List of Predefined Security Roles](how-role-based-security-control-access-entities.md#bkmk_list).  

 Each role is associated with a set of privileges that determines the user or team’s access to information within the company.  

 You can create roles within Dynamics 365 Customer Engagement (on-premises) and modify or remove these custom roles to fit your business needs. The roles you create for your business unit are inherited by all the business units in the hierarchy.  

 You can assign one or more roles to a user or to a team. For example, a user can have the Sales Manager role in addition to being a Customer Service Representative, in which case that user has all the privileges of both roles.  

 You cannot modify privileges at the user level, but you can create a new role with the desired privileges. For example, John is given a Salesperson role, which requires him to accept all leads assigned to him. However, the administrator wants John to be able to reassign leads assigned to him. As a result, the administrator either has to modify the Salesperson role to allow this or create a new role that incorporates this specific privilege and add John to this role. Creating a new role is the recommended option unless you think it necessary that all users who are assigned the Salesperson role now have this additional privilege.  

<a name="bkmk_privileges"></a>   
## Privileges  
 In Dynamics 365 Customer Engagement (on-premises), there are over 580 privileges that are predefined system-wide during setup. A privilege is a permission to perform an action in Dynamics 365 Customer Engagement (on-premises). Some privileges apply in general and some to a specific entity type.  

 Dynamics 365 Customer Engagement (on-premises) uses privileges as the core of the underlying security check. Privileges are "built in" to the product and are used throughout the application and platform layers. You cannot add or remove privileges, or change how privileges are used to grant access to certain functionality, but you can construct new roles from the existing privilege set.  

 Each role defines a set of privileges that determines the user or team's access to information within the company. The platform checks for the privilege and rejects the operation if the user does not   have the necessary privilege. A privilege is combined with a depth or access level.  

 For example, the Salesperson role could contain the privileges `Read Account` with `Basic` access and `Write Account` with `Basic` access, whereas the Sales Manager role might contain privileges like `Read Account` with `Local` access and `Assign Contact` with `Local` access.  

 Most entities have a set of possible privileges that can be added to a role that correspond to the various actions you can take on the records of that entity time. 

 Each action in the system, and each message described in the SDK documentation, requires one or more privileges to be performed.  

<a name="bkmk_access"></a>   
## Access levels  
 The access level or privilege depth for a privilege determines, for a given entity type, at which levels within the organization hierarchy a user can act on that type of entity.  

 The following table lists the levels of access in Dynamics 365 Customer Engagement (on-premises), starting with the most access. The icon is shown in the security role editor in the Web application.  

|||  
|-|-|  
|![Access level global](../media/access-level-global.gif "Access level global")|**Global**. This access level gives a user access to all records within the organization, regardless of the business unit hierarchical level to which the instance or the user belongs. Users who have Global access automatically have Deep, Local, and Basic access, also.<br /><br /> Because this access level gives access to information throughout the organization, it should be restricted to match the organization's data security plan. This level of access is usually reserved for managers with authority over the organization.<br /><br /> The application refers to this access level as **Organization**.|  
|![Access level deep](../media/access-deep.png "Access level deep")|**Deep**. This access level gives a user access to records in the user's business unit and all business units subordinate to the user's business unit.<br /><br /> Users who have Deep access automatically have Local and Basic access, also.<br /><br /> Because this access level gives access to information throughout the business unit and subordinate business units, it should be restricted to match the organization's data security plan. This level of access is usually reserved for managers with authority over the business units.<br /><br /> The application refers to this access level as **Parent: Child Business Units**.|  
|![Access level local](../media/access-local.gif "Access level local")|**Local**. This access level gives a user access to records in the user's business unit.<br /><br /> Users who have Local access automatically have Basic access, also.<br /><br /> Because this access level gives access to information throughout the business unit, it should be restricted to match the organization's data security plan. This level of access is usually reserved for managers with authority over the business unit.<br /><br /> The application refers to this access level as **Business Unit**.|  
|![Access level basic](../media/access-level-basic.gif "Access level basic")|**Basic**.<br /><br /> This access level gives a user access to records he or she owns, objects that are shared with the user, and objects that are shared with a team of which the user is a member.<br /><br /> This is the typical level of access for sales and service representatives.<br /><br /> The application refers to this access level as **User**.|  
|![Access level none](../media/access-level-none.gif "Access level none")|**None**. No access is allowed.|  

<a name="bkmk_all"></a>   
## Putting it all together  

-   If a user has the `Deep Read Account` privilege, this user can read all accounts in his or her business unit, and all accounts in any child business unit of that business unit.  

-   If a user has `Local Read Account` privileges, this user can read all accounts in the local business unit.  

-   If a user is assigned the `Basic Read Account` privilege, this user can read only the accounts that he or she owns or the accounts that are shared with him or her.  

-   A customer service representative with the `Basic Read Account` privilege can view accounts that he or she owns and any accounts another user has shared with this user. This makes it possible for the representative to read the account data that is relevant to a service request, but not to change the data.  

-   A data analyst with the `Local Read Account` privilege can view account data and run account-related reports for all accounts in his or her business unit.  

-   A finance officer for the company with the `Deep Read Account` privilege can view account data and run account-related reports for all accounts in his or her business unit and accounts in any child business unit.  

<a name="bkmk_list"></a>   

## List of predefined security roles  

 The following table lists the predefined set of roles that are included.  


|                                       |                                                                                                                                      |
|---------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------|
|                 Role                  |                                                             Description                                                              |
|         CEO-Business Manager          |                                 A user who manages the organization at the corporate business level.                                 |
|              CSR Manager              |                              A user who manages customer service activities at the local or team level.                              |
| Customer Service Representative (CSR) |                                        A customer service representative (CSR) at any level.                                         |
|               Delegate                |                                       A user who is allowed to act on behalf of another user.                                        |
|           Marketing Manager           |                                 A user who manages marketing activities at the local or team level.                                  |
|        Marketing Professional         |                                         A user engaged in marketing activities at any level.                                         |
|             Sales Manager             |                                   A user who manages sales activities at the local or team level.                                    |
|              Salesperson              |                                                     A salesperson at any level.                                                      |
|           Schedule Manager            |                                           A user who schedules appointments for services.                                            |
|               Scheduler               |                                 A user who manages services, required resources, and working hours.                                  |
|             Support User              |                                              A user who is a customer support engineer.                                              |
|         System Administrator          |                                     A user who defines and implements the process at any level.                                      |
|           System Customizer           | A user who customizes [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] entities, attributes, relationships, and forms. |
|      Vice President of Marketing      |                                 A user who manages marketing activities at the business unit level.                                  |
|        Vice President of Sales        |                                A user who manages the sales organization at the business unit level.                                 |

### See also  
 [The Security Model of Microsoft Dynamics 365 Customer Engagement (on-premises)](../security-dev/security-model.md)   
 [Privilege and Role Entities](../privilege-role-entities.md)     
 [Use record-based security to control access to records](../security-dev/use-record-based-security-control-access-records.md)   
 [How Field Security Can Be Used to Control Access to Field Values In Microsoft Dynamics 365 Customer Engagement (on-premises)](../security-dev/use-field-security-control-access-field-values.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]