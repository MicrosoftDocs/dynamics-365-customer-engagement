---
title: Set up autonomous case follow-up and closure (preview)
description: Learn how to set up autonomous case management agents to help agents follow up and close cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: get-started 
ms.date: 01/13/2025
ms.custom: bap-template 
---


# Set up autonomous case follow-up and closure (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


The autonomous case management agent can automatically follow up with customers over email. If customers don't respond after a set number of follow-ups, the agent can automatically close the cases, reducing manual communication overhead and streamlining case resolution.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]


## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.

## Configure autonomous case follow-up and closure

Perform the following steps to set up autonomous case follow-up and closure:

1. On the **Case settings** page, select **Manage** for **Case Management Agent**.
2. In the **Case Management Agent** page, select **Autonomous case follow-up and closure**.
3. In the page that appears, select **Add** to create a new rule for case follow-up and closure.
4. In **Rules**, specify the following information. The agent evaluates the rules in the order they are listed and when the conditions match, updates the fields.
   - **Rule name**
   - **Conditions:** Specify the criteria for which the rule must run.
   - **Level of automation:** Select the automation level:
     - **Require agent confirmation:** Agent drafts follow-up emails, initiates case closure, and populates the required fields, but requires service representative intervention to send the email and close the case.
     - **Full automation:** Agent independently sends follow-ups and resolves cases without manual intervention.
   - **Follow-up emails:** Fields the agent should automatically populate when resolving the case (optional).
   - **Case resolution form:** Specify fields the agent should automatically populate when resolving the case.
   - **Follow-up trigger:** Specify the value of the field which prompts the agent to initiate the email follow-up process.
   - **Number of follow-ups:** The number of follow-up emails the agent must send without a response from the customer before resolving a case.
   - **Follow-up wait times:** Set the duration between sending follow-up emails.
   - Select **Save**.

5. Optionally, after creating the rules, you can:
   - Change the order in which the rules are evaluated.
   - Search for rules.
   - View the condition used for each rule by hovering the mouse over the condition.

### Example
You want to configure the follow-up and case closure agent to automatically send follow-up emails for cases pertaining to **Contoso Coffee** issues with a case age greater than 7 days.  

When the **Status Reason** is set to "Awaiting customer confirmation," the agent initiates the follow-up process and sends three follow-up emails in the specified interval. If there’s no response from the customer, the agent resolves the case.

**Configuration Example:**
- **Rule:** Contoso Coffee follow-up and closure  
- **Condition Configuration:**  
  - Case Title equals "Contoso Coffee"  
  - **AND** Case Age greater than 7 days  
- **Level of Automation:** Full automation  
  - **Follow-up trigger:** Status Reason = "Awaiting customer confirmation"  
  - **Number of follow-ups:** 3  
  - **Follow-up wait times:**  
    1. First follow up: 48 hours  
    2. Second follow-up: 48 hours  
    3. Final follow-up: 48 hours  
- **Case resolution form:** Resolution, Resolution Type  

## Next steps

[Use autonomous follow-up and closure of cases](../use/use-follow-up-closure.md)