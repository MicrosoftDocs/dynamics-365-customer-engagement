---
title: "Call center challenges and how Unified Service Desk can help | MicrosoftDocs"
description: "Understand how Unified Service Desk can help your service agents."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# Call center industry concerns

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Before you start with [!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)], it’s important to have an overview of the call center industry and its challenges, and how [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] helps address these challenges.  
  
<a name="Challenges"></a>   
## Call center challenges  
 Call centers are expected to do more with fewer resources, and there’s a constant drive to increase productivity in terms of call center agents handling more chats, phone calls, emails, and so on. Reducing the average time to handle customers can save companies millions of dollars. Moreover, call centers have, over time, become multichannel customer interaction centers where customers expect that companies provide ways to interface beyond just the phone calls, emails, and chats. As a result, today’s call center agents can expect to take not just phone calls, emails, and chats but also engage with customers through text messages, social channels, self-service websites, and website reviews.  
  
 These are some of the typical challenges faced by the call center industry:  
  
-   Managing a workforce to ensure you are effectively optimizing your staffing levels while not negatively affecting customer satisfaction.  
  
-   Cost per call is closely watched by call centers, and they are always looking for ways to increase their value by upselling or cross-selling. For example, how can you ensure that a customer calling in for support is not only happy with the product purchased, but is also willing to purchase a product during the support experience?  
  
-   Agents are expected to handle multiple customer interactions at the same time.  
  
-   There are too many line-of-business (LOB) applications to interact with and manage to effectively deal with customer data and interaction. This implies high training costs for agents as they have to learn to deal with multiple applications during their customer interaction.  
  
### KPIs for call centers  
 The following table shows the typical key performance indicators (KPIs) that matter for call centers.  
  
|KPI|Description|  
|---------|-----------------|  
|Average Handle Time (AHT)|The average amount of time spent handling a customer incident, and can include time actually talking with the customer and the time spent after the call wrapping up the customer’s call. Decreasing AHT by a second can result in millions of dollars in savings.|  
|Average After Call Work (ACW)|The average time spent on wrap up or after-call work. Agents can go into ACW during a call, and they won’t receive another call when the call ends.|  
|Customer Satisfaction (CSAT)|A measure of the customer satisfaction level based on customer surveys, and usually measured on a Likert or Yes/No scale.|  
|First Call Resolution (FCR)|Percentage of calls resolved in a single call. The likelihood that a customer is satisfied with support is higher when they have to make only one call, which implies a correlation between FCR and CSAT.|  
|Utilization|The percentage of time an agent is actually taking a phone call or handling an email while scheduled to do so. The higher this is, the more productive your agents are.|  
  
<a name="HowUSDHelps"></a>   
## How does Unified Service Desk help?  
 [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides a configurable framework for quickly building agent applications that provide “unified” access to customer information stored in Microsoft Dataverse. Some of the value propositions of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] are:  
  
- **Empower agents with unified access to customer information**: [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides agents with a single service interface for accessing customer information in Dataverse, which helps them deliver fast and accurate customer service.  
  
- **Configuration-based framework for quickly building agent applications**: Quickly configure a highly customized agent application per your organization requirements without using code. This significantly reduces the time and cost to build and customize agent applications.  
  
  > [!NOTE]
  >  Using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to configure agent applications is a bit of an art. It provides a highly configurable interface through the use of replacement parameters and window navigation rules that can be used to dynamically display controls and information based on the context of active operation, much of which requires no code (with the possible exception of [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)]). To properly configure a solution often requires that the administrator have experience working with different configurations and analyzing the results.  
  
- **Centrally configure and manage from within Dataverse**: You can centrally configure and manage your agent applications by using the familiar interface of Dataverse.  
  
- **Session-management capabilities**: Your agents can simultaneously handle multiple customer sessions and the application provides you with the ability to preserve contextual information in each session.  
  
- **Secure access to data based on security in Dataverse**: [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] uses Dataverse security model to govern access to the entities and configuration data. Moreover, you can create configurations in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to group entities, and assign them to users to ensure that they can access only the entities within the assigned configuration.  
  
- **Reduce operational complexity through agent scripts**: Organizations can provide guidance to their contact center agents through standard instructions (called agent scripts) about what tasks to perform and how to do them, while also handling complex processes during customer interactions. This ensures reduced complexity for contact center agents and a consistent experience for customers, which results in higher customer satisfaction.  
  
- **Support for computer telephony integration (CTI)**: [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides a framework for the CTI adapters that can be used within the agent applications to handle screen popping, call routing, softphone control, and other CTI functionalities – provided you follow certain rules while developing these CTI adapters.  
  
  > [!NOTE]
  > [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] doesn’t ship with any out-of-box CTI adapters.  
  
### See also  
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
 [Components of Unified Service Desk](../../unified-service-desk/core-concepts-for-configuring-unified-service-desk.md)   
 [Learn to use Unified Service Desk](../../unified-service-desk/learn-to-use-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]