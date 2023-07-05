---
title: Monitor call processing in conversation intelligence
description: Learn how to monitor the status of calls uploaded to conversation intelligence.
ms.date: 07/03/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
content_well_notification: 
  - AI-contribution
---

# Monitor call processing in conversation intelligence

Monitor the status of calls uploaded to conversation intelligence to verify the calls that are processed successfully, in progress, or failed to process.  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Monitor call processing

1. [Open the **Conversation intelligence settings** page](fre-setup-ci-sales-app.md#open-the-conversation-intelligence-settings-page).

1. In the **Call providers and recording** section, select **Monitor call processing**.  
1. In the right pane that opens, select the time frame from the drop-down to view the data for that duration.  
    :::image type="content" source="media/call-processing-monitor.png" alt-text="Screenshot of right pane with the time frame drop-down and call processing insights":::
  
    **Total call status**: This insight shows the total number of calls uploaded and the percentage of calls in progress, failed, and completed.  
    **Completion rate**: This insight shows the percentage of calls that are successfully processed over a period of time.

2. Select **Go to monitoring table** to view the exact call details and their status. For calls that have failed to process, you can view the reason for failure.  
    