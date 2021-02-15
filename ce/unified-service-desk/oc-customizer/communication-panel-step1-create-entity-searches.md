---
title: "Create communication panel entity search | MicrosoftDocs"
description: "Learn how to create the communication panel entity search forms."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 1: Create communication panel entity search

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create a communication panel entity search in Unified Service Desk for  Customer Service.

## Prerequisites 

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)
 
## Create entity search

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Entity Searches** and select **+ New**.

5. On the page for new entity searches, specify the following:

     | Field   | Value  |
     |---------|--------|
     | Name    | LiveWorkStreamSearch |
     | Entity   | incident |
     | Markup  | Copy and paste the XML content as shown below  |

```XML
<fetch mapping="logical" output-format="xml-platform" version="1.0" distinct="false">
 <entity name="msdyn_liveworkstream">
 <attribute name="msdyn_capacityrequired" />
 <attribute name="msdyn_fallbacklanguage" />
 <attribute name="msdyn_liveworkstreamid" />
 <attribute name="msdyn_name" />
 <attribute name="msdyn_streamsource" />
 <attribute name="msdyn_workdistributionmode" />
 </entity>
</fetch>
```

6. Save the hosted control.


## ServiceEndPointSearch

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Entity Searches** and select **+ New**.

5. On the page for new entity searches, specify the following:

     | Field   | Value  |
     |---------|--------|
     | Name    | ServiceEndPointSearch |
     | Entity   | incident |
     | Markup  | Copy and paste the XML content as shown below  |

```XML
<fetch mapping="logical" output-format="xml-platform" version="1.0" distinct="false">
 <entity name="serviceendpoint">
 <attribute name="path" />
 <attribute name="description" />
 <attribute name="solutionnamespace" />
 <filter type="or">
 <condition attribute="serviceendpointid" operator="eq" value="8af92c33-e748-4b5a-b772-46cba89bb7ac">
 </condition>
<condition attribute="serviceendpointid" operator="eq" value="38bd8b51-de34-4c45-bf43-5a913aeec49f">
 </condition>
 </filter>
 </entity>
</fetch>
```

6. Save the hosted control. 


> [!div class="nextstepaction"]
> [Next topic: Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md)

## See also

- [Step 3: Create communication panel related-action calls related to communication panel](communication-panel-step3-create-action-calls.md)
- [Step 4: Attach communication panel-related action calls to events](communication-panel-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for communication panel](communication-panel-step5-configure-window-navigation-rule.md) 
- [Step 6: Add the hosted control, action calls, window navigation rule, and events to configurations](communication-panel-step6-add-hosted-control-action-calls-events-configurations.md) 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]