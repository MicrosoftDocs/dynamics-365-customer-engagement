---
title: Configure risk and importance criteria for Sales Close Agent - Research
description: Learn how to set up and configure the Sales Close Agent - Research in Dynamics 365 Sales.
ms.date: 11/21/2025
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure risk and importance criteria for Sales Close Agent - Research

By default,the Sales Close Agent - Research determines the risk and importance of an opportunity based on company research and some predefined criteria. However, you can customize these criteria to better align with your organization's specific needs. For example, Contoso Inc has typical sales cycles that last 15 days, and they want to flag opportunities that have been in the same stage for more than 10 days as risky. They can modify the "Stalled in stage" criterion to reflect this requirement.

The agent uses past opportunity data and scoring model to rank the risks and importance of current opportunities and then provides a cumulative risk and importance score.  

## Configure the risk criteria

1. In the Sales Close Agent - Research configuration page, locate the **Risk criteria** section under **Advanced**.

1. Pull down the list of available criteria and review the existing risk criteria.  
   :::image type="content" source="media/sales-close-agent-risk-criteria.png" alt-text="Screenshot showing the risk criteria section in the Sales Close Agent - Research configuration page.":::
1. Modify the criteria as needed. The following table lists the available risk criteria for the Sales Close Agent - Research:

    | Risk criteria | Description |
    |---------------|-------------|
    | No recent engagement | Indicates that opportunities with no activity (email, reply, or meeting) within the configured time window should be flagged. |
    | Unresponsive champion | Indicates that opportunities where the champion hasn't responded after the configured number of touchpoints should be flagged. |
    | Not multi-threaded | Indicates that opportunities with limited stakeholder engagement must be flagged. Multi-threading means connecting with multiple contacts; this risk appears when contact coverage is below the configured threshold. |
    | Missing stakeholder roles | Indicates that opportunities missing one or more required stakeholder roles in connections or email conversations must be flagged once the opportunity reaches the configured stage. |
    | Close date deviation | Indicates that opportunities where the estimated close date is near or past before reaching the configured stage must be flagged. |
    | Stalled in stage | Indicates that opportunities that remain in the configured stage longer than the allowed number of days must be flagged. |
    | Objections raised | Indicates that opportunities where email conversations or notes include configured objection keywords or phrases must be flagged. |
    | Missing BANT info | Indicates that opportunities missing one or more BANT fields (Budget, Authority, Need, Timeline) by the configured stage must be flagged. |
    | Aging opportunity | Indicates that opportunities that have been open longer than the average age of previously won deals must be flagged, indicating they may need extra attention. |
    | Competitor mention | Indicates that opportunities where competitor names or mentions appear in email conversations, signalling competitive positioning may be needed. |
    | Negative news | Indicates that opportunities where external events such as layoffs, budget cuts, M&A detected through company insights could impact deal success. |

1. If you don't want to use a criterion in risk assessment, turn off the toggle next to it under **Use in assessment**.

## Configure the importance criteria

1. In the Sales Close Agent - Research configuration page, locate the **Importance criteria** section under **Advanced**.

1. Pull down the list of available criteria and review the existing importance criteria.
    :::image type="content" source="media/sales-close-agent-importance-criteria.png" alt-text="Screenshot showing the importance criteria section in the Sales Close Agent - Research configuration page.":::
1. Modify the criteria as needed. The following table lists the available importance criteria for the Sales Close Agent - Research:

    | Importance criteria | Description |
    |---------------------|-------------|
    | Existing customer | Indicates that opportunities linked to existing accounts based on the configured account-age threshold must be considered important. |
    | Account win history | Indicates that opportunities linked to accounts with a historical win rate above the configured threshold must be considered important. |
    | Deal size | Indicates that opportunities with unusually large estimated revenue compared to past wins for the same account must be considered important. |
    | Account fortune 500 | Indicates that opportunities linked to Fortune 500 accounts must be considered important. |
    | Executive visibility | Indicates that opportunities involving executive-level stakeholders, signaling C-suite visibility or sponsorship, must be considered important. |
    | Strategic references | Indicates that opportunities referenced as strategic in email conversations or CRM notes must be considered important. |

1. If you don't want to use a criterion in importance assessment, turn off the toggle next to it under **Use in assessment**.
1. (Optional) Select **Advanced settings** to add custom criteria for importance assessment. Custom criterion is useful when you want to evaluate importance based on organization-specific factors not covered by the default criteria. For example, you might want to add a custom criterion that flags opportunities linked to accounts in a specific industry vertical as important.
    1. Under **Advanced settings**, select **New custom criterion**.
    1. In the **New custom criterion** dialog box, provide the following details:
        - **Display name**: Enter a name for the custom criterion.
        - **Describe the criterion that determines an opportunity's importance**: Provide a brief description of what the criterion evaluates and how it determines importance. 
        - **Where should the agent look for this data?**: Select the data source where the agent should look for information related to this criterion. This could be fields on the opportunity table or related tables.
    1. Select **Add** to add the custom criterion to the importance assessment.
       The **Use in assessment** toggle is turned on automatically.
