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

Creating one to many relationship means that customers can add subgrids on the form. 
For example, customers can add a sub-grid on conversation form that shows a list of all cases but they can't show the list of only cases that are related to that particular conversation

yes, we can't add any data that is specific to that conversation record since the form is opened in create mode today

Also, for supporting custom controls - Adding custom controls are supported but any control that allows the user to update the conversation will not work as expected since any update made by the user using that control will be overwritten by OC flush once the conversation is ended





## Customizations supported by the Conversation form

You can customize the **Conversation** form to:
- Create one-to-many relationships. For example, you can add a subgrid on the Conversation form to show a list of all cases
- Edit existing forms in the following ways:
    - Modify the form layout, resize controls, and create tabs and sections
    - Move sections to different tabs
    - Add custom controls
    - Edit the quick view for customers and cases
    - Remove recent cases subgrid
    - Add web resources and external website controls 
    - Load **Customer Summary** form as an application tab instead of anchor tab in a session


## Next steps

[Conversation entity](developer/reference/entities/msdyn_ocliveworkitem.md)  
[Customize Customer Summary form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  
