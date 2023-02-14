---
title: Customizations supported by Conversation entity and form
description: Learn about the customizations that are supported by the Conversation entity and form in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 03/17/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation entity and form

This article lists the customizations supported by the **Conversation** entity and form in Omnichannel for Customer Service.

## Customizations supported by the Conversation entity

You can customize the **Conversation** entity to:
- Create business rules on the entity.
- Create new custom fields, views, and charts
- Associate a conversation with a lead or opportunity, or any other entity that's enabled for activity.
- Prevent OC flush from overwriting changes made to custom fields on the form by agent.

Here are a few actions that aren't supported on the **Conversation** entity:
- You can't create new forms.
- You can’t edit existing views or fields, but some properties of `msdyn_title` and `msdyn_thirdpartyconversations` can be changed.
- You can’t add a lookup field (many-to-one relationship or many-to-many relationship) on the Conversation entity.
- You can't use custom fields in unified routing or assignment.

We recommend that you don't create alternate keys. 

## Customizations supported by the Conversation form

You can customize the **Conversation** form to:
- Add subgrids on the Conversation form, though you won't be able to show data for any related entities. For example, you can add a subgrid on the Conversation form that shows a list of all recordings, but you can't show the list of recordings related to that particular conversation.
- Load **Customer summary** form as an application tab instead of anchor tab in a session
- Edit existing forms in the following ways:
    - Add custom fields and allow save of custom fields on the form
    - Add custom controls. However, we recommend that you don't use custom controls to update a conversation as Omnichannel for Customer Service will overwrite the updates when the conversation ends. 
    - Add canvas apps, web resources and external website controls
    - Modify the form layout, resize controls, and create tabs and sections
    - Edit the quick view for customers and cases
    - Render fields with values on the form
    - Move sections to different tabs
    - Remove recent cases subgrid

We recommend that:
- You don't change the **Conversation** form or the order in which it's displayed, as it's the default form.
- You don't modify the out-of-the-box JavaScript handlers used in the **Customer summary** form.

## Next steps

[Customize Customer summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  