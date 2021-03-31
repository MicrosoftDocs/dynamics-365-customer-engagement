---
title: "Build a custom CTI adapter for Unified Service Desk | MicrosoftDocs"
description: "Learn about building a custom computer telephony integration (CTI) adapter to connect to a CTI system that provides access to events and CTI actions via web services or APIs."
author: mh-jaya
ms.author: v-jmh
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
# Build a custom CTI adapter for Unified Service Desk
You can build a custom [!INCLUDE[pn_computer_telephony_integration_cti](../includes/pn-computer-telephony-integration-cti.md)] adapter to connect to a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system that provides access to events and [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] actions via web services or APIs.  
  
 The [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)][!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] infrastructure supports connecting to both models (web services or APIs). Building a custom adapter involves:  
  
1. Creating the connection bridge to the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system. [Create a CTI Connector](../unified-service-desk/create-cti-connector.md)  
  
2. Creating a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] manager that communicates between the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] connection layer and [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to manage calls and the agent state. [Create a CTI Desktop Manager](../unified-service-desk/create-cti-desktop-manager.md)  
  
3. Define the user interface or the controls on the agent desktop that helps in call management and displays the agent state. [Create a CTI Control](../unified-service-desk/create-cti-control.md)  
  
### See also  
 [Considerations for creating a CTI adapter for Unified Service Desk](../unified-service-desk/consideration-creating-cti-adapter-unified-service-desk.md)   
 [Integrate with CTI systems using CTI adapters](../unified-service-desk/integrate-cti-systems-cti-adapters.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]