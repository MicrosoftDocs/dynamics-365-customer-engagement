---
title: FAQs about Sales Qualification Agent
description: Find answers to frequently asked questions about the Sales Qualification Agent in Dynamics 365 Sales.
ms.date: 08/01/2025
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

# FAQs about Sales Qualification Agent


This FAQ provides answers to common questions about the Sales Qualification Agent in Dynamics 365 Sales.

## Why did the agent pause?

The agent might pause for the following reasons:

- An admin revoked one or more consents the agent needs to run.
- No capacity is available for the agent to process leads. Ask your admin to check the capacity and resolve the issue.
- Your org is using an older version of the agent. Upgrade to the latest version to continue using the agent. Learn more in [Upgrade your Sales Qualification Agent](upgrade-sales-qualification-agent.md).

## Why can't I access the research pages of leads that were previously processed by the agent?

The possible causes for this issue are:

- Your agent is upgraded to the latest version.
- The lead no longer fulfills the selection criteria defined in the agent configuration.

The previous research data is stored in msdyn_leadagentresult (lead agent result) and msdyn_accountresearchresult (account research result). Learn more in [Upgrade your Sales Qualification Agent](upgrade-sales-qualification-agent.md).


<a name="trigger-events"></a>
## When does the agent run?

After the activation, the agent processes leads automatically when any of the following events occur:

- A new lead is created.

- There's an update to the email and account name of an existing lead that requires the agent to re-run. Not all updates trigger the agent to re-run.
  
    - The agent will re-run all the steps in the flow (including email validation, research, readiness, and engagement) if:
        - The lead's email ID is updated from an empty or invalid value to a valid value.

        - The lead's account name is updated from an empty value to a valid value.
        - The lead is updated to meet the selection criteria defined for the agent. If the updated field is in the lead table, the agent processes the lead irrespective of the date the lead was created. If the updated field is in a related table, the agent processes the lead only if the lead was created within the look back period defined in the selection criteria. For example, if the look back period is set to 30 days, and the lead was created 45 days ago, the agent won't process the lead even if a related field is updated to meet the selection criteria.

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


## What does error in a supporting process mean?

If you see an error that says "Insights couldn't be generated due to an error in a supporting process," it means that the agent encountered an issue while trying to generate insights for the lead. This could be due to various reasons, such as:

- The lead's email address is invalid or missing. Invalid emails are flagged in the **Lead research** page with an **Invalid email** tag. 
- The lead's account information is missing. In this case, the agent doesn't run as there's no company information to research on. 

Update the lead's email address or account information to put the lead back in the agent's queue for processing.

## Why the agent didn't process my lead?

If the agent is stuck and isn't processing your lead, verify the following conditions:

- Ensure that the seller has at least read access to the custom entities and fields used in the custom criteria.

- Ensure that the fields used in custom criteria are not removed from Dataverse. If you remove fields used in a custom criterion from Dataverse, the agent won't be able to generate summaries or hand off leads to sellers. Remove the custom criterion related to the deleted fields and try again.