---
title: "Create web roles for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to create web roles for a portal."
ms.custom: ""
ms.date: 05/25/2018
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: b7c5de43-6df7-46ef-9991-5df090b6c965
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Create web roles for portals
After a contact has been configured to use the portal, it must be given one or more web roles to perform any special actions or access any protected content on the portal. For example, to access a restricted page, the contact must be assigned to a role to which read for that page is restricted to. To publish new content, the contact must be placed in a role which is given content publishing permissions.

To create a web role:

1. Go to **Portals** > **Web Roles** > **New**.
3. Specify values for the required fields.
4. Select **Save**.

## Attributes and relationships

The table below explains the Web Role attributes used by [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals.

| Name                     | Description                                                                                                                                                                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name                     | The descriptive name of the Web Role                                                                                                                                                                                                            |
| Website                  | The associated website                                                                                                                                                                                                                          |
| Description              | An explanation of the Web Role's purpose. Optional.                                                                                                                                                                                             |
| Authenticated Users Role | Boolean. If set to true, this will be the default web role for authenticated users (see below). Only one Web Role with the Authenticated Users Role attribute set to true should exist for a given website. This will be the default web role for authenticated users that have not been assigned a web role. |
| Anonymous Users Role     | Boolean. If set to true, this will be the default web role for unauthenticated users (see below). Only one Web Role with the Anonymous Users Role attribute set to true should exist for a given website. This will be the default web role for unauthenticated users. The Anonymous Users Role will only respect Entity Permissions.| 
|| 

Now that the Web Role has been created, you will be able to configure it to meet your needs via various permissions, rules, and associations.

- **Optional default web role for authenticated users**: By enabling the **Authenticated Users Role**, it will become the default web role for all users. This role is commonly used to provide a predetermined access for users that are not associated to any other roles. Keep in mind that users can have multiple web roles, but there can only be one Authenticated Users web role for authenticated users.
- **Optional default web role for unauthenticated users**: The **Anonymous Users Role** is intended to be used with Entity Permissions. It will not respect any other rules or permissions. By enabling the "Anonymous Users Role" it will become the default web role for all users. There can only be one Anonymous Users web role for unauthenticated users.

### See also

[Engage with communities by using the community portal](engage-with-communities.md)  
[Configure a Dynamics 365 portal](configure-portal.md) 
[Control webpage access for portals](webpage-access-control.md)  
[Configure web roles for a PRM portal](configure-web-roles-partner-portal.md) 
[Add record-based security by using entity permissions for portals](assign-entity-permissions.md) 
