---
title: Request Service Agent public preview access for Field Service
description: Request gated public preview access to Field Service capabilities in Service Agent for selected Dynamics 365 environments.
ms.date: 11/23/2026
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot
ai-usage: ai-generated
---

# Request Service Agent public preview access for Field Service

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Request access to try Field Service capabilities in Service Agent through the gated public preview. Enroll each Dynamics 365 environment where you want to use the capabilities. Your organization manages individual users and their permissions separately.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

<!-- DRAFT REVIEW: Reconfirm timing against the live enrollment form at publication. Confirm exact licensing, supported clients, regions, languages, and the customer support/feedback route. This draft doesn't establish those requirements or a processing SLA. -->

## Before you begin

Work with your administrator to identify the environments you want to enroll and collect their **Organization IDs**.

Use the **Organization ID**, not the separate **Environment ID**, for each environment.

## Find the Organization IDs

For each environment:

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).
2. Select **Manage** > **Environments**.
3. Open the environment.
4. In **Details**, copy **Organization ID**.

For more information, see [Find environment and organization IDs](/power-platform/admin/determine-org-id-name).

## Request preview access

1. Open the [Service agent enablement for Field Service scenarios: Gated public preview opt-in form](https://aka.ms/fsagentpreview).
2. Enter your name, work email address, and company or organization name.
3. Enter the **Organization IDs for the Dynamics 365 environments you want to enroll**. Separate multiple Organization IDs with commas.
4. Select **I would like to opt in**.
5. Complete any optional sections you want to share, and submit the form. Usage information, technical details, and interest in working more closely with Microsoft are optional.

Don't include passwords, secrets, customer records, or other sensitive information in your responses.

## After you submit the form

Submitting the form doesn't immediately enable access. Preview enablement is expected around late November or early December 2026.

Microsoft will email the work address you provided when your submitted environments are enabled. Follow the access instructions in that email, and work with your administrator to confirm user access and the connected environment.

If you express interest in working more closely with Microsoft, you might be contacted separately about preview discussions, research, or feedback. Contact isn't guaranteed and isn't required for preview enrollment.

## Next steps

- [Field Service capabilities in Service Agent](service-agent-overview.md).
- [How MCP tools support Field Service scenarios](service-agent-mcp-tools-overview.md).
- [Configure Service Agent capabilities for Field Service](configure-service-agent.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
