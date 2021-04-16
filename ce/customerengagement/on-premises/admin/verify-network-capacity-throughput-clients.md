---
title: "Verify network capacity and throughput for clients | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: fcab11ba-2c58-4656-abf6-5e807d956b49
caps.latest.revision: 7
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin

---
# Verify network capacity and throughput for clients

The primary characteristics of a network that affect the performance of Dynamics 365 Customer Engagement (on-premises) clients, such as the web application or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], are *bandwidth* and *latency*.  
  
-   Bandwidth is the width or capacity of a specific communications channel.  
  
-   Latency is the time required for a signal to travel from one point on a network to another, and is a fixed cost between two points.  
  
One of the main causes of poor performance of Customer Engagement (on-premises) clients is the latency of the network over which the clients connect to the Customer Engagement (on-premises) organization. Lower latencies (measured in milliseconds) generally provide better levels of performance.  
  
Notice that, even if the latency of a network connection is low, bandwidth can become a performance degradation factor if there are many resources sharing the network connection, for example, to download large files or send and receive email.  
  
Networks with high bandwidth don’t guarantee low latency. For example, a network path traversing a satellite link often has high latency, even though throughput is very high. It’s common for a network round trip traversing a satellite link to have five or more seconds of latency. An application designed to send a request, wait for a reply, send another request, wait for another reply, and so on, will wait at least five seconds for each packet exchange, regardless of the speed of the server.  
  
## How to check latency  
 Customer Engagement (on-premises) includes a basic diagnostic tool that analyzes the client-to-organization connectivity and produces a report. To run the Customer Engagement (on-premises) Diagnostics tool, follow these steps.  
  
1. On the user’s computer or device, start a web browser, and sign in to a Customer Engagement (on-premises) organization.  
  
2. Enter the following URL, *<https://myorg.crm.dynamics.com/tools/diagnostics/diag.aspx>*, where *myorg.crm.dynamics.com* is the URL of your Customer Engagement (on-premises) organization.  
  
3. Click **Run**.  
  
The report displays a table with test and benchmark information. Of particular importance is the **Latency Test** row value. This value is an average of twenty individual test runs. Generally, the lower the number, the better the performance of the client. Although users may receive a satisfactory experience by using connections with more latency, for best application performance we recommend that the value be 150 ms (milliseconds) or less.  
  
## Best practices for improving application performance  
  
- Maximize how quickly your forms load. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Optimize form performance](../customize/optimize-form-performance.md)  
  
- Make sure you aren’t using legacy form rendering, which can make forms take significantly longer to load. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - General tab](system-settings-dialog-box-general-tab.md)  
  
### See also  
 [Performance tuning and optimization](../admin/performance-tuning-and-optimization.md)   
 [Key preparation and configuration tasks](../admin/key-preparation-and-configuration-tasks.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]