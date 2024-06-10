---
title: Enable enhanced recipient control for email
description: Enable enhanced recipient control for agents to have a consistent experience across forms.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection:
ms.date: 05/23/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:12/01/2023
  - ai-gen-desc
---

# Enable enhanced recipient control for email

You can enable the recipient control for agents to drag and drop recipient names across **To**, **CC**, and **BCC**, view the recipient's email address along with their names, presence status, and out-of-office message, and resolve an unresolved email address faster. Do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables** > **Email**> **Forms** and then select the required form.
1. Add the **Email Recipient control** component. For more information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-for-a-column-on-the-form).  
1. In the **Add Email Recipient** control, perform the following actions:
   - Make sure you map the **From**, **To**, **CC**, and **BCC** fields in the component to the appropriate email fields.
   - Set the **Static Value** for **Show Email address** to **True** to display the email address along with the name of the recipient.
   - Set the **Show out of office (preview)** to **True** to display the out-of-office status and the presence status of the recipient. 
     > [!NOTE]
     > Presence is only displayed for system users with the **azureactivedirectoryobjectid** linked.
1. Save and publish the form.

    :::image type="content" source="../media/admin-recipient-handling-mini.png" alt-text="Screenshot of Powerapps configuration." lightbox="../media/admin-recipient-handling.png":::