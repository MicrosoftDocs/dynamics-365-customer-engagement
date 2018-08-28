---
title: "Dynamics 365 (online) Government - Feature availability | MicrosoftDocs"
ms.custom: ""
ms.date: 08/28/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5cf2c742-d2d7-46cd-9a97-67befd696820
caps.latest.revision: 16
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Dynamics 365 (online) Government - Feature availability

[!INCLUDE[cc-applies-to-update-8-2-0](../../includes/cc_applies_to_update_8_2_0.md)]

Microsoft strives to maintain functional parity between our commercially available service and that which is servicing the Dynamics 365 Customer Engagement for U.S. Government - referred to as Dynamics 365 GCC. However, there are notable exceptions to this affected by dependent service or partner-solution availability, market priorities, or compliance regulations.

At this time, preview features in the commercial offering are not available to Dynamics 365 Government Community Cloud (GCC) customers. This is intentional, as the GCC represents a community leveraging our generally available services, further protected with heightened compliance demands of the U.S. Government and Government community customers.

Dynamics 365 GCC currently supports the following versions:

- Dynamics 365, version 9.0.x
- Dynamics 365, version 8.2.x
- Microsoft Dynamics CRM Online 2016, Update 1

There are certain experiences that are currently not available with Dynamics 365 GCC.  We continue to evaluate these for incorporation into future releases. The following generally available features are not currently available:

- [Activity Logging](https://docs.microsoft.com/dynamics365/customer-engagement/admin/enable-use-comprehensive-auditing)
- [AppSource](https://appsource.microsoft.com/?product=dynamics-365-business-central%3Bdynamics-365-for-customer-services%3Bdynamics-365-for-field-services%3Bdynamics-365-for-finance-and-operations%3Bdynamics-365-for-project-service-automation%3Bdynamics-365-for-sales) (ability to install Applications directly from AppSource)
- [Data Export Service](https://appsource.microsoft.com/en-us/product/dynamics-365/mscrm.44f192ec-e387-436c-886c-879923d8a448)
- [Organization Insights](https://appsource.microsoft.com/product/dynamics-365/mscrm.04931187-431c-415d-8777-f7f482ba8095)
- [CAFEx Integration](https://appsource.microsoft.com/product/dynamics-365/cafexliveassistfor365.27ac7522-68b2-44a2-9f36-da66a47e2b19)
- [Connected Field Service](https://msdn.microsoft.com/library/mt744253.aspx)
- [Gamification](https://docs.microsoft.com/dynamics365/customer-engagement/gamification/manage-gamification-in-dynamics-365-online)
- [Home.Dynamics.com](http://home.dynamics.com/)
- [Insights, powered by InsideView](https://appsource.microsoft.com/en-us/product/dynamics-365/insideviewinc.b5386882-4312-4d69-879a-23081897c012)
- [Mobile offline](https://docs.microsoft.com/dynamics365/customer-engagement/mobile-app/configure-mobile-offline-synchronization-dynamics-365-phones-tablets)
- [PowerBI “embedded” user dashboard experience](https://docs.microsoft.com/power-bi/service-connect-to-microsoft-dynamics-crm)
- [Relevance Search](https://docs.microsoft.com/dynamics365/customer-engagement/basics/relevance-search-results)
- [Resource Scheduling Optimization](https://docs.microsoft.com/dynamics365/customer-engagement/common-scheduler/resource-scheduling-optimization)
- [Versium Predict](https://docs.microsoft.com/dynamics365/customer-engagement/versium-predict/versium-predict)

There are a number of other business application apps and services that are not currently available as a service operating within the GCC at this time. They include:

- [Microsoft PowerApps](https://docs.microsoft.com/powerapps/)
- [Microsoft Flow](https://docs.microsoft.com/flow/) – Please note that it is technically possible to connect to Dynamics 365 GCC from Flow.
- [Microsoft Dynamics 365 for Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/overview)
- [Microsoft Dynamics 365 for Talent](https://docs.microsoft.com/dynamics365/unified-operations/talent/)
- [Microsoft Dynamics Social Engagement](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/get-started) – Please note that while this is not available in GCC, it is available to purchase and associate to a customer’s tenant running GCC services; all integration points will work as they do in our non-GCC environments.
- [Microsoft Dynamics Voice of the Customer](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/voice-of-customer/get-feedback-surveys) – Please note that while this is not available in GCC, it is available to install into a customer’s Instance(s) running GCC services; all integration points will work as they do in our non-GCC environments. 
- [Microsoft Dynamics 365 for Finance and Operations](https://docs.microsoft.com/dynamics365/unified-operations/fin-and-ops/) - Please note that while this is not available in GCC, it is available to purchase and associate to a customer’s tenant running GCC services.  
- [Microsoft Dynamics 365 for Retail](https://docs.microsoft.com/dynamics365/unified-operations/retail/) - Please note that while this is not available in GCC, it is available to purchase and associate to a customer’s tenant running GCC services.


<a name="BKMK_NetworkPorts"></a>   

## Network ports for [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)]  
 The following ports are open for outbound connections between [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)] and internet services.  

- 80 HTTP  
- 443 HTTPS  
- 465 Secure SMTP  
- 587 Secure SMTP
- 995 Secure POP3  

Customizations or email configurations in Dynamics 365 GCC can only use these ports.

### See also  
 [Microsoft Dynamics 365 (online) Government](microsoft-dynamics-365-government.md)<br/>
 [Important changes coming in Dynamics 365 Customer Engagement](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming)<br/>
 [Dynamics 365 IP Address Ranges](https://support.microsoft.com/help/2728473/microsoft-dynamics-crm-online-ip-address-ranges)<br/>
 [PowerBI for US Government Customers](https://docs.microsoft.com/power-bi/service-govus-overview)<br/>
 [Compliance Offerings for Dynamics 365](https://www.microsoft.com/trustcenter/compliance/complianceofferings?product=Dynamics365)
