---
title: Review knowledge articles created by the Customer Knowledge Management Agent
description: Learn how to review knowledge articles created by the Customer Knowledge Management Agent.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection: 
ms.date: 03/28/2025
ms.custom: bap-template
---

# Review knowledge articles created by the Customer Knowledge Management Agent (preview)

[This article is prerelease documentation and is subject to change.]

You can review knowledge articles created by the Customer Knowledge Management Agent. When you resolve a case, the Customer Knowledge Management Agent may create a new article based on the content of your case if it determines that it can fill a knowledge gap.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- You administrator must have configured Review permissions.
- You're using out-of-the-box timeline.
- You have **Timeline Highlights** and **Suggested actions** enabled.

## Review knowledge articles

1. For a resolved case, go to the case **Timeline**.
1. Select the **Suggested actions** tab.
   The **Suggested actions** tab appears only if there is a suggested action. 
1. Select **Review draft**.
1. In the **Review knowledge draft (preview)** dialog that appears, you can review and edit the article and make any rich text edits.
1. Optionally, you can use Copilot to make changes to the article automatically by typing what you want in **Revise with instructions**, and then selecting **Re-generate**. For example, you can prompt Copilot to make the content more concise, and then select **Re-generate**
1. Select **Mark as reviewed**. Or, if you have the required permissions, you can select **Split** and publish the article.

## Related information

[Manage Customer Knowledge Management Agent (preview)](../administer/admin-km-agent.md#manage-customer-knowledge-management-agent-preview)