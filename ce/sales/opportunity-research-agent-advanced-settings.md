---
title: Configure risk and importance criteria for Sales Close Agent - Research
description: Learn how to configure the risk and importance criteria specific to your organization so that the Sales Close Agent - Research can provide more accurate assessments of opportunities.
ms.date: 01/09/2026
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

By default, the Sales Close Agent - Research determines the risk and importance of an opportunity based on company research and some predefined criteria. However, you can customize these criteria to better align with your organization's specific needs. For example, Contoso Inc has a typical sales cycle that lasts 15 days, and the company wants to flag opportunities that are in the same stage for more than 10 days as risky. They can modify the "Stalled in stage" criterion to reflect this requirement.

The agent evaluates multiple risk and importance criteria to generate overall indicators for each opportunity:

- **Risk indicator**: The agent assesses the severity of each individual risk criterion that you configure and calculates an average rating. For example, if the **No recent engagement** threshold is set to 14 days and an opportunity has no engagement for 15 days, it receives a low-risk rating. If the same opportunity has no engagement for 30 days, it receives a high-risk rating. After evaluating all applicable risk criteria, the agent computes an overall risk score for the opportunity.

- **Importance indicator**: The agent evaluates the significance of each individual importance criterion that you configure and calculates an average rating to determine the overall importance of an opportunity.

The overall risk and importance scores help you prioritize which opportunities need immediate attention.

## Configure the risk criteria

1. In the **Sales Close Agent - Research** configuration page, go to the **Risk criteria** section under **Advanced**.

1. Open the list of available criteria and review the existing risk criteria.  

   :::image type="content" source="media/sales-close-agent-risk-criteria.png" alt-text="Screenshot showing the risk criteria section in the Sales Close Agent - Research configuration page.":::
1. Modify the criteria as needed. The following table lists the available risk criteria for the **Sales Close Agent - Research**:

    | Risk criteria | Description |
    |---------------|-------------|
    | No recent engagement | Flags opportunities with no activity (email, reply, or meeting) within the configured time window. |
    | Unresponsive champion | Flags opportunities where the champion doesn't respond after the configured number of touchpoints. |
    | Not multithreaded | Flags opportunities with limited stakeholder engagement. Multithreading means connecting with multiple contacts; this risk appears when contact coverage is below the configured threshold. |
    | Missing stakeholder roles | Flags opportunities missing one or more required stakeholder roles in connections or email conversations once the opportunity reaches the configured stage. |
    | Close date deviation | Flags opportunities where the estimated close date is near or past before reaching the configured stage. |
    | Stalled in stage | Flags opportunities that remain in the configured stage longer than the allowed number of days. |
    | Objections raised | Flags opportunities where email conversations or notes include configured objection keywords or phrases. |
    | Missing BANT info | Flags opportunities missing one or more BANT fields (Budget, Authority, Need, Timeline) by the configured stage. |
    | Aging opportunity | Flags opportunities that are open longer than the average age of previously won deals, indicating they might need extra attention. |
    | Competitor mention | Flags opportunities where competitor names or mentions appear in email conversations, signalling competitive positioning might be needed. |
    | Negative news | Flags opportunities where external events such as layoffs, budget cuts, or mergers and acquisitions detected through company insights could impact deal success. |

1. If you don't want to use a criterion in risk assessment, turn off the toggle next to it under **Use in assessment**.

## Configure the importance criteria

1. In the **Sales Close Agent - Research** configuration page, go to the **Importance criteria** section under **Advanced**.

1. Open the list of available criteria and review the existing importance criteria.
 
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
1. (Optional) Select **Advanced settings** to add custom criteria for importance assessment. A custom criterion is useful when you want to evaluate importance based on organization-specific factors not covered by the default criteria. For example, you might want to add a custom criterion that flags opportunities linked to accounts in a specific industry vertical as important.
    1. Under **Advanced settings**, select **New custom criterion**.
    1. In the **New custom criterion** dialog box, provide the following details:
        - **Display name**: Enter a name for the custom criterion.
        - **Describe the criterion that determines an opportunity's importance**: Provide a brief description of what the criterion evaluates and how it determines importance. 
        - **Where should the agent look for this data?**: Select the data source where the agent should look for information related to this criterion. This selection could be fields on the opportunity table or related tables.
    1. Select **Add** to add the custom criterion to the importance assessment.
       The **Use in assessment** toggle is turned on automatically.
