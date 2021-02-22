---
title: "Supported messages and entities for plug-ins (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic contains information about the message and entity combinations that support execution of plug-ins for Dynamics 365 Customer Engagement (on-premises) Customer Engagement."
ms.custom: on-premise
ms.date: 2/5/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b3902754-0cbc-49d5-ac37-3f6f89a89e90
caps.latest.revision: 47
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Supported messages and entities for plug-ins

This topic identifies the message and entity combinations that support offline execution of plug-ins for [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)]. For information on server registered plug-ins that do not require offline execution, see [Available events](/powerapps/developer/common-data-service/event-framework#available-events).
  
 The **Message Availability** column of the table shown below indicates whether a message is available online, offline, or both. The **Entity Deployment** column indicates if the entity can be deployed on the server, on the client, or both. A value of **null** in the **Primary Entity** column means that there is no primary entity associated with the message. The same applies to the **Secondary Entity** column.  
  
 In plug-in code, you can send any message to the web services except those messages that create or update metadata.  
  
 Custom entities support the same base messages as system entities, depending on whether the entity is organization-owned or user-owned. For more information, see [Actions on Entity Records](introduction-entities.md#ActionsOnEntityRecords).  
  
> [!NOTE]
>  The term *offline* applies to the [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)]. The term *client* can apply to either [!INCLUDE[pn_crm_outlook_online](../includes/pn-crm-outlook-online.md)] or [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)].  
> 
>  Whether a message is available online or offline can be determined programmatically or through a query by inspecting the `SdkMessage.Availability` attribute. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
  
<a name="orgowned"></a>   
## Supported messages for custom entities  
 Custom entities can be either organization-owned or user-owned, which defines the set of messages available for the entity. The following table lists the messages for custom entities that support the execution of plug-ins.  
  
|**Message Name**|**Ownership Type**|**Message Availability**|**Entity Supported Deployment**|  
|----------------------|------------------------|------------------------------|-------------------------------------|  
|Assign|User-owned entities only|Server|Server|  
|Create|User-owned and organization-owned entities|Both|Server|  
|Delete|User-owned and organization-owned entities|Both|Server|  
|GrantAccess|User-owned entities only|Server|Server|  
|ModifyAccess|User-owned entities only|Server|Server|  
|Retrieve|User-owned and organization-owned entities|Both|Server|  
|RetrieveMultiple|User-owned and organization-owned entities|Both|Server|  
|RetrievePrincipalAccess|User-owned entities only|Both|Server|  
|RetrieveSharedPrincipalsAndAccess|User-owned entities only|Both|Server|  
|RevokeAccess|User-owned entities only|Server|Server|  
|SetState|User-owned and organization-owned entities|Both|Server|  
|Update|User-owned and organization-owned entities|Both|Server|  
  
<a name="DefaultEntities"></a> 
  
## Supported messages for default entities

 Before you consider writing a plug-in, you should verify that the target message and entity request supports the execution of plug-ins. Since Dynamics 365 is periodically updated with new messages and entities, it is best to query the organization for this information. This can be done using the Plug-in registration tool or running a fetchXML query as described below.

To verify if a message and entity combination supports execution of plug-ins using the Plug-in Registration tool, follow these steps.

1. Run the tool and connect to a D365 organization.
2. In the **Registered Plug-ins & Custom Workflow Activities** list, expand an assembly that contains registered plug-ins. You can even do this step on a system assembly since you will not actually be completing the step registration.
3. Right-click on a plug-in in the list and choose **Register New Step**.
4. Enter the target message and primary entity in the appropriate fields to see if that combination is supported for plug-in registration.
5. Cancel (close) the step registration form and exit the tool.

To verify if a message and entity combination supports execution of plug-ins using a database query, use Advanced Find or a community tool (e.g., [FetchXML Builder](https://fxb.xrmtoolbox.com)) to execute the following fetchXML query. When using Advanced Find, you must create the query interactively.

For Outlook client offline plug-ins:
```xml
<fetch>
  <entity name='sdkmessage' >
    <attribute name='name' />
    <link-entity name='sdkmessagefilter' alias='filter' to='sdkmessageid' from='sdkmessageid' link-type='inner' >
      <filter type='and' >
        <condition attribute='iscustomprocessingstepallowed' operator='eq' value='1' />
        <condition attribute='isvisible' operator='eq' value='1' />
        <condition attribute='availability' operator='ne' value='0' />
      </filter>
      <attribute name='primaryobjecttypecode' />
    </link-entity>
    <filter>
      <condition attribute='isprivate' operator='eq' value='0' />
      <condition attribute='name' operator='not-in' >
        <value>SetStateDynamicEntity</value>
        <value>RemoveRelated</value>
        <value>SetRelated</value>
        <value>Execute</value>
      </condition>
    </filter>
    <order attribute='name' />
  </entity>
</fetch>
```

### See also

[Write plug-ins to extend business processes](write-plugin-extend-business-processes.md)<br/>
[Available events](/powerapps/developer/common-data-service/event-framework#available-events)<br/>
[Plug-in Development](plugin-development.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]