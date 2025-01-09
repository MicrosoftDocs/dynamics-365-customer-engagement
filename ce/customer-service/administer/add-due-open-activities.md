---
title: Use the Due open activities control to customize forms
description: Learn about adding Due open activities control to forms.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 06/10/2024 
ms.custom: bap-template 
---

# Use the Due open activities control to customize forms 

The **Due open activities control** helps customer service representatives (service representatives or representatives) see the activities that are either due today or overdue. The application displays the due or overdue activities as a hyperlink. This component is available out of the box on the enhanced full case form.

## Customize forms with Due open activities control

You can customize other forms such as Account or Contacts, to display the due or overdue activities by performing the following steps:

1. In Power Apps, add the **Due open activities control** component to the required form. More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).
1. On the **Due and Overdue Activities** subgrid, in **Properties** specify the following:
    - In **Table** select **Activities**.
    - Select the **Show related records** to display the activities related to the current record only.
1. Save and publish the customizations.

## Specify tab to redirect users to view open activities

Configure the tab that the representatives must be redirected to when they select the open activities link from the **Due open activities control**. You can set this at an environment level or for a specific app.

1. In Power Apps, add the **Due open activities control** component to the required form. 
1. In **Edit Due open activities control**, set the **Static value** option to the required tab. To find the tab's name, perform the following steps:
   - Navigate to a form that has the required tab.
   - Select the tab, and then copy the value in **Name** in **Display options**.
1. Save and publish the customizations.

   :::image type="content" source="../media/set-open-activities.png" alt-text="Open activities in a new tab" lightbox="../media/set-open-activities.png":::

### Related information
[Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).
[Case management in multisession apps](../use/enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](../implement/csw-overview.md) 
