---
title: "Create agent application using Unified Service Desk | MicrosoftDocs"
description: 
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
tags: NoHandoff
---
# Create agent application using Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

 You can use [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] in the following ways to create an agent application customized for your organization:  
  
- **Configure [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] entities**: Use Microsoft Dataverse or [!INCLUDE[proc-crm-for-outlook](../includes/proc-crm-for-outlook.md)] to configure the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] entities that are created in your Dataverse instance when you deploy [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] provides a highly configurable interface that can be used to dynamically display controls and information based on the context of the active operation, which eventually defines the user interface and functionalities in your agent application. Creating or developing agent applications by configuring the [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] entities in Dataverse doesn’t require you to write code, which reduces the lead time to develop a highly customized agent application per your organization requirements. This is the preferred way if you have to primarily deal with customer data available in Dataverse.  
  
   *Target audience*: System administrator or system customizer who has experience working with different configurations in Dataverse, analyzing the results, and improving or changing the configurations in an iterative manner until the desired functionality and user experience is achieved.  
  
   To get started with configuring [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)], see [Components of Unified Service Desk](core-concepts-for-configuring-unified-service-desk.md).  
  
- **Extend [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] to integrate with other applications**: [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] is built using the [!INCLUDE[pn-user-interface-integration-uii](../includes/pn-user-interface-integration-uii.md)] framework, which enables you to build and deploy composite agent applications that can provide unified access to customer information in Dataverse and external systems. Also, the [!INCLUDE[pn-computer-telephony-integration-cti](../includes/pn-computer-telephony-integration-cti.md)] framework of [!INCLUDE[pn-uii-acronym](../includes/pn-uii-acronym.md)] enables organizations to build adapters to connect [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] with their existing [!INCLUDE[pn-cti-acronym](../includes/pn-cti-acronym.md)] infrastructure to support customer communication in agent desktops over various channels such as chat, email, or telephone. To integrate with external applications, you’ll have to extend [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] by writing code. [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)] provides you with [!INCLUDE[pn-Visual-Studio](../includes/pn-Visual-Studio.md)] project templates that you can use to create the modules and applications so you can integrate and interact with data in external applications.  
  
   *Target audience*:   Software developer who has experience in creating applications/solutions using [!INCLUDE[pn-NET-Framework](../includes/pn-NET-Framework.md)], [!INCLUDE[pn-ms-Windows-Presentation-Foundation](../includes/pn-ms-Windows-Presentation-Foundation.md)], XAML, and [!INCLUDE[pn-Java](../includes/pn-Java.md)].  
  
   To get started with extending [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)], see [Unified Service Desk and the UII framework](unified-service-desk-uii-framework.md).  
  
  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] ![Video symbol](./media/usd-video-thumbnail.png "Video symbol") [Video: Overview of Unified Service Desk (5:00)](https://go.microsoft.com/fwlink/p/?LinkId=506900)  
  
> [!IMPORTANT]  
> Before you start using [!INCLUDE[pn-unified-service-desk](../includes/pn-unified-service-desk.md)], you must install and deploy it. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Install, deploy, and upgrade Unified Service Desk](../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md).  
    
  
## Related Sections  

[Components of Unified Service Desk](core-concepts-for-configuring-unified-service-desk.md)  
  
[Unified Service Desk and the UII framework](unified-service-desk-uii-framework.md)


## Reference

 [Unified Service Desk Team Blog](https://blogs.msdn.com/b/usd/)


[!INCLUDE[footer-include](../includes/footer-banner.md)]