---
title: Customizations supported by Conversation entity and form
description: Learn about the customizations that are supported by the Conversation entity and form in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 01/19/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation entity and form

This article lists the customizations supported by the Conversation entity and form in Omnichannel for Customer Service.

## Customizations supported by the Conversation entity

You can create business rules on the Conversation entity. 


Here are a few actions that aren't supported on the Conversation entity:
- You can’t add new forms, views, fields, or charts on the Conversation entity.
- You can’t edit existing views or fields, but some properties of `msdyn_title` and `msdyn_thirdpartyconversations` can be changed.
- You can’t add a lookup field (many-to-one relationship or many-to-many relationship) on the Conversation entity.

We recommend that you don't create alternate keys. 

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
    - Load **Customer summary** form as an application tab instead of anchor tab in a session


However, you can't add canvas apps. We also recommend that:
- You don't change the **Conversation** form or the order in which it's displayed, as it's the default form.
- You don't modify the out-of-the-box JavaScript handlers used in the **Customer summary** form.

## Next steps

[Customize Customer summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  