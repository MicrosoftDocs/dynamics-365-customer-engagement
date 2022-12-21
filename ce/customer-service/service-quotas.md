---
title: Service quotas 
description: This articles provides details about the service quotas for unified routing and omnichannel implementations 
author: mh-jaya 
ms.author: v-jmh 
ms.reviewer: nenellim 
ms.service: dynamics-365 
ms.topic: conceptual 
ms.date: 12/21/2022
ms.custom: bap-template 
---

# Service quotas

This article outlines the service quotas, including those that can be adjusted for **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**, **Dynamics 365 Customer Service Digital Messaging add-on**, and ***Dynamics 365 Customer Service Voice Channel Add-in**. 

> [!NOTE]
> - All measures are at an organizational level for all licensed organizations. The measures don't apply to trial or other non-licensed organizations.
> - If the service, configuration, or conversation limits are indicated as adjustable, contact Microsoft Support if you'd like to change the limits.  
> - All default limits are maximum limits beyond which configuration won't be allowed and conversations will be limited, unless specified otherwise.

## Configuration limits

| Measure       | Description   | Channel or submeasure   |  Default limit  |   Adjustable?  |
|------------ | -----------| -------------- |----------| -----------|
| Intake rules  | Maximum number of intake rules | Record | 100 | No |
| Route-to-queue rules | Maximum number of route-to-queue rulesets and rules per workstream   | Rules | 100 |  Yes  |  
| Classification rules  |  Maximum number of classification rulesets and rules per workstream|  Ruleset <br><br> Rules per ruleset | 10 <br><br> 100   |  No <br><br> No |
|||||

## Conversation limits

| Measure          | Description   |Channel or submeasure   |  Default limit |   Adjustable?  |
|------------      | -----------   | --------------  |----------   | -----------   |
| Message size     | Maximum size of a single message payload, including metadata like timestamps, tags, and links   | Any messaging channel  |  Approximately 28 KB   | No   |
| Incoming conversations or work items  |  Maximum rate of incoming conversations per minute aggregated across channels <br><br><br>Maximum rate of incoming conversations per minute by channel <br><br> | Voice + Live chat + Digital messages + Records <br><br><li>Voice <br> <li>Live chat <br><li>Record <br><li>Social + Direct Line <br>     |<li> 25 per minute<sup>1</sup> <br><br><br><br> <li>7 per minute<sup>2</sup><br> <li>20 per minute<br><li>25 per minute<br> <li>20 per minute<sup>2</sup><br> | Yes <br><br><br><br> Yes <br>    |
|||||

<sup>1</sup> Each of the channels has a defined limit as specified in the table; exceeding the defined limits might lead to poor quality of service. However, when multiple channels are in use, the total conversations per minute should remain under the overall limit of 25. For example, with 5 voice calls per minute, 15 live chat sessions per minute, and 10 digital messages, the total limit is considered as 25. Any conversation coming in after the 25<sup>th</sup> item, irrespective of the channel, might reduce the quality of service.

<sup>2</sup> These are recommended limits beyond which system reliability and performance might reduce. To request a change in these recommended limits, we contact Microsoft Support for additional guidance.


## Miscellaneous limits

| Measure       | Description   |Channel or submeasure   |  Default limit |   Adjustable? |
|------------   | -----------   | --------------          |----------      | -----------                    |
| Bulk user provisioning  | Number of users that can be added (using role attachment) in a single update |  | 500 per 15 minutes<sup>1</sup> |  Yes   |
| Bulk user updates  |  Number of users whose attributes like skills, capacity profiles, amd queue membership that can be edited in a single bulk update   |   | 25 users<sup>1</sup>  | Yes   |
| Bulk user calendar or schedule updates  | Number of users whose calendars can be updated in a bulk  | | 500 per 15 minutes<sup>1</sup>   | Yes   |
| Dataverse Storage Entitlement (aggregated at tenant level)  |  Microsoft Dataverse storage entitlement based on license, includes SQL/DB, file, and log storage in Dataverse. <br><br>More information: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). | <li>Base storage per tenant<br><br><li>Additional storage per Customer Service license <br><br><li>Additional file storage for Voice add-in<br> |<li> 32 GB per tenant<sup>2</sup><br><br><br><li>2.25 GB per user<sup>3</sup><br><br><br><br> <li>35 GB per user<sup>4</sup><br><br><br>| Additional Dataverse storage can be purchased     |
| Time for configuration updates to take effect (includes channel and routing settings, and updates to agent skills, capacity profile, and calendar)  | Maximum time for configuration changes to reflect in the user experience |  All | 15 minutes  |    No  |
| Block size per assignment cycle | Maximum number of unassigned conversations or work items picked per assignment cycle per queue | All   | 100 conversations or work items<sup>5</sup>   |  Yes  |
|||||


<sup>1</sup> These are recommended limits beyond which system reliability and performance might reduce. For any change in these limits, contact Microsoft Support.

<sup>2</sup> 10 GB of SQL/DB storage, 20 GB of file storage, and 2 GB of log storage  

<sup>3</sup> 250 MB of SQL/DB storage and 2 GB of file storage 

<sup>4</sup> 35 GB of file storage 

<sup>5</sup> If there's a shortage of eligible agents to serve the 100 (the default block size) top priority conversations, the auto-assignment can appear to be paused. In such cases, we recommend using features like overflow management to manage high load or reviewing agent availability, scheduling, and skill configuration to expand the eligible agent pool. If these options are not adequate for your use case, contact Microsoft Support with your business scenario and maximum queue depth to check if the block size can be increased. 

> [!NOTE]
> For application limits for channels with third-party integrations like SMS integration via Twilio or TeleSign, see the third-party documentation.

## Next steps

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Provision unified routing for Customer Service](provision-unified-routing.md)  

## See also

[Service protection API limits](/power-apps/developer/data-platform/api-limits)  
[Service limits in Customer Insights - Dynamics 365 Customer Insights](/customer-insights/service-limits)  
[Service limits for Azure Communication Services](/azure/communication-services/concepts/service-limits)  