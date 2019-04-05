---
title: "Troubleshoot SharePoint Online setup | MicrosoftDocs"
ms.custom: 
ms.date: 04/05/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 28ba29c2-a661-4d6e-b72a-47c69a94de98
caps.latest.revision: 7
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Troubleshoot SharePoint Online setup

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you see the following error message... [need screenshots]

## Validate and fix Related - Documents link/button missing

Start by understanding the requirements listed in [Important considerations for server-based SharePoint integration](important-considerations-server-based-sharepoint-integration.md).

1. Make sure you have the System Administrator security role or equivalent permissions in Dynamics 365 for Customer Engagement.
    Check your security role:
    1. Follow the steps in [View your user profile](../basics/view-your-user-profile.md).
    2. Don’t have the correct permissions? Contact your system administrator.

2. Fix the missing **Documents** button. Follow these steps:

   1. Identity the entity for which the documents link should be visible (e.g. account, contact, opportunity...etc.).
   2. Go to **Settings** > **Document Management Settings**.
   3. Make sure the entity you wished to have documents link (selected in Step 1) are selected and a valid SharePoint URL is specified. 
   4. Complete the wizard.
   5. Verify if the Documents link /button is appearing.

