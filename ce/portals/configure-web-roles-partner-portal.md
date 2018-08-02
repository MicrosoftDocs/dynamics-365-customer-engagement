---
title: "Configure web roles for a partner portal in Dynamics 365  | MicrosoftDocs"
description: "Instructions to add web roles for a partner portal."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: d16d462a-2a7c-475f-a091-c88789abd75c
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Configure web roles for a partner relationship management (PRM) portal

Web roles for the Partner Relationship Management (PRM) portal grant specific access to the different areas of the portal. By assigning the appropriate roles, you can grant your primary partner contacts the right permissions to manage their team members and streamline their processes.

- **Partner administrator**: Partner administrators are contacts who serve as the primary contact for a partner account. They are responsible for adding and deactivating their team members and for any administrative activities related to their partner account information. Partner administrators can:
  - View, accept, and reject all distributed opportunities
  - View, manage, and perform actions on all managed opportunities
  - Manage partner account information, associated partner contacts, and their web roles
  - Manage partner contact roles Create and edit customer accounts
  - Create and edit customer contacts
  - Create and edit new opportunities
 
- **Partner manager**: Partner managers are contacts who manage opportunities distributed by the parent company. They are responsible for accepting or rejecting distributed opportunities and sharing accepted opportunities with team members. Partner managers can:
  - View, accept, and reject all distributed opportunities
  - View, manage, and perform actions on all managed opportunities
  - Manage partner account information
  - Create and edit customer accounts
  - Create and edit customer contacts
  - Create and edit new opportunities

- **Partner seller**: Partner sellers are contacts who manage and perform actions on opportunities. They can view and perform actions on opportunities that are shared with them, but will not be able to view opportunities that they are not associated with. Partner Sellers can:
  - View, manage, and perform actions on managed opportunities that have been shared with them
  - Create and edit customer accounts
  - Create and edit customer contacts
  - Create and edit new opportunities

## Create a partner account on a PRM portal
You can use partner accounts to keep track of your various partners. We recommend creating a separate account for each partner so that you can manage each partner organization separately. To create a partner account, 

1. Go to **Sales &gt; Accounts**.
2. Choose **New** and fill in your information.
3. In the **Partner Details** area, use the **Classification** field and select the Partner classification.
4. Select **Save**.

## Associate partner contacts with an account

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] contacts become partner contacts when they are associated with a partner account. To associate a contact with a partner account when creating or editing a contact, enter the name of a partner account in the Account Name field.

## Assign a permission set to a web role for portals
Website Access Permissions is a permission set, associated with a web role, that permits front-side editing of the various content managed elements within the portal other than just webpages. The permission settings determine which components can be managed in the portal. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create web roles for portals](create-web-roles.md)  

| Name                         | Description                                                                                                                                                                                                           |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Manage Content Snippets      | Allows the editing of Snippet controls. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Customize content by using content snippets](customize-content-snippets.md)                                                                 |  
| Manage Site Markers          | Allows the editing of hyperlinks that use [sitemarkers](#sitemarkers)                                                                                                                                                 |  
| Manage Web Link Sets         | Allows the editing of web link sets, including adding and removing web links from a web link set. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage web links in Dynamics 365 or on portals](manage-web-links.md) |  
| Preview Unpublished Entities | Allows the viewing of portal-exposed entities that have a publishing state of **Draft**.                                                                                                                              |
||

To add website access permission to a web role, just create a new Website Access entity, give it the permission set you want, name it, associate with the website in question, save, and then associate it with the web role(s) you desire.

### See also
[Control webpage access for portals](webpage-access-control.md)  
[Add record-based security using entity permissions for portals](assign-entity-permissions.md)  
[Create a partner account on a partner relationship management (PRM) portal](#create-a-partner-account-on-a-partner-relationship-management-prm-portal)  
[Create web roles for portals](create-web-roles.md)  
[Configure web roles for a PRM portal](configure-web-roles-partner-portal.md)
