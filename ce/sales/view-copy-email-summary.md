---
title: View and copy email summary
description: View the summary of email through Copilot in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/25/2023
ms.custom: bap-template 
---

# View and copy email summary

When interacting with customers over email, you often need to update the records with the latest information. Manually updating the records each time you interact with customers via email can be time-consuming and error prone. Additionally, manual update could potentially add noise to the records, by overloading records with email exchanges.

Dynamics 365 Sales uses copilot to summarize email conversations and provides you with options to view and copy the summary as a note to a record.

## Prerequisites

Ensure that the Copilot feature is enabled in your organization. More information: [Enable and set up copilot capabilities](enable-setup-copilot.md)

## Considerations

Review the following considerations before you use the email summary feature:

- Email summary is generated only for emails or email threads with more than 1000 characters, which is about 180 words.

- The email summary contains up to 400 characters.

- You must verify the AI-generated content carefully, as it can have mistakes. It is your responsibility to review and edit the AI-generated summaries to make sure it’s accurate and appropriate.

## View the email summary

The summary provides the highlights of the email conversations. To view the email summary: 

1. Open a record and select an email from the **Timeline** or the **Up next** widget. 

    >[!NOTE]
    >The email summary feature is not supported when you open an email from  **Activities** under the **My Work** site map.

2. In the **Sales Copilot** pane, go to the **Compose** tab.  
    The email summary is displayed in the **Summary of this email** section.

    :::image type="content" source="media/copilot-email-summary-section.png" alt-text="Screenshot of the email summary section.":::

    Now, you can copy the summary for the email and use it for future references.

## Copy the email summary

Copy the email summary to clipboard and save it in a desired location for future references such as notes in records. To copy the email summary, in the **Summary of this email** section, select the **Copy** icon (:::image type="content" source="media/copy-clipboard.png" alt-text="Screenshot of the copy icon.":::).  

### See also

[Compose and send email messages using Copilot](compose-send-email-copilot.md)