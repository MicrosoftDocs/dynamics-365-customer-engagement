---
title: Add Power Apps components to Case Management forms 
description: Learn about adding the applicable Power Apps components to Case Management forms.
author: gandhamm 
ms.author: v-slaik
ms.reviewer: neeranelli 
ms.topic: conceptual 
ms.date: 09/12/2024
ms.custom: bap-template 
---

# Add Power Apps components to Case Management forms

You can use a collection of Power Apps components to customize your case management forms and add additional functionalities that the agents can use when handling cases in the Customer Service workspace. Using additional components to the case forms helps the agents to view and manage open activities, and keep a track of the time spent on each case. This enhances agent productivity by enabling them to work cases effectively.

You can use default components, such as the **Associated Grid Control** and the **Attachment Control**, available on the enhanced full case forms. Learn more about the default components at [Enable enhanced case forms for multisession apps](case-enh-config.md).

## Available Power Apps components

The following table shows Power Apps components, along with details, which are available for customizing your forms in the Customer Service workspace.

|Number |Component |Description |Entity |Additional actions |Additional information|
|-------|----------|------------|-------|-------------------|----------------------|
|1 |**Status reason transitions** |Add this component to case forms for the agents to enter and update case status during runtime. | Available for all entities. | Applicable. |[Define status reason transitions for case management](define-status-reason-transitions-case-management.md)|
|2 |**Customer 360** |Adding this component to a case form helps agent to see the customer details for a case. | Available for all entities. | Applicable. | [Customer 360](add-display-components-to-case-form.md)| 
|3 |**Recent records** |Adding this component to a case form allows agents to access the related customer records for a case. |Available for all entities. |Not applicable. |[Customer 360](add-display-components-to-case-form.md)|
|4 |**Case handling time widget** |Add this component to help the agents to see the case handling time widget on a case form. |Available for all entities. |Not applicable. |[Configure case handling time widget to case forms](add-case-handling-time.md)|  
|5 |**Redirect** |Adding this component to a case form redirects the agents to a specific tab to close the open activities for a case. |Available for all entities. |Applicable. |[Customize the case resolution experience](add-enhanced-case-management.md)|    
|6 |**Due open activities control** |This component helps agents see the activities that are either due today or overdue. |Available for all entities. |Applicable. |[Use the Due open activities control to customize forms](add-due-open-activities.md)|
|7 |**Modernized case grids** |Add this component on a case form for the agents to get quick access to case information, such as the last customer interaction, case age, and the next SLA breach. |Available for all entities. |Applicable. |[Enable case grids](enable-case-grids.md)|


## Next steps

You can add the default components to other forms and customize them. Learn more at [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


### Related information

[Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)

[Enable enhanced case forms for multisession apps](case-enh-config.md)