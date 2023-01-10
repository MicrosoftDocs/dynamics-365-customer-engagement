---
title: Customizations supported by Conversation entity and form
description: Learn about the customizations that are supported by the Conversation entity and form in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.service: dynamics-365 
ms.topic: conceptual 
ms.date: 01/11/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation entity and form

This article lists the customizations supported by the Conversation entity and form in Omnichannel for Customer Service.

## Customizations supported by the Conversation entity

You can create business rules on the Conversation entity.

## Customizations supported by the Conversation form

You can customize the **Conversation** form to:
- You can add subgrids on the Conversation form, though you won't be able to show data for any related entities. For example, you can add a subgrid on the Conversation form that shows a list of all cases, but you cannot show the list of cases related to that particular conversation.
- Edit existing forms in the following ways:
    - Modify the form layout, resize controls, and create tabs and sections
    - Move sections to different tabs
    - Add custom controls. However, we recommend that you don't use custom controls to update a conversation as Omnichannel for Customer Service will overwrite the updates when the conversation ends.
    - Edit the quick view for customers and cases
    - Remove recent cases subgrid
    - Add web resources and external website controls 
    - Load **Customer Summary** form as an application tab instead of anchor tab in a session


## Next steps

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  
[Customize Customer Summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  
