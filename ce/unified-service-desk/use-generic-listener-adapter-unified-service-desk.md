---
title: "Use the generic listener adapter in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn how to use generic listener adapter that can be used as a testing tool for integrating Unified Service Desk with the CTI middleware applications that have the ability to open a URL on the user's computer when a CTI event occurs."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: b51a92d6-5f3f-4bf4-b326-37e4d7b728ce
caps.latest.revision: 6
author: kabala123
ms.author: kabala
manager: sakudes
---
# Use the generic listener adapter in Unified Service Desk
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a generic listener adapter that can be used as a testing tool for integrating [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] with the [!INCLUDE[pn_computer_telephony_integration_cti](../includes/pn-computer-telephony-integration-cti.md)] middleware applications that have the ability to open a URL on the user's computer when a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] event occurs. The generic listener adapter listens for HTTP request on a known port (5000): `http://localhost:5000/`  

<a name="How"></a>   
## How does the generic listener work  
 The generic listener adapter extracts a query string from the URL, uses the values in the string as parameters to evaluate them as a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] event, and then raises a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] screen pop in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. Once the adapter starts listening on the specified port, it waits for the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] middleware to open a URL such as:  

```  
http://localhost:5000/?ani=1234&dnis=4355&type=phonecall&customerid=49383433  
```  

 In the example URL, the query string is split out and passed to the Global Manager hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] as the following parameters.  


|     Parameter     |                                                                                                                                                                                    Description                                                                                                                                                                                    | Values in the example URL |
|-------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------|
|       `ANI`       |                                                                                                                                           Stands for *automatic number identification*. This is the phone number of the incoming call.                                                                                                                                            |        `ani=1234`         |
|      `DNIS`       |                                                                                                                                       Stands for *dialed number identification service*. This is the phone number that the customer called.                                                                                                                                       |        `dnis=4355`        |
|      `Type`       | This is corresponding to the **Initiating Activity** information in your window navigation rule to route the call, and take appropriate actions. Common values include `phonecall` and `chat`. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [CTI search](../unified-service-desk/consideration-creating-cti-adapter-unified-service-desk.md#CTISearch) |     `type=phonecall`      |
| `Key=value pairs` |                                                                                                                    A collection of key-value pairs that enables the Global Manager hosted control to raise a `CTILookUpRequest` to search the customer record.                                                                                                                    |   `customerid=49383433`   |

 For [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] searches, each of these parameters may be used as replacement parameters. Once a session starts, these parameters can be accessed with the `cti` prefix such as:  

```  
[[cti.ani]]  
```  

 To view a walkthrough that demonstrates the usage of the generic listener adapter for handling [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] events, see [Walkthrough: Use generic listener adapter for CTI events](../unified-service-desk/walkthrough-use-the-generic-listener-adapter-for-cti-event-routing.md).  

<a name="Configure"></a>   
## Configure the CTI Desktop Manager hosted control for generic listener adapter  
 When using the generic listener adapter, you only have to configure the CTI Desktop Manager component; the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] connector and the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] control aren’t required. The CTI Desktop Manager hosted control should be configured to be placed on a `HiddenPanel`, and the following standard values apply for the generic listener adapter in the hosted control configuration page in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  

- **Assembly URI**: Microsoft.Crm.UnifiedServiceDesk.GenericListener  

- **Assembly Type**: Microsoft.Crm.UnifiedServiceDesk.GenericListener.DesktopManager  

  ![Configure CTI Dekstop Manager hosted control](../unified-service-desk/media/usd-cti-desktop-manager.png "Configure CTI Dekstop Manager hosted control")  

  For detailed information about configuring a CTI Desktop Manager hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Configure CTI Desktop Manager hosted control in Unified Service Desk](../unified-service-desk/create-cti-desktop-manager.md#Configure).  

<a name="ChangePort"></a>   
## Change the port of generic listener  
 By default, the generic listener adapter listens for HTTP request on port 5000: `http://localhost:5000/`.  

 You can use the **Options** setting in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to define a different port for the generic listener, if required. To do so:  

1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  

3. Click **Options**.  

4. Click **New** to add a new option.  

5. Type the following values in the fields:  

   |Field|Value|  
   |-----------|-----------|  
   |Name|GenericListener|  
   |Value|Specify the new URL for the listener. For example: `http://localhost:5001/`|  

   ![Define a port for a generic listener](../unified-service-desk/media/usd-change-listener-port.png "Define a port for a generic listener")  

6. Click **Save & Close**.  

### See also  
 [Build a custom CTI adapter for Unified Service Desk](../unified-service-desk/build-custom-cti-adapter-unified-service-desk.md)   
 [Considerations for creating a CTI adapter for Unified Service Desk](../unified-service-desk/consideration-creating-cti-adapter-unified-service-desk.md)   
 [UII Computer Telephony Integration (CTI) framework](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md)
