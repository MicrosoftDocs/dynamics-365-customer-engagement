---
title: "Manage Dynamics 365 for Customer Engagement apps teams | MicrosoftDocs"
ms.custom: 
ms.date: 03/15/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 5355ef54-ce27-4383-bf21-1419c71f4cc4
caps.latest.revision: 29
mms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Manage teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

Using teams in Dynamics 365 for Customer Engagement apps is optional. However, teams provide an easy way to share business objects and let you collaborate with other people across business units. While a team belongs to one business unit, it can include users from other business units. You can associate a user with more than one team. 
  
You can use three types of teams: 
  
- An *owner* team owns records and has security roles assigned to the team. The team’s privileges are defined by these security roles. In addition to privileges provided by the team, team members have the privileges defined by their individual security roles and team member’s privilege inheritance roles (add link to the security role topic), and by the roles from other teams in which they are members. A team has full access rights on the records that the team owns. Team members are added manually to the owner team. 

- An Azure Active Directory (AAD) *group* team. Similar to owner team, an AAD group team can own records and can have security roles assigned to the team. There are two *group* team types and they correspond directly to the AAD group types – Security and Office. Team members are dynamically derived (added and removed) when they access the instance based on their AAD group membership.  
  
- An *access* team doesn’t own records and doesn’t have security roles assigned to the team. The team members have privileges defined by their individual security roles and by roles from the teams in which they are members. The records are shared with an access team and the team is granted access rights on the records, such as Read, Write, or Append. 
  
## Owner/Group team or access team? 

Choosing the type of the team may depend on the goals, nature of the project, and even the size of your organization. There are a few guidelines that you can use when choosing the team type. 

### When to use owner or group teams 

- Your organization’s policies require the ability for records to be owned by entities other than users, such as the team entity. 
- The number of teams is known at the design time of your Dynamics 365 for Customer Engagement apps system. 
- Daily reporting on progress by owning teams is required. 

### When to use access teams 

- The teams are dynamically formed and dissolved. This typically happens if the clear criteria for defining the teams, such as established territory, product, or volume are not provided. 
- The number of teams is not known at the design time of your Dynamics 365 for Customer Engagement apps system. 
- The team members require different access rights on the records. You can share a record with several access teams, each team providing different access rights on the record. For example, one team is granted the Read access right on the account and another team, the Read, Write, and Share access rights on the same account. 
- A unique set of users requires access to a single record without having an ownership of the record. 

## About owner teams 

An owner team can own one or more records. To make a team an owner of the record, you must assign a record to the team.

While teams provide access to a group of users, you must still associate individual users with security roles that grant the privileges they need to create, update, or delete user-owned records. These privileges can't be applied by assigning security roles to a team and then adding the user to that team. If you need to provide your team members the team privileges directly without their own security role, you can assign the team a security role that has Member’s privilege inheritance. (link to security role)

If an owner team doesn’t own records and doesn’t have security roles assigned to the team, it can be converted to an access team. It is a one-way conversion. You can’t convert the access team back to the owner team. During conversion, all queues and mailboxes associated with the team are deleted. When you create a team in the Web application, you have to choose the team type **Owner**.

For more information, see [Assign a record to a user or team](../basics/assign-record-user-team.md).

## Create an owner team

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions.
   
   Check your security role:
   - Follow the steps in [View your user profile](../basics/view-your-user-profile.md).
   - Don’t have the correct permissions? Contact your system administrator.

2. Go to **Settings** > **Security**. In Microsoft Dynamics 365 for Outlook, go to **Settings** > **System** > **Security**.

3. Select **Teams**.

4. On the Actions toolbar, select the **New** button.

5. Enter a Team Name.

6. Select a Business Unit.

7. Enter an Administrator.

8. Select **Owner** in Team Type.

9. Complete other required fields, and then select **Save**.

   If you don’t select the business unit to which the team will belong, by default, the root business unit is selected. The root business unit is the first business unit created for an organization.

## Edit an owner team

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions.
   
   Check your security role:
   - Follow the steps in View your user profile.
   - Don’t have the correct permissions? Contact your system administrator.

2. Go to **Settings** > **Security**. In Dynamics 365 for Outlook, go to **Settings** > **System** > **Security**.

3. Select **Teams**.

4. In the **Teams** dropdown list, select **All Owner Teams** or another appropriate view.

5. In the grid, select the team you want to edit.

6. On the Actions toolbar, select **Edit**, change the desired fields, and then select **Save**.

## About group teams

Applies to Dynamics 365 for Customer Engagement apps version 9.x (online only)

A group team can own one or more records. To make a team an owner of the record, you must assign the record to the team.

