---
title: Customizations supported by the Conversation table and form
description: Learn about the customizations that you can and can't use with the Conversation table and form in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/19/2023
ms.custom: bap-template
---
# Customizations supported by the Conversation table and form

This article lists the customizations that you can and can't use with the **Conversation** table (`msdyn_ocliveworkitem`) and the **Conversation** form in Omnichannel for Customer Service.

## Customizations supported by the Conversation table

The following table lists the supported customizations.

| Components  | Add new?   | Edit existing?    |
|------------ | ---------  | ----------------  |
| Form        |  No        |  Yes            |
| View        |  Yes       |  No              |
| Chart       |  Yes       |  No               |
| Column      |  Yes       |  No. But you can change some properties of `msdyn_title` and `msdyn_thirdpartyconversations`. |
| Dashboard   |  No        |  No               |

You can:

- Create business rules.

You can't:

- Add a Many to Many relationship.
- Use custom columns in unified routing or assignment.

We recommend that:

- You don't add a custom system-required column. If you intend to add the custom system-required column based on your business needs, then you populate the value for the custom system-required column via sync pre-validation or pre-operation plug-in to ensure its value isn't null.
- You don't create alternate keys.

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

[Customize Active Conversation form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation columns](developer/reference/entities/msdyn_ocliveworkitem.md)  
