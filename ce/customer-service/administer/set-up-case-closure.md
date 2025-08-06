---
title: Set up Case Management Agent for case follow-up and closure (preview)
description: Learn how to set up the autonomous Case Management Agent to help service representatives follow up and close cases in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: get-started 
ms.date: 08/08/2025
ms.custom: bap-template 
---


# Set up Case Management Agent for case follow-up and closure (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


The Case Management Agent follows up with customers over email. If customers don’t respond after a specified number of follow-ups, the agent closes the cases automatically. This reduces manual communication overhead and streamlines case resolution.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]


## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.
- If you configure the fully automated case follow-up and closure, the following apply to the fully-automated case follow-up and closure process:
- application user to send and receive emails and shared inbox. Learn more in [Prerequisites](configure-case-resolution-agent.md#prerequisites).
- Copilot recommended email templates and default email templates configured in the **Global settings (preview)** page. Learn more in [Configure global settings](configure-case-resolution-agent.md#configure-global-settings).

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
   - **Level of automation**: Select the automation level.
        - **Required agent confirmation**: The AI agent drafts follow-up emails, initiates case closure and populates the required fields, but requires the service representative to review and send the email and manually close the case. 
        - **Full automation**: The AI agent automatically sends follow-up emails and closes the case if the customer does not respond after the specified number of follow-ups.
   - **Follow-up emails:** Fields the agent should refer to when drafting the follow-up emails. This is optional.
   - **Status Reason:** Specify the status reason that triggers a follow-up action as a suggestion to the representative.
   - **Number of follow-ups:** The number of follow-up emails the agent must send without a response from the customer before resolving a case. The application considers the email sent by the service representative without a response from the customer as the first follow-up.
   - **Follow-up wait times:** Specify the duration between follow-up emails.
   - **Follow-up email templates**: Select **Edit** to specify the email templates that the AI agent must use to send emails for follow ups.
    > [!NOTE]
    > The AI agents uses the rule-specific email templates to generate emails even if you configured the Copilot recommended email templates and default email templates in the **Global settings (preview)** page.
   - Select **Save**.
5. On the **Case follow-up and closure (preview)** page, select the rule and then select **Activate**.
1. Optionally, after creating the rules, you can:
   - Change the order in which the rules are evaluated.
   - Search for rules.
   - View the condition used for each rule by hovering over the condition.
1. Select **Let Copilot fill out resolution details when a customer service representative wants to resolve a case** for the AI agent to automatically fill out the case resolution dialog, when the case status is set to resolved. 
1. Select **Manage data sources** to specify the fields the AI agent must use to fill out the resolution dialog.

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
  - **Level of automation**: Full
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
1. Determines if the customer responded to the service representative's email within the configured duration for the first response time.
1. If the status reason matches the trigger, based on the configuration, the AI agent does the following:

  - **Fully-autonomous**: Automatically drafts and sends the follow-up emails to the customer. If the customer doesn't respond after the third follow-up, the AI agent resolves the case by populating the configured case resolution fields and closing all open activities linked to the case.
  - **Requires agent confirmation**: The AI agent drafts the follow-up emails and displays a **Suggested actions** card on the case form. The service representative can review the email, edit it if necessary, and then send it to the customer. If the customer doesn't respond after the third follow-up, the AI agent suggests that the service representative resolve the case. 

The email drafted by the AI agent is based on the configuration you set in **Global settings (preview)** or the email templates you configured in the **Case follow-up and closure (preview)** page. Learn more in:

- [Use Copilot recommended email templates](/dynamics365/contact-center/use/use-copilot-email&tabs=richtexteditor#use-copilot-recommended-email-templates)
- [Use line-of-business tagged email templates](/dynamics365/contact-center/use/use-copilot-email&tabs=richtexteditor#use-line-of-business-tagged-email-templates)

 
For the configuration in our [example](#example), the AI agent first evaluates all the cases which have "Contoso Coffee" in the title and are older than 7 days. If the **Status Reason** of the case is set to "On Hold", and if the customer hasn't responded to the email sent by the AI agent in the last 48 hours, the AI agent initiates the case follow-up process. If the customer doesn't respond after the third follow-up, the AI agent populates the case resolution dialog with the required information and closes the case.


## Next steps

[Use autonomous follow-up and closure of cases](../use/use-follow-up-closure.md)