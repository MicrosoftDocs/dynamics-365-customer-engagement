---
title: Sales Qualification Agent FAQ
description: Find answers to frequently asked questions about the Sales Qualification Agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
ms.date: 07/10/2025
ms.update-cycle: 180-days
ms.topic: faq
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Qualification Agent FAQ


[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This FAQ provides answers to common questions about the Sales Qualification Agent in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Why did the agent pause?

The agent might pause for the following reasons:

- An admin revoked one or more consents the agent needs to run.
- No capacity is available for the agent to process leads. Ask your admin to check the capacity and resolve the issue.
- Your org is using an older version of the agent. Upgrade to the latest version to continue using the agent. Learn more in [Upgrade your Sales Qualification Agent](upgrade-sales-qualification-agent.md).

## Why did the Sales Qualification Agent go into Draft mode?

If you're using the 4.3 version of the Sales Qualification Agent (part of the April 2025 public preview), it will be set to Draft mode after the 7.3 release is deployed in your environment. Learn more in [Upgrade your Sales Qualification Agent](upgrade-sales-qualification-agent.md).

## Why can't I access the research pages of leads that were previously processed by the agent? 

The possible causes for this issue are:

- Your agent is upgraded to the 7.3 version.
- The lead no longer fulfills the selection criteria defined in the agent configuration.

The previous research data is stored in msdyn_leadagentresult (lead agent result) and msdyn_accountresearchresult (account research result). Learn more in [Upgrade your Sales Qualification Agent](upgrade-sales-qualification-agent.md).


## Why are my 4.3 agent settings not preserved after the upgrade?

Due to a technological change in the agent's architecture, the settings from the 4.3 version of the Sales Qualification Agent can't be preserved during the upgrade to the 7.3 version.  

<a name="trigger-events"></a>
## When does the agent run?

After the activation, the agent processes leads automatically when any of the following events occur:

- A new lead is created.
- There's an update to the email and account name of an existing lead that requires the agent to re-run. Not all updates trigger the agent to re-run. 
    - The agent will re-run all the steps in the flow (including email validation, research, readiness, and engagement) if:
        - The lead's email ID is updated from an empty or invalid value to a valid value.
        - The lead's account name is updated from an empty value to a valid value.
     - The agent will run only the email validation step if:
         - The lead's email ID is updated from one value to another value, irrespective of whether the email ID is changed from a valid value to a valid or invalid value.

## What activities consume Copilot Studio capacity?

The Sales Qualification Agent uses Copilot Studio capacity for research, matching the ideal customer profile, and generating the initial outreach email.

Viewing insights that have been generated doesn't consume capacity.

<a name="cant-see-email-options"></a>
## Why don't I see the **Review email** or **Draft email** option?

The **Review email** option appears in the banner, and the **Draft email** option appears on the **Lead insights** page, only if the following conditions are met:

- Your organization is using server-side synchronization. Ask your admin if you're not sure.
- The lead's email address is available.  
 
 