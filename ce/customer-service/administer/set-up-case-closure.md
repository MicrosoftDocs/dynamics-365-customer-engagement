---
title: Set up Case Management Agent for case follow-up and closure
description: Learn how to set up the autonomous Case Management Agent to help service representatives follow up and close cases in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 01/19/2026
ms.custom: bap-template
---


# Set up Case Management Agent for case follow-up and closure

Case Management Agent follows up with customers over email. If customers don’t respond after a specified number of follow-ups, the agent closes the cases automatically. This reduces manual communication overhead and streamlines case resolution.

## Prerequisites

- The CSR Manager or System Administrator role.
- For the AI agent to send follow-up emails autonomously, you must set up a dedicated application user to send and receive emails on behalf of your organization. Perform the steps in [Configure global settings for Case Management Agent](case-management-global-settings.md).
- Copilot recommended email templates and default email templates configured in the **Global settings** page. Learn more in [Configure global settings](set-up-case-resolution-agent.md#configure-case-resolution-settings).

## Configure autonomous case follow-up and closure

Perform the following steps in Copilot Service admin center to set up autonomous case follow-up and closure. The AI agent evaluates the configured rules and when the conditions match, initiates the follow-up and closure process.

1. Select **Case settings** in **Customer support**. The **Case settings** page appears.
1. On the **Case settings** page, select **Manage** for **Case Management Agent**.
1. On the **Case Management Agent** page, select **Autonomous case follow-up and closure**.
1. On the page that appears, select **Turn on the case follow-up and closure automation**.
1. Select **Add** to create a new rule for case follow-up and closure.
1. In **Rules**, specify the following information. 
   - **Rule name**
   - **Conditions:** The criteria for which the rule must run.
   - **Level of automation**: The automation level.
        - **Require human confirmation**: The AI agent drafts follow-up emails, initiates case closure and populates the required fields, but requires the service representative to review and send the email and manually close the case. 
        - **Full automation**: The AI agent automatically sends follow-up emails and closes the case if the customer does not respond after the specified number of follow-ups.
   - **Follow-up emails:** Fields the agent should refer to when drafting the follow-up emails. This is optional.
   - **Status Reason:** The status reason that triggers a follow-up action as a suggestion to the representative.
   - **Number of follow-ups:** The number of follow-up emails the agent must send without a response from the customer before resolving a case. The application considers the email sent by the service representative without a response from the customer as the first follow-up.
   - **Follow-up wait times:** The duration between follow-up emails.
   - **Follow-up email templates**: Select **Edit** to specify the email templates that the AI agent must use to send emails for follow ups.
    > [!NOTE]
    > The AI agent uses the rule-specific email templates to generate emails even if you configured the Copilot recommended email templates and default email templates in the **Global settings** page.
   - Select **Save**.
5. On the **Case follow-up and closure** page, select the rule and then select **Activate**.
1. Optionally, after creating the rules, you can:
   - Change the order in which the rules are evaluated.
   - Search for rules.
   - View the condition used for each rule by hovering over the condition.
1. Select **Let Copilot fill out resolution details when a customer service representative wants to resolve a case** for the AI agent to automatically fill out the case resolution dialog, when the case status is set to resolved. 
1. Select **Manage data sources** to specify the fields the AI agent must use to fill out the resolution dialog.

## Enable Power Automate flows

In Power Apps, make sure that the **CSCaseClosure Agent Flow**, **CSCaseFollowup Agent flow**, and **CSCaseClosure Representative Flow** are connected to Microsoft Dataverse and Microsoft Copilot Studio.

1. Navigate to **Power Automate** > **Solutions**.
1. Select your solution.
1. In **Objects**, search for and select **Cloud flows**. The default Cloud flows in the organization are displayed. 
1. Select edit for each of **CSCaseClosure Agent Flow**, **CSCaseFollowup Agent flow**, and **CSCaseClosure Representative Flow**. The connection status of the flow should be **Connected**.


:::image type="content" source="../media/powerapps-flow-status.png" alt-text="Screenshot of connection status of flow.":::

## Example

The AI agent should automatically initiate the case follow-up process for cases related to **Contoso Coffee** issues where the case age is greater than seven days and the service representative sets the case **Status Reason** to **On Hold**. The agent should send three follow-up emails every 48 hours. If the customer doesn't respond after the third follow-up, the service representative can close the case.

**Configuration Example:**
- **Rule:** Contoso Coffee follow-up and closure  
- **Condition Configuration:**  
  - Case Title equals "Contoso Coffee"  
  - **AND** Case Age greater than seven days
  - **Level of automation**: Full
  - **Follow-up trigger:** Status Reason = "Awaiting "  
  - **Number of follow-ups:** 3  
  - **Follow-up wait times:**  
    1. First follow up: 48 hours  
    2. Second follow-up: 48 hours  
    3. Final follow-up: 48 hours  

The AI agent first evaluates all the cases that have "Contoso Coffee" in the title and are older than 7 days. If the **Status Reason** of the case is set to "On Hold", and if the customer hasn't responded to the email sent by the AI agent in the last 48 hours, the AI agent initiates the case follow-up process. If the customer doesn't respond after the third follow-up, the AI agent populates the case resolution dialog with the required information and closes the case.


## Next steps

[Use autonomous follow-up and closure of cases](../use/use-case-follow-up-closure.md)