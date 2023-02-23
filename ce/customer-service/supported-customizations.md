---
title: Customizations supported by the Conversation entity and form
description: Learn about the customizations that you can and can't use with the Conversation entity and form in Omnichannel for Customer Service.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 03/14/2023
ms.custom: bap-template
---

# Customizations supported by the Conversation entity and form

This article lists the customizations that you can and can't use with the **Conversation** entity (`msdyn_ocliveworkitem`) and the **Conversation** form in Omnichannel for Customer Service.

## Customizations supported by the Conversation entity


| Components  | Add new?   | Edit existing?    |
|------------ | ---------  | ----------------  |
| Form        |   No       |   Yes             |
| View        |  Yes       |  No               |
| Chart       |  Yes       |  No               |
| Field       |  Yes       |   No, but you can change some properties of `msdyn_title` and `msdyn_thirdpartyconversations`            |
| Dashboard   |  No        |  No               |
||||

You can:
- Create business rules.
- Associate a conversation with a lead or opportunity, or any other entity that's enabled for unified routing

You can't:
- Add a lookup field for a many-to-many relationship. 
- Use custom fields in unified routing or assignment.

We recommend that:
- You don't use system-required fields. You can set a default value via a sync or async plug-in, but ensure that flush or insert calls don't fail after you set the default value.
- You don't create alternate keys. 

## Customizations supported by the Conversation form

You can:
- Add subgrids on the Conversation form and view data for related entities in the subgrid.
- Load the **Customer summary** form as an application tab instead of an anchor tab in a session.


- Edit existing forms in the following ways:
    - Add custom fields and allow save of custom fields on the form.
    - Add custom controls. However, we recommend that you don't use custom controls to update any out-of-the-box field on the **Conversation** form.  Omnichannel for Customer Service overwrites updates when the conversation ends. 
    - Add canvas apps, web resources and external website controls.
    - Modify the form layout, resize controls, and create tabs and sections.
    - Edit the quick view for customers and cases.
    - Render fields with values on the form.
    - Move sections to different tabs.
    - Remove **Recent cases** subgrid.

You can't:
- Change the **Conversation** form or the order in which it's displayed, since it's the default form.
- Modify the out-of-the-box JavaScript handlers used in the **Customer summary** form.

## Next steps

[Customize Customer summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  
