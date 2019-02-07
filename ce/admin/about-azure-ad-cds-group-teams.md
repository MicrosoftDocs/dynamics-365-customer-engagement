---
title: "About Azure Active Directory Common Data Service Group Teams | MicrosoftDocs"
ms.custom: 
  - dyn365-deflc
ms.date: 02/10/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 7e8b84a7-ae29-4180-94f5-5d89fc43bdbc
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# About Azure Active Directory Common Data Service Group Teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The Owner team security model is now extended to allow the association of Azure Active Directory (AAD) Groups.  Two new team types are created to correspond to the AAD Security and Office groups.  These new team types work similarly to the Owner team except the team members are derived from the AAD Security and/or Office groups during runtime. 

As with Owner team, you can assign security roles to the new teams. The same policies for owner team are applied to the new teams where team members have privileges as defined by their individual security roles plus the privileges as defined by the team security roles.  The system automatically performs a transaction request based on the privileges as defined in the individual user’s security role and if the privileges are not found in this security role, it will then use the privileges as defined in the team’s security roles.  When a transaction was performed using the team’s privileges, the record can be accessed by all team members.  The team has full access rights on the records that the team owns. 

## When to use AAD Group teams 

- Your organization’s policies require the ability for records to be owned by entities other than users, such as the team entity. 
- Group team members are dynamic based on AAD group membership. 
- Only group members are added to the teams when they accessed the instance, group team members who don’t access the organization are not added. 
- Members are removed from the team when they are deleted from the AAD Group. 
- Replace the need to use a Security Group to manage who needs to be synced to an organization. 
- Daily reporting on progress by owning teams is required. 

## Create an AAD Group team 

Pre-requisites: 

1. An Azure Active Directory (AAD) Group is required for each Team. 
2. Obtain the AAD Group’s ObjectID from your https://portal.azure.com site
3. Create a custom security role that contains privileges as per your team’s collaboration requirement.  Please see Security role’s inherited privileges if you need to extend the team members’ privileges directly to user. 

Log into the instance that you need to create the team. 

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions. <br/> 
   Check your security role: 
   - Follow the steps in [View your user profile](../basics/view-your-user-profile.md). 
   - Don’t have the correct permissions? Contact your system administrator. 

2. Go to **Settings** > **Security**. <br/>
   (In Microsoft Dynamics 365 for Outlook, go to **Settings** > **System** > **Security**.) 

3. Click **Teams**.

4. On the Actions toolbar, select the **New** button. 

5. Enter a Team name. 

6. Select a business unit (only the default root business unit is allowed at this time). 

7. Enter an administrator. 

8. Choose the **Team Type** and select AAD Security (or Office) group.

9. Enter the respective Azure AD ObjectID of the AAD Security (or Office) group.

10. Select **Save**. 
    If you don’t select the business unit to which the team will belong, by default, the root business unit is selected. The root business unit is the first business unit created for an organization. 

## Assign a security role to the AAD Group team 

1. On the current Team form that you just saved, select **Manage Roles** on the ribbon.
2. Select the security role that was created for the team.
3. Select **OK**.

## Team members are dynamically added/removed during runtime 

When team members log into the instance, they are dynamically added/removed from the AAD Group team based on their membership in the AAD Group.  Team members of the AAD Group automatically inherit the privileges of the AAD Group’s security role when performing transactions. 

Team members are also automatically created in the instance if they have not already been synced into the instance.  A default security role is assigned to the user during the user record creation.  The default security role is based on the user license and instance type, eg for CDS default environment, the CDS User security role is assigned. 

## Security role’s inherited privileges 

image

### Privileges

The concept of a privilege in Dynamics CRM is an important one as privileges are used to define the entitlement to perform an action as well as the range of records against which that privilege applies.   

The privilege itself defines either: 
- A type of record and the type of action that can be performed on that record, such as write permission to the Account entity. 
- Or an action the user can perform in Dynamics CRM, such as actions in a CRM mobile app.  

The level of a privilege defines the scope of that privilege. 
- Basic: Applies to records owned by the user or team that the privilege is linked to. 
- Local: Applies to records in the same business unit as the security principal that the privilege is linked to. 
- Deep: Applies to records in the same business unit as the security principal that the privilege is linked to or any of the child business units. 
- Organization: Applies to all records in the organization.  

Security roles are used to manage collections of related privileges, which can then be assigned collectively to a security principal. The security principals are either a user or a team.   

Security roles, therefore, are intended to assist with the process of administration and granting of privileges, not to grant rights to users directly. A scenario that often comes up in customization design is how to check whether a user is entitled to perform a particular action, perhaps a custom action. While it may be tempting to check a user for a security role, an approach that is better aligned with the way that the platform works is to check whether the user has a particular privilege granted by using a security role. As will be shown later, privileges granted to a user are cached. There are many standard mechanisms of the product that allow a privilege to be directly checked. Using privileges rather than roles to control a particular action is a more efficient way to manage a user’s activity in the application.   

The privileges for a security role apply to the security principal they are linked to. 
- If actions and the related privileges directly apply to or on behalf of a user, the user needs those privileges granted directly. For example: 
  - When logging onto the system it is the user that is logging on and therefore the user that needs the initial privileges for access. 
  - Providing owner privileges to a team security role doesn’t apply to the records the user owns even if the user is a member of that team.  
  - If the security role is linked to a team, that privilege applies to the team, and is therefore applied in the context of that team.   

