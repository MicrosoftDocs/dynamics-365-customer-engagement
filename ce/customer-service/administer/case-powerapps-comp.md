---
title: Add Power Apps components to case management forms 
description: Learn how to add the right Power Apps components to case management forms.
author: gandhamm 
ms.author: v-slaik
ms.reviewer: neeranelli 
ms.topic: conceptual 
ms.date: 03/03/2025
ms.custom: bap-template 
---

# Add Power Apps components to case forms

You can customize case forms using the default Power Apps components. Learn more in [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


The following tables lists the components that can be added to case forms and the behavior in real-time.

|Number |Component |Description |Additional information|
|-------|----------|------------|-------|-------------------|----------------------|
|1 |**Status reason transitions** |Allows you to define what the customer service representatives (service representatives or representatives) can change the status reason value to, for each status reason. |[Define status reason transitions for case management](define-status-reason-transitions-case-management.md#add-status-reason-transition)|
|2 |**Customer 360** |Enables service representatives to view customer details for a case as a card on the form. |  [Configure components to display customer details and recent records](add-display-components-to-case-form.md#add-the-customer-360-component-to-a-case-form)| 
|3 |**Recent records** |Allows representatives to view and access related customer records for a case as a card on the form. |[Configure components to display customer details and recent records](add-display-components-to-case-form.md#add-the-recent-records-component)|
|4 |**Case handling time widget** |Representatives can see the case handling time widget on the form. |[Configure case handling time widget to case forms](add-case-handling-time.md#enable-case-handling-time-widget)|  
|5 |**Redirect user to the specified tab to close open activities** |Displays a redirect link on the warning message when representatives attempt to close a case with unresolved activities. You can also configure the tab that opens when representatives click this link. |[Customize the case resolution experience](add-enhanced-case-management.md#redirect-users-to-a-specific-tab-to-close-the-open-activities-for-a-case)|    
|6 |**Enable minimal case resolution dialog** |When enabled, allows representatives to see the legacy case resolution dialog. |[Customize the case resolution experience](add-enhanced-case-management.md#disable-the-minimal-case-resolution-dialog)|   
|7 |**Power Apps grid control** |Enabled on the case form by default. You can use this to options in this component to enable inline edits and manage option set colors. You can revert back to the legacy case grids by deleting this component. |[Enable case grids](enable-case-grids.md)|


## Default components available on enhanced full case form

You can use the default components on the [Enhanced full case form](case-enh-config.md#view-default-components-available-on-enhanced-full-case-form) to customize other forms.


### Related information

[Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)

[Enable enhanced case forms for multisession apps](case-enh-config.md)