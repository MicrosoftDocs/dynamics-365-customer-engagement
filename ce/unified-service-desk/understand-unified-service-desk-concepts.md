---
title: "Understand Unified Service Desk for Dynamics 365 Customer Engagement concepts | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-08-01"
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 2866c682-9f3f-422f-b2e0-adc61244727a
caps.latest.revision: 5
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# Understand Unified Service Desk concepts

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a configurable and extensible framework for quickly building applications for call centers so that agents can get a unified view of the customer data stored in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Customer Engagement instance and external applications. You can aggregate customer information from different areas in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement and external applications into an integrated desktop that provides a 360° view of the customer interactions. This gives your customer service agent immediate access to business critical information so they can effectively engage with customers and address queries and issues. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What makes up Unified Service Desk](https://technet.microsoft.com/library/dn646899.aspx#USD) and [Call center challenges and how Unified Service Desk can help](https://technet.microsoft.com/library/dn646905.aspx) in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Administration Guide.  
  
 To develop an agent application using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], you can directly configure the  [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] entities in your Customer Enagement instance, which does not require you to write code. To integrate with external applications, you can write code to extend [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
## Configure Unified Service Desk entities

Use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] or [!INCLUDE[proc_crm_for_outlook](../includes/proc-crm-for-outlook.md)] to configure the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] entities that are created in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance when you deploy [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a highly configurable interface that can be used to dynamically display controls and information based on the context of the active operation, which eventually defines the user interface and functionalities in your agent application. Creating or developing agent applications by configuring the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] entities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] doesn’t require you to write code, which reduces the lead time to develop a highly customized agent application per your organization requirements. This is the preferred way if you have to primarily deal with customer data available in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].

*Target audience*: System administrator or system customizer who has experience working with different configurations in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], analyzing the results, and improving or changing the configurations in an iterative manner until the desired functionality and user experience is achieved.

To get started with configuring [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Core concepts for configuring Unified Service Desk](../unified-service-desk/core-concepts-for-configuring-unified-service-desk.md).  
  
## Extend Unified Service Desk to integrate with other applications

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is built using the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] framework, which enables you to build and deploy composite agent applications that can provide unified access to customer information in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and external systems. Also, the [!INCLUDE[pn_computer_telephony_integration_cti](../includes/pn-computer-telephony-integration-cti.md)] framework of [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] enables organizations to build adapters to connect [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] with their existing [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] infrastructure to support customer communication in agent desktops over various channels such as chat, email, or telephone. To integrate with external applications, you’ll have to extend [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by writing code. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides you with [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] project templates that you can use to create the modules and applications so you can integrate and interact with data in external applications.  
  
*Target audience*:   Software developer who has experience in creating applications/solutions using [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)], [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)], XAML, and [!INCLUDE[pn_Java](../includes/pn-java.md)].  
  
To get started with extending [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Unified Service Desk and the UII framework](../unified-service-desk/unified-service-desk-uii-framework.md).
 
