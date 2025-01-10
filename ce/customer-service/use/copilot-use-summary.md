---
title: Use Copilot to summarize cases
description: Learn how agents can use Copilot to summarize cases in Customer Service workspace.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 11/28/2024
ms.custom: bap-template 
---

# Summarize cases


Copilot case summaries help you quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

## Navigation

- In Customer Service workspace, navigate to a case to view the case summary card. You can also generate a case summary from **Ask a question**.
- When you sign in to a non-Microsoft CRM, you can generate case summary as follows:
   - Launch the embedded experience and then login to your Dynamics account.
   - In the Copilot help pane that appears, select **Ask a question**.
   - Select the Copilot icon and then then select **Summarize case**.

## Summarize cases in Customer Service workspace

### Prerequisites

Your administrator has enabled the Copilot case summary feature.

### View case summary

[!INCLUDE[cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default so that your screen isn't cluttered with information. Select the card to expand the summary.

:::image type="content" source="../media/copilot-case-summary.png" alt-text="Screenshot of a Copilot case summary.":::

You can copy the summary, refresh it, and provide feedback.

> [!NOTE]
> - You can also generate a case summary for cases that are resolved or canceled.
> - A case summary isn't generated if the descriptions added in the source case fields that Copilot uses are less than 38 words in English, without counting spaces.

Alternatively, you can also generate a case summary from the **Ask a question** tab in the Copilot help pane. Learn more in [Summarize cases and ask about case data](use-ask-a-question.md#summarize-cases-and-ask-about-case-data).

## Summarize cases in non-Microsoft CRMs

[!INCLUDE[cc-feature-availability-embed-only](../../includes/cc-feature-availability-embed-only.md)]

If you are using the embed experience or Microsoft 365 Copilot for Service, in a non-Microsoft CRM, the case summary appears as a card on the **Ask a question** tab in the Copilot help pane. 

> [!IMPORTANT]
> - Case summary is a preview feature in Microsoft 365 Copilot for Service.
> - Preview features aren’t meant for production use and might have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback.

Copilot generates case summaries based on the following case information for the corresponding CRMs:

**Salesforce**: Copilot generates the case summary based on the case fields and activities associated with the case. The case summary includes the following information:

  - **Case fields**: case ID, description, subject, priority, type, customer name, case URL, email, and product name if the service representative has access.
  - **Text post**: ID, Title, body, createddate
  - **Comment**: Id, body, createddate
  - **Email**: ID, body, lastmodifieddate, fromaddress, toaddress.

**ServiceNow**: Copilot generates the case summary based on the incident data and activities that are attached with the incident. The case summary includes the following information:

 - **Incident data** : incident ID, description, short description, priority, type, customer name, incident URL, email, and notes.
 - **Work notes and comments**: ID, TextContext, Created Date.
 - **Email**: Id, Body, Created Date, FromAddress, ToAddress

In the non-Microsoft CRM, you can generate the case summary as follows:

- Select the required case or incident.
- Select **Microsoft contact center**. The Copilot help pane appears.
- In the **Ask a question** tab, select **Summarize case**. The case summary appears in the help pane.

You can copy the summary, refresh it, and provide feedback.


## Next steps

[Use Copilot to solve customer issues](use-copilot-features.md)
