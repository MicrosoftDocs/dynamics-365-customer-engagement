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

1. Make sure that you have the System Administrator, System Customizer, Sales Manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions. 
   Check your security role 
   - Follow the steps in [View your user profile](../basics/view-your-user-profile.md). 
   - Don’t have the correct permissions? Contact your system administrator. 

2. Go to **Settings** > **Security**. 
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




