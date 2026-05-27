---
title: Set up Case Management Agent for case follow-up and closure
description: Learn how to set up the autonomous Case Management Agent to help service representatives follow up and close cases in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 05/27/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Set up Case Management Agent for case follow-up and closure

Case Management Agent follows up with customers over email. If customers don’t respond after a specified number of follow-ups, the AI agent closes the cases automatically. This reduces manual communication overhead and streamlines case resolution.

## Prerequisites

- The CSR Manager or Customer Service Representative role.
- The guided setup for Case Management Agent is completed. Learn more in [Configure Case Management Agent](case-management-global-settings.md).



## Configure autonomous case follow-up and closure

Perform the following steps in Copilot Service admin center to set up autonomous case follow-up and closure. The AI agent evaluates the configured rules and when the conditions match, initiates the follow-up and closure process.

1. Select **Case settings** in **Customer support**. The **Case settings** page appears.
1. On the **Case settings** page, select **Manage** for **Case Management Agent**.
1. On the **Case Management Agent** page, select **Case follow-up and closure**.
1. On the page that appears, select **Turn on the case follow-up and closure automation**.
1. Select **Add** to create a new rule for case follow-up and closure.
1. In **Rules**, specify the following information. 
   - **Rule name**
   - **Conditions:** The criteria for which the rule must run.
   - **Level of automation**: The automation level.
        - **Require human confirmation**: The AI agent drafts follow-up emails, initiates case closure and populates the required fields, but requires the service representative to review and send the email and manually close the case. 
        - **Full automation**: The AI agent automatically sends follow-up emails and closes the case if the customer does not respond after the specified number of follow-ups.
   - **Follow-up emails:** Fields the AI agent should refer to when drafting the follow-up emails. This is optional.
   - Use the **Follow-up trigger** settings to define how and when the Case Management Agent initiates each follow-up step in the case lifecycle. You must select at least one trigger option.
       - Select **Follow-up based on context** for the AI agent to automatically start follow-up actions based on the content of customer emails, irrespective of the case status.
       - Select **Follow-up based on status reason** for the AI agent to start follow-up actions when the case reaches a specific status reason value
       - **Status Reason:** The status reason that triggers a follow-up action as a suggestion to the representative.
   - **Number of follow-ups:** The number of follow-up emails the AI agent must send without a response from the customer before resolving a case. The application considers the email sent by the service representative without a response from the customer as the first follow-up.
   - **Follow-up wait times:** The duration between follow-up emails.
   - **Follow-up email templates**: Select **Edit** to specify the email templates that the AI agent must use to send emails for follow ups.
    > [!NOTE]
    > The AI agent uses the rule-specific email templates to generate emails even if you configured the Copilot recommended email templates and default email templates in the **Case resolution** page.
   - Select **Save**.
5. On the **Case follow-up and closure** page, select the rule and then select **Activate**.
1. Optionally, after creating the rules, you can:
   - Change the order in which the rules are evaluated.
   - Search for rules.
   - View the condition used for each rule by hovering over the condition.
1. Select **Let Copilot fill out resolution details when a customer service representative wants to resolve a case** for the AI agent to automatically fill out the case resolution dialog, when the case status is set to resolved.
1. Select **Manage data sources** to specify the fields the AI agent must use to fill out the resolution dialog.

## Example

The AI agent should automatically initiate the case follow-up process for cases related to **Contoso Coffee** issues where the case age is greater than seven days and the service representative sets the case **Status Reason** to **On Hold**. The AI agent should send three follow-up emails every 48 hours. If the customer doesn't respond after the third follow-up, the service representative can close the case.

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


##  Run simulations to evaluate case follow-up and closure (preview) 

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Use sample records to test and compare case follow-up and closure by Case Management Agent before enabling the AI agent in production.

> [!NOTE]
> - You can run simulation only if the level of automation for the line of business is set to Disabled.
> - Simulations consume Copilot or AI credits in the same way as agent runs.

### Set up a simulation

1. On the **Case Management Agent** page, in **Case follow-up and closure**, select **Manage**. The **Case follow-up and closure** page appears.
1. Select **Go to simulation** in the Command menu. The **Case follow-up and closure simulation** page appears.
1. On the **Simulation setup** tab, provide the following information:

    1. **Simulation name**: Provide a simulation name.
    1. Specify **Follow-up rules** to validate how your draft rule matches real cases and ensure the follow-up conditions behave as expected before activation.
    1. Select **Show matching cases**. The **Selected record** section appears that shows cases based on line of business and any additional filters that you might have added in the **Additional record filters** dropdown. The first 100 matching cases only are shown because simulations can run on a maximum of 100 cases at a time.
  1. Select the cases and then select **Run simulation**. The **Simulation result** tab shows the results.

### View a simulation report

Simulations are listed with details of the simulation name, line of business, run date, status, and results on the **Simulation result** tab.

- Select **Download** to export an Excel report.
- Select **View** to see simulation results for a specific line of business. The page displays the run details along with individual case predictions showing intent, action type, and generated response. Select **View Email** to view the generated response email.

## Enable shadow mode and view results (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Use shadow mode to evaluate predicted actions from Case Management Agent on live cases without sending emails or updating records.

> [!NOTE]
> Shadow mode consumes Copilot or AI credits in the same way as AI agent runs.

1. On the **Case follow-up and closure** page, in **Rules**, select a rule.
1. Select **Shadow mode** from the toolbar. The rule status changes to **Shadow mode**.
1. Select **Go to shadow mode results** from the **Command** menu. On the **Case follow-up and closure - Shadow mode** page, filter by rule to view the follow-up emails for cases.
1. Select **View Email** to view the email preview.

## Next steps

[Use autonomous follow-up and closure of cases](../use/use-case-follow-up-closure.md)