---
title: "Integrate with CTI systems using CTI adapters| MicrosoftDocs"
description: "Learn about the integration with CTI systems using CTI adapters."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Integrate Unified Service Desk with CTI systems using CTI adapters
To integrate [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] with your [!INCLUDE[pn_computer_telephony_integration_cti](../includes/pn-computer-telephony-integration-cti.md)] system, use a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter. The [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)][!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] framework has components that you can use to build a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [UII CTI Framework Components](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md#Architecture).  
  
 You can create two types of [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapters for [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
- The first type involves defining a *CTI Desktop Manager* component with the required telephony actions for call and agent state management that can communicate with your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system. Next, you configure it as a **CTI Desktop Manager** type of hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], which enables you to handle the interpretation of requests from a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system, and then route it within [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
  [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a generic listener adapter that you can use to test your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system by sending [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] requests on a port with standard parameters that [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] can evaluate as a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] event. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using the generic listener adapter in Unified Service Desk](../unified-service-desk/use-generic-listener-adapter-unified-service-desk.md)  
  
- The second type of adapter involves building all the components of a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter from scratch where you define how to connect to your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system (*CTI Connector*), how the calls and agent states will be managed (*CTI Desktop Manager*), and the look and feel of your softphone (*CTI Controls*). This type of adapter is used if your CTI system uses a service-based polling system or uses a callback/event notification system. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build a custom CTI adapter for Unified Service Desk](../unified-service-desk/build-custom-cti-adapter-unified-service-desk.md)  
  
## In This Section  
 [Use the generic listener adapter in Unified Service Desk](../unified-service-desk/use-generic-listener-adapter-unified-service-desk.md)  
  
 [Build a custom CTI adapter for Unified Service Desk](../unified-service-desk/build-custom-cti-adapter-unified-service-desk.md)  
  
 [Considerations for creating a CTI adapter for Unified Service Desk](../unified-service-desk/consideration-creating-cti-adapter-unified-service-desk.md)  
  
 [Walkthrough: Use generic listener adapter for CTI events](../unified-service-desk/walkthrough-use-the-generic-listener-adapter-for-cti-event-routing.md)  
  
## Related Sections  
 [UII Computer Telephony Integration (CTI) framework](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md)  
  
 [Programming reference](../unified-service-desk/programming-reference.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]