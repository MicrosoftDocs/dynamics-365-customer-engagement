---
title: Use the canvas experience for cases (preview)
description: Understand a customer issue, review previous interactions, and plan your next step with the case canvas in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: overview
ms.date: 11/17/2026
ai-usage: ai-assisted
ms.custom: bap-template
search.audienceType:
  - enduser
---

# Use the canvas experience for cases (preview)

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]

Use the case canvas in Copilot Service workspace to review a customer's issue, case summary, key details, activity history, and suggested response in one place. Use this context to plan your next step without repeating previous work.

[!INCLUDE[public-preview-note](../../includes/public-preview-note.md)]


## Example: Continue a case after a handoff

A customer reports being charged twice for a gift card that the recipient never received. Another representative started the case, and you need to continue the investigation.

The case canvas brings the summary, timeline, case details, and suggested response together in one view. Instead of navigating between areas of the classic form to gather context, you can quickly review previous work and plan your response—without repeating troubleshooting steps or asking the customer to repeat information.

## Prerequisites

- Your administrator enabled the case canvas in Copilot Service admin center. Learn more in [Manage canvases in CRM Canvas Designer](../../canvas-designer/manage-canvases.md) to publish the case canvas.

- [Intent](/dynamics365/contact-center/administer/manage-customer-intent-agent) or [knowledge management](../administer/set-up-knowledge-management-embedded-knowledge-search.md) is configured for next best action or knowledge search. 
- Your administrator enabled the [Copilot case summary](/dynamics365/contact-center/administer/copilot-enable-summary) feature to generate case summaries.

## Open a case

1. In Copilot Service workspace, select **Cases**. 
2. Select an existing case.

To switch to the classic case form, select **Open classic view** on the command bar. To return, select **Open canvas view** on the classic form.

:::image type="content" source="../media/case-canvas-mini.png" alt-text="Screenshot of the case canvas showing the command bar, case header, suggested action, case summary, timeline, and case information." lightbox="../media/case-canvas.png":::

## Explore the case canvas

| Area | What you see | Actions |
|---|---|---|
| Command bar | **Resolve case**, **New**, **Assign**, and the additional commands menu. | <ul><li>Review the case before reassigning or resolving it.</li><li>Select **Assign** to reassign the case. Learn more in [Reassign a case](customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md#reassign-a-case).</li><li>Select **Resolve case** to resolve the issue. Learn more in [Resolve a case](customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md#resolve-a-case).</li><li>Use the classic experience for tasks that require classic forms or aren't available on the canvas. Select **Open classic view** to use the classic experience. Learn more in [Work with cases](customer-service-hub-user-guide-create-a-case.md).</li></ul> |
| Case header | Case title, number, priority, customer, owner, and status. | Confirm that you opened the correct case. Identify the issue, customer, and representative responsible for follow-up. |
| Response card | **Reply to customer**, a suggested follow-up, and **Draft email**. | <ul><li>Compare the suggested action with the case description and previous interactions before replying.</li><li>Select **Draft email** to start an email response. Learn more in [View, compose, and respond to email](/power-apps/user/view-compose-email).</li></ul> |
| Summary card | AI-generated case summary and its timestamp. | <ul><li>Read the summary to understand the issue. Compare it with the case description and recorded interactions.</li><li>Copy the summary, refresh it, or use the thumbs-up or thumbs-down buttons to provide feedback. Learn more in [Use Copilot-generated case summaries](copilot-use-summary.md#view-case-summary).</li></ul> |
| **What's happened before?** | **Timeline**, activity categories, and **Log activity**. | <ul><li>Review previous interactions, messages, troubleshooting, and notes.</li><li>Select **All**, **Emails**, **Appointments**, **Notes**, or **Other** to filter the timeline. For example, select **Emails** to find the customer's last message.</li><li>For guidance on recording follow-up work and activity types, learn more in [Understand activities](../implement/customer-service-hub-user-guide-basics.md#understand-activities).</li><li>Review the case details before deciding what to do next, even if the timeline is empty.</li></ul> |
| **What's this case about?** | **Case information**. | <ul><li>Review the description and classification before responding. Check **Subject**, **Case Type**, **Priority**, **Status Reason**, and **Origin**, along with the customer and product.</li><li>Review **Entitlement** and **Parent Case** if those relationships are recorded.</li><li> Learn more about field descriptions and data-entry guidance in [Work with cases](customer-service-hub-user-guide-create-a-case.md).</li><li>If you need a new subject, ask your administrator to update the subject tree. Learn more in [Create and manage subjects](../administer/create-manage-subject-tree.md).</li></ul> |
| App side pane | Knowledge search, if your administrator enables it. | Search for knowledge articles to help resolve the customer's issue. Learn more in [Search knowledge articles](search-knowledge-articles-csh.md#search-for-related-articles-in-copilot-service-workspace). |


## Related information

[Compare classic case forms and the case canvas](../administer/overview-cases.md#choose-a-case-form-experience)  
[Manage canvases in CRM Canvas Designer](../../canvas-designer/manage-canvases.md)  
[Use enhanced case forms to manage cases](enh-casemgmt-csw.md)  