This becomes especially important to differentiate where providing owner privileges to a team security role doesn’t give access to the records the user owns, even if the user is a member of that team. 
- Where the privileges can equally apply to the user or the team, but having one does not infer the other: o Create privileges at a basic scope for a team means that records can be created with the team as the owner. 
  - But for the user to also be able to create records they own, that user must have Create privileges at a basic scope through their own security roles. The Team basic scope creation privilege to create records owned by the team does not infer the User basic scope creation privilege to create records owned by the user. 
- Where the privileges do not apply equally to a user or team. For example, only a user can sign in to the system or access views in the UI: 
  - Privileges for these user actions need to be held in a security role linked to the user, not in a team security role, where the actions are not applicable to the team. 

In the following example, although the user is granted read and write privileges as part of their team membership, this only applies to records that the team itself can access through ownership by the team. This therefore applies to Record Y and means the user can read or write Record Y.  This doesn’t, however, also automatically grant privileges directly to the user to records they can access directly. The user can therefore access Record X through their own direct read privileges, but this doesn’t mean they can write to that record because they don’t have write privileges directly as the user and they don’t inherit write privileges to records they own themselves from team assigned privileges.   

Business Unit 

Owner 
Business Unit 
TeamTeam Member 
Privilege: Read, Write 
Scope: Basic ( Owner)Privilege : Read Scope: Basic (Owner) Owner 
Record X 
Record Y 

We will examine some scenarios that highlight these concepts but also clarify some of the considerations needed when defining privilege models.  

Minimum privileges for signing in Before the user can act on any broader data, as part of signing in a minimum set of permissions are required for the user to be simply able to access the system itself. These privileges are required to be granted directly to the user through a security role assigned to the user. They can’t be inherited from a team security role because it’s the user, and not the team, who is accessing the system. These minimum privileges for access are: 
- When signing in to Microsoft Dynamics CRM: 
  - To render the home page, assign the following privileges on the Customization tab: Read Web Resource, Read Customizations.  
  - To render an entity grid (that is, to view lists of records and other data): Read privilege on the entity, Read User Settings on the Business Management tab, and Read View on the Customization tab. 
  - To view single entities in detail: Read privilege on the entity, Read System Form on the Customization tab, Create and Read User Entity UI Settings on the Core Records tab.  
- When signing in to Microsoft Dynamics CRM for Outlook: 
  - To render navigation for Dynamics CRM and all Dynamics CRM buttons: Read Entity and Read View on the Customizations tab. 
  - To render an entity grid: Read privilege on the entity, Read Customizations and Read Web Resource on the Customization tab, and Read Saved View on the Core Records tab. 
  - To render entities: Read privilege on the entity, Read System Form on the Customization tab, and Create, Read, and Write User Entity UI Settings on the Core Records tab.

These minimum privileges are documented in the TechNet article, Create or edit a security role.  

Basic creation assigned to the creating user Creating a record assigned to the current user highlights the core creation privileges required for creation as shown in the following diagram.  

To create a record a user needs, at least, the following privileges. 
- Definitely required • Create, Read: Basic scope 
- Need the ability to create and view the created record. 
- Because the record will be owned by the creating user only, Basic (or Owner) scope is required for these privileges. If a user has a deeper scope of privilege, such as Local/Deep/Organization, this would also work. However, at least Basic level of scope is required. 
- May be required • Append: Basic scope 
- If this record is linked to other records, Append privilege is also needed.  

  Privilege: Create, Read, Append, AppendTo (if any records linked to this one) 
  Scope: Basic ( i.e. owner) 
  AppendTo: on any related records, linked to this 

- Append To: 
- If other records are linked to this one, AppendTo is also required.
- The scope would depend where the other records exist. If the other records are also owned by the same user, Basic scope would suffice. If the records are in another business unit, wider permissions are needed, such as Organization scope, or via a team.  

Creation of a record assigned to another owner Creating a record assigned to a different user highlights the need to consider these privileges:  
1. The rights to create a record.  
2. The ownership privileges in cases where the record needs to be assigned to a different user.  The following diagram shows the privileges needed by both the creating user and the user set as the owner.   

Creating a record for another user requires privileges for both:  
- The creator: confirming what and where they can create data. 
- The person who is set as the owner: confirming they are entitled to own this data.  

If we look at those two cases separately, each user would need: 
- Creator: To create a record a user needs the same privileges as when creating the record for themselves, but differently scoped.  

Business Unit 
Privilege: Create, Read, Append, AppendTo (if any records linked to this one) 
Scope: Local ( i.e. business unit) 
AppendTo: on any related records, linked to this 
Creator 
Privilege: Read 
Scope: Basic (i.e. owner) 
Owner 

- Instead of only “Basic” scoped data, the user needs “Local” scoped data to reflect that the data will be created in the same business unit rather than for them as the owner. 
- Definitely required 
- Create, Read: Local scope. 
- May be required 
- Append: Local scope. 
- Append To: Scope dependent on record location. 
- Owner: 
- To own data the privileges the owner requires are: 
- Read: Basic scope (as they will be the owner).  




