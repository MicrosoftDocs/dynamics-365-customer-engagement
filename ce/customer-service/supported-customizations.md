---
title: Customizations supported by Conversation form and entity
description: Learn about the customizations that are supported by the Conversation form and entity in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 01/19/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation form and entity

This article lists the customizations supported by the Conversation form and entity in Omnichannel for Customer Service.

## Customizations supported by the Conversation form

You can customize the **Conversation** form to:
- Add subgrids on the Conversation form, though you won't be able to show data for any related entities. For example, you can add a subgrid on the Conversation form that shows a list of all recordings, but you can't show the list of recordings related to that particular conversation.
- Edit existing forms in the following ways:
    - Modify the form layout, resize controls, and create tabs and sections
    - Move sections to different tabs
    - Add custom controls. However, we recommend that you don't use custom controls to update a conversation as Omnichannel for Customer Service will overwrite the updates when the conversation ends.
    - Edit the quick view for customers and cases
    - Remove recent cases subgrid
    - Add web resources and external website controls 
    - Load **Customer Summary** form as an application tab instead of anchor tab in a session

> [!NOTE]
> - The **Conversation** form is the default form, and we recommend that you don't change the default form or the order in which it's displayed.
> - We recommend that you don't modify the out-of-the-box JavaScripts used in the **Customer Summary** form.
> - You can't add canvas apps.

## Customizations supported by the Conversation entity

You can create business rules on the Conversation entity. 
> [!NOTE]
> - You can’t add new forms, views, fields, or charts on the Conversation entity.
> - You can’t edit existing views or fields, but some properties of `msdyn_title` and `msdyn_thirdpartyconversations` can be changed.
> - You can’t add a lookup field (many-to-one relationship or many-to-many relationships) on the Conversation entity.
> - We don't recommend creating alternate keys.

## Next steps

[Customize Customer Summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  