---
title: Customizations supported by the Conversation entity and form
description: Learn about the customizations that you can and can't use with the Conversation entity and form in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 02/14/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation entity and form

This article lists the customizations that you can and can't use with the Conversation entity and the Conversation form in Omnichannel for Customer Service.

## Customizations supported by the Conversation entity

You can create business rules.

You can't:

- Add new forms, views, fields, or charts.
- Edit existing views or fields. You can change some properties of `msdyn_title` and `msdyn_thirdpartyconversations`.
- Add a lookup field (a many-to-one relationship or a many-to-many relationship).

We recommend that you don't create alternate keys.

## Customizations supported by the Conversation form

You can:

- Add subgrids, although you can't show data for related entities. For example, you can add a subgrid that shows a list of all recordings, but you can't show the list of recordings that are related to that particular conversation.
- Edit existing forms in the following ways:
  - Modify the form layout, resize controls, and create tabs and sections
  - Move sections to different tabs
  - Add custom controls. However, we recommend that you don't use custom controls to update a conversation. Omnichannel for Customer Service overwrites updates when the conversation ends.
  - Edit the quick view for customers and cases
  - Remove the Recent cases subgrid
  - Add web resources and external website controls
  - Load the Customer summary form as an application tab instead of an anchor tab in a session

You can't:

- Add canvas apps

We also recommend that you don't:

- Change the Conversation form or the order in which it's displayed, since it's the default form
- Modify the out-of-the-box JavaScript handlers that are used in the Customer summary form

## Next steps

[Customize Customer summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  
