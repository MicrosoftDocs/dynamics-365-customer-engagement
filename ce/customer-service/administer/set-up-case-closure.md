---
title: Set up Case Management Agent for case follow-up and closure (preview)
description: Learn how to set up the autonomous Case Management Agent to help service representatives follow up and close cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: get-started 
ms.date: 05/26/2025
ms.custom: bap-template 
---


# Set up Case Management Agent for case follow-up and closure (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


The Case Management Agent follows up with customers over email. If customers don’t respond after a specified number of follow-ups, the agent closes the cases automatically. This reduces manual communication overhead and streamlines case resolution.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]


## Prerequisites

Administrators must have the CSR Manager or System Administrator role.

## Configure autonomous case follow-up and closure

Perform the following steps in Copilot Service admin center to set up autonomous case follow-up and closure:

1. Select **Case settings** in **Customer support**. The **Case settings** page appears.
1. On the **Case settings** page, select **Manage** for **Case Management Agent**.
1. On the **Case Management Agent** page, select **Autonomous case follow-up and closure (preview)**.
1. On the page that appears, select **Turn on the case follow-up and closure automation**.
1. Select **Add** to create a new rule for case follow-up and closure.
1. In **Rules**, specify the following information. The AI agent evaluates the rules and when the conditions match, initiates the follow-up and closure process.
   - **Rule name**
   - **Conditions:** Specify the criteria for which the rule must run.
   - **Follow-up emails:** Fields the agent should refer to when drafting the follow-up emails. This is optional.
   - **Status Reason:** Specify the status reason that triggers a follow-up action as a suggestion to the representative.
   - **Number of follow-ups:** The number of follow-up emails the agent must send without a response from the customer before resolving a case. The application considers the email sent by the service representative without a response from the customer as the first follow-up.
   - **Follow-up wait times:** Specify the duration between follow-up emails.
   - Select **Save**.

5. On the **Case follow-up and closure (preview)** page, select the rule and then select **Activate**.
1. Optionally, after creating the rules, you can:
   - Change the order in which the rules are evaluated.
   - Search for rules.
   - View the condition used for each rule by hovering over the condition.

## Enable Power Automate flows

In Power Apps, make sure that the **CSCaseClosure Agent Flow**, **CSCaseFollowup Agent flow**, and **CSCaseClosure Representative Flow** are connected to Microsoft Dataverse and Microsoft Copilot Studio (Preview).

1. Navigate to **Power Automate** > **Solutions**.
1. Select your solution.
1. In **Objects**, search for and select **Cloud flows**.
1. The default Cloud flows in the organization are displayed. Select edit for each of **CSCaseClosure Agent Flow**, **CSCaseFollowup Agent flow**, and **CSCaseClosure Representative Flow**. The connection status of the flow should be **Connected**.


:::image type="content" source="../media/powerapps-flow-status.png" alt-text="Screenshot of connection status of flow.":::

## Example

The AI agent should automatically initiate the case follow-up process for cases related to **Contoso Coffee** issues where the case age is greater than seven days and the service representative sets the case **Status Reason** to **On Hold**. The agent should send three follow-up emails every 48 hours. If the customer doesn't respond after the third follow-up, the service representative can close the case.

**Configuration Example:**
- **Rule:** Contoso Coffee follow-up and closure  
- **Condition Configuration:**  
  - Case Title equals "Contoso Coffee"  
  - **AND** Case Age greater than seven days   
  - **Follow-up trigger:** Status Reason = "Awaiting "  
  - **Number of follow-ups:** 3  
  - **Follow-up wait times:**  
    1. First follow up: 48 hours  
    2. Second follow-up: 48 hours  
    3. Final follow-up: 48 hours  

### Runtime experience

Based on the follow-up rules and trigger configured, the AI agent performs the following actions:
 
1. Checks if a case meets the rules set to qualify for the follow-up process.
1. Maps the **Status Reason** value on the case form to the status reason trigger set by you. 
1. Determines if the customer responded to the service representative's email within the configured duration for the first response time. If the status reason matches the trigger, the AI agent displays the **Suggested actions** card on the case form with the next steps that the representative can take to close the case.

For the configuration in our [example](#example), the AI agent first evaluates all the cases which have "Contoso Coffee" in the title and are older than 7 days. If the service representative sets the case **Status Reason** to "On Hold", and if the customer hasn't responded to the email sent by the service representative in the last 48 hours, the AI agent initiates the case follow-up process. If the customer doesn't respond after the third follow-up, the AI agent suggests that the service representative resolve the case.

## Next steps

[Use autonomous follow-up and closure of cases](../use/use-follow-up-closure.md)