While teams provide access to a group of users, you must still associate individual users with security roles that grant the privileges they need to create, update, or delete user-owned records. These privileges can't be applied by assigning security roles to a team and then adding the user to that team. If you need to provide your team members the team privileges directly without their own security role, you can assign the team a security role that has Member’s privilege inheritance. (link to security role) 

For more information, see [Assign a record to a user or team](../basics/assign-record-user-team.md).

### Group Team members are automatically added/removed when the user team member accesses the application

When group team members log into the instance, they are dynamically added/removed from the AAD Group team based on their membership in the AAD Group.  Team members of the AAD Group automatically inherit the privileges of the AAD Group’s security role when performing transactions.

## Create a group team

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions.

   Check your security role:
   - Follow the steps in View your user profile.
   - Don’t have the correct permissions? Contact your system administrator.

   Pre-requisites:
   1.	An Azure Active Directory (AAD) Group is required for each group Team.
   2.	Obtain the AAD Group’s ObjectID from your https://portal.azure.com site.
   3.	Create a custom security role that contains privileges as per your team’s collaboration requirement.  Please see Security role member’s inherited privileges if you need to extend the team members’ privileges directly to user.

2. Go to **Settings** > **Security**. In Microsoft Dynamics 365 for Outlook, go to **Settings** > **System** > **Security**.

3. Select **Teams**.

4. On the Actions toolbar, select the **New** button.

5. Enter a Team Name 

6. Select a Business Unit (only the default root Business Unit is allowed).

7. Enter an Administrator.

8. Select the Team Type (a drop-down list will be displayed).

9. Select **AAD Security** or **Office group** (this must match to the AAD Group type).

10.	Enter the respective Azure AD ObjectID of the AAD Security or Office group.

11. Select **Save**. 
    
    If you don’t select the business unit to which the team will belong, by default, the root business unit is selected. The root business unit is the first business unit created for an organization.

## Edit a group team

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions.
   
   Check your security role:
   - Follow the steps in View your user profile.
   - Don’t have the correct permissions? Contact your system administrator.

2. Go to **Settings** > **Security**. In Dynamics 365 for Outlook, go to **Settings** > **System** > **Security**.

3. Select **Teams**.

4. In the **Teams** dropdown list, select **All AAD Office or Security Teams**.

5. In the grid, select the team you want to edit.

6. On the Actions toolbar, select **Edit**, change the desired fields, and then select **Save**.

> [!NOTE]
> The list of Team members listed in each group team only displays the user members who have accessed the instance. This list doesn’t show all the group members of the AAD group.

## About access teams and team templates

You can create an access team manually by choosing the team type Access, or let the system create and manage an access team for you. When you create an access team, you can share multiple records with the team.

A system-managed access team is created for a specific record, other records can’t be shared with this team. You have to provide a team template that the system uses to create a team. In this template, you define the entity type and the access rights on the record that are granted to the team members when the team is created.

A team template is displayed on all record forms for the specified entity as a list. When you add the first user to the list, the actual access team for this record is created. You can add and remove members in the team by using this list. The team template applies to the records of the specified entity type and the related entities, according to the cascading rules. To give team members different access on the record, you can provide several team templates, each template specifying different access rights. For example, you can create a team template for the Account entity with the Read access right, which allows the team members to view the specified account. For another team that requires more access to the same account, you can create a team template with Read, Write, Share and other access rights. To be added to the team, a minimum access level a user must have on the entity specified in the template is Basic (User) Read.

Because of the parental relationship between the team template and system-managed access teams, when you delete a template, all teams associated with the template are deleted according to the cascading rules. If you change access rights for the team template, the changes are applied only to the new auto-created (system-managed) access teams. The existing teams are not affected.

> [!NOTE]
> A user must have sufficient privileges to join an access team. For example, if the access team has the Delete access right on an account, the user must have the Delete privilege on the Account entity to join the team. If you’re trying to add a user with insufficient privileges, you’ll see this error message: “You can’t add the user to the access team because the user doesn’t have sufficient privileges on the entity.”

For the step-by-step instructions on how to create a team template and add it the entity form, see the article in the [Create a team template and add to an entity form](create-team-template-add-entity-form.md).

## Maximum settings for system-managed access teams

The maximum number of team templates that you can create for an entity is specified in the `MaxAutoCreatedAccessTeamsPerEntity` deployment setting. The default value is 2. The maximum number of entities that you can enable for auto-created access teams is specified in the `MaxEntitiesEnabledForAutoCreatedAccessTeams` deployment setting. The default value is 5. You can use the `Set-CrmSetting` Windows PowerShell command to update this value. 
