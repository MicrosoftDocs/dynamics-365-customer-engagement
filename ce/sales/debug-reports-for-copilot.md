---
title: Generate debug reports for Copilot in Dynamics 365 Sales
description: Learn how to generate debug reports in Copilot to troubleshoot issues and export detailed diagnostic information in Excel format.
ms.date: 04/23/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Generate debug reports for Copilot in Dynamics 365 Sales

Generate a debug report whenever you encounter issues in Copilot in Dynamics 365 Sales and need to share diagnostic information with your support team. With a simple prompt, you can export a detailed Excel file containing all session activity—queries, intents, skills triggered, timestamps, and correlation IDs—eliminating the need for manual HAR file captures.

## Generate a debug report

1. Select the **Copilot** icon in the top right corner of your app and choose **App skills**.

1. In the message input field, enter the following prompt:
   ```
   Generate Cis Debug report
   ```
1. Press **Enter**.
   Copilot processes your request and prepares the debug report.
1. Select **Export** when the report is ready. 
   The Excel file is downloaded to your device, containing detailed information about your Copilot session.

## Review the debug report and share with support

The exported Excel file contains a comprehensive record of your Copilot session. The report includes the following information for each query:

| Field | Description |
|-------|-------------|
| Query text | The exact text of your Copilot query |
| Detected intent | The action or task Copilot identified based on your input |
| Triggered skill | The specific Copilot capability or feature that handled your query |
| Payload | The structured data passed to the skill |
| Conversation ID | The unique identifier for your Copilot session |
| Timestamp | The date and time the query was processed |
| Correlation ID | A unique identifier that links queries for tracing and support purposes |
| Organization information | Details about your Dynamics 365 organization |

Share the Excel file with your support team to help them understand the context of your issue and provide more effective assistance. 